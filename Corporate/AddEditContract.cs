using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using Npgsql;

namespace cdo_den
{
    public partial class AddEditContract : Form
    {
        Contract ctr;
        DataGridViewRow row;
        bool editMode = false;

        NpgsqlConnection con = new NpgsqlConnection(Auth.con_string);

        List<int> eduPeriods = new List<int>();
        List<double> costs = new List<double>();
        int currentProgramId = -1;

        public AddEditContract(Contract c, DataGridViewRow r = null)
        {
            ctr = c;
            row = r;
            InitializeComponent();
        }

        private void AddEditContract_Load(object sender, EventArgs e)
        {
            fillEduProgram();
            if (row != null)
                activateEditMode();
        }

        private void comboBox_EduProgram_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentProgramId = comboBox_EduProgram.SelectedIndex;
            chageEndDate();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            chageEndDate();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            saveChanges();
        }






        private void saveChanges()
        {
            if (currentProgramId == -1)
                return;

            string text;

            var ed = dateTimePicker1.Value;
            string day = $"{ed.Day}".Length == 1 ? $"0{ed.Day}" : $"{ed.Day}";
            string monht = $"{ed.Month}".Length == 1 ? $"0{ed.Month}" : $"{ed.Month}";
            string date = $"{day}.{monht}.{ed.Year}";

            if (editMode)
                text = $"UPDATE \"contract\" SET \"ProgramID\"={currentProgramId+1}, \"Student_FullName\"='{textBox_Student_FullName.Text}', " +
                    $"\"Payer_FullName\"='{textBox_Payer_FullName.Text}', \"Payer_Address\"='{textBox_Payer_Address.Text}', " +
                    $"\"Cost\"={costs[currentProgramId]}, \"Paid\"={checkBox_Paid.Checked}, \"StartDate\"='{date}' WHERE \"ID\" = {row.Cells[0].Value};";
            else
                text = "INSERT INTO \"contract\"" +
                    "(\"ProgramID\", \"Student_FullName\", \"Payer_FullName\", \"Payer_Address\", \"Cost\", \"Paid\", \"StartDate\", \"Identifier\") " +
                    $"VALUES ({currentProgramId+1}, '{textBox_Student_FullName.Text}', '{textBox_Payer_FullName.Text}', '{textBox_Payer_Address.Text}', " +
                    $"{costs[currentProgramId]}, {checkBox_Paid.Checked}, '{date}', '{getIdentifier()}')";

            try
            {
                con.Open();
                var cmd = new NpgsqlCommand(text, con);
                cmd.ExecuteNonQuery();
                con.Close();
                ctr.fillData();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private string getIdentifier()
        {
            List<string> invalidIdentifierValues = new List<string>();
            con.Open();
            using (var cmd = new NpgsqlCommand("select \"Identifier\" from \"contract\"", con))
            {
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                    invalidIdentifierValues.Add(reader.GetString(0));
            }
            con.Close();

            string res;
            string alf = "0123456789";
            Random r = new Random();
            do
            {
                res = "";
                for (int i = 0; i < 10; i++)
                    res += alf[r.Next(0, 9)];
            }
            while (isHaveValueInArray(invalidIdentifierValues, res));

            return res;
        }

        private bool isHaveValueInArray(List<string> l, string v)
        {
            bool res = false;
            foreach(string s in l)
                if (s == v)
                    { res = true; break; }
            return res;
        }

        private void chageEndDate()
        {
            if (currentProgramId != -1)
            {
                var ed = dateTimePicker1.Value.AddDays(31 * eduPeriods[currentProgramId]);
                string day = $"{ed.Day}".Length == 1 ? $"0{ed.Day}" : $"{ed.Day}";
                string monht = $"{ed.Month}".Length == 1 ? $"0{ed.Month}" : $"{ed.Month}";
                label_EndDate_Value.Text = $"{day}.{monht}.{ed.Year}";
            }
        }

        private void fillEduProgram()
        {
            using (var da = new NpgsqlDataAdapter("select * from \"educational_program\" order by \"ID\" asc", con))
            {
                var dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    costs.Add((double)dr[4]);
                    eduPeriods.Add((int)dr[2]);
                    comboBox_EduProgram.Items.Add($"{dr[1]} (ID: {dr[0]})   |   {dr[2]} мес.   |   {dr[4]} ₽");
                }
            }
        }

        private void activateEditMode()
        {
            editMode = true;
            Application.OpenForms[3].Text = "ЦДО | Редактирование договора";
            button_Save.Text = "Применить";
            comboBox_EduProgram.SelectedIndex = Convert.ToInt32(row.Cells[1].Value) - 1;
            currentProgramId = comboBox_EduProgram.SelectedIndex;
            textBox_Student_FullName.Text = Convert.ToString(row.Cells[2].Value);
            textBox_Payer_FullName.Text = Convert.ToString(row.Cells[3].Value);
            textBox_Payer_Address.Text = Convert.ToString(row.Cells[4].Value);
            checkBox_Paid.Checked = Convert.ToBoolean(row.Cells[6].Value);
            dateTimePicker1.Value = Convert.ToDateTime(row.Cells[7].Value);
            var ed = Convert.ToDateTime(row.Cells[8].Value);
            string day = $"{ed.Day}".Length == 1 ? $"0{ed.Day}" : $"{ed.Day}";
            string monht = $"{ed.Month}".Length == 1 ? $"0{ed.Month}" : $"{ed.Month}";
            label_EndDate_Value.Text = $"{day}.{monht}.{ed.Year}";
        }
    }
}
