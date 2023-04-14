using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace cdo_den
{
    public partial class Contract : Form
    {
        NpgsqlConnection con = new NpgsqlConnection(Auth.con_string);

        public Contract()
        {
            InitializeComponent();
        }

        private void Contract_Load(object sender, EventArgs e)
        {
            fillData();
        }

        private void button_AddContract_Click(object sender, EventArgs e)
        {
            AddEditContract aec = new AddEditContract(this);
            aec.ShowDialog();
        }

        private void button_EditContract_Click(object sender, EventArgs e)
        {
            AddEditContract aec = new AddEditContract(this, dataGridView1.SelectedRows[0]);
            aec.ShowDialog();
        }

        private void button_DeleteContract_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            deleteContract(id);
        }

        private void button_Print_Click(object sender, EventArgs e)
        {
            PrintContract pc = new PrintContract(dataGridView1.SelectedRows[0]);
            pc.ShowDialog();
        }

        private void Contract_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[1].Show();
        }




        public void fillData()
        {
            using (var da = new NpgsqlDataAdapter("select \"contract\".\"ID\", \"ProgramID\" as \"ID программы\", " +
                "\"Student_FullName\" as \"ФИО обучающегося\", \"Payer_FullName\" as \"ФИО плательщика\", " +
                "\"Payer_Address\" as \"Адрес плательщика\", \"contract\".\"Cost\" as \"Цена\", \"Paid\" as \"Оплачен\", " +
                "\"StartDate\" as \"Дата начала\", \"StartDate\" + (\"educational_program\".\"TrainingPeriod\" * 31 ) as " +
                "\"Дата окончания\", \"Identifier\" from \"contract\" inner join \"educational_program\" on \"educational_program\".\"ID\" = " +
                "\"contract\".\"ProgramID\"", con))
            {
                var dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["Identifier"].Visible = false;
            }
        }

        private void deleteContract(int id)
        {
            if (MessageBox.Show($"Вы уверены, что хотите удалить договор с ID {id}?", "Удаление договора", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                con.Open();
                var cmd = new NpgsqlCommand($"delete from \"contract\" where \"ID\" = {id}", con);
                cmd.ExecuteNonQuery();
                con.Close();
                fillData();
            }
        }
    }
}
