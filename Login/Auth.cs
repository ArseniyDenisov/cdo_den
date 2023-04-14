using System;
using System.Windows.Forms;
using Npgsql;

namespace cdo_den
{
    public partial class Auth : Form
    {
        string[,] DBCon = new string[,] {
            { "db.edu.cchgeu.ru", "193_Kogtev", "193_Kogtev", "193_Kogtev" },
            { "localhost:5433", "cdo", "postgres", "2510123a"} };

        static public string con_string;
        NpgsqlConnection con;

        int tryCounter = 0;
        string lastLogin = "";

        public Auth()
        {
            InitializeComponent();

            title_TryCount.Text = $"Осталось попыток: {3 - tryCounter}";
            ActiveControl = textBox_Login;
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            tryConnectToDB();
        }

        private void textBox_Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox_Password.Focus();
        }

        private void textBox_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBox_Login.Text != "" && textBox_Password.Text != "")
                tryAuth();

        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            if (textBox_Login.Text != "" && textBox_Password.Text != "")
                tryAuth();
        }




        private void tryAuth()
        {
            string currentLogin = textBox_Login.Text;
            string currentPass = textBox_Password.Text;

            con.Open();
            using (var cmd = new NpgsqlCommand($"select \"user_data\".\"Password\", \"user_data\".\"AccountID\", " +
                $"\"account\".\"RuleID\", \"account\".\"Surname\", \"account\".\"Name\", \"account\".\"Patronymic\" " +
                $"from \"user_data\" inner join \"account\" on \"account\".\"ID\" = \"user_data\".\"AccountID\" " +
                $"where \"user_data\".\"Login\" = '{currentLogin}'", con))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        lastLogin = currentLogin;

                        if (reader.GetString(0) == currentPass)
                        {
                            int accountId = reader.GetInt32(1);
                            int ruleId = reader.GetInt32(2);
                            string surname = reader.GetString(3);
                            string name = reader.GetString(4);
                            string patronymic = reader.GetString(5);

                            textBox_Login.Clear();
                            textBox_Login.Focus();
                            textBox_Password.Clear();

                            CorporateMenu cm = new CorporateMenu(accountId, ruleId, surname, name, patronymic);
                            cm.Show();
                            Hide();
                        }
                        else
                            addTry(1);
                    }
                    else
                        addTry(0);
                }
            }
            con.Close();
        }

        private void addTry(int type)
        {
            string ex = "";

            switch (type)
            {
                case 0:
                    ex = "Аккаунт не существует.";
                    break;
                case 1:
                    ex = "Пароль неверен.";
                    tryCounter++;
                        break;
                default:
                    break;
            }

            if (tryCounter == 3)
            {
                tryCounter = 0;
                ResetPassword rp = new ResetPassword(lastLogin);
                rp.ShowDialog();
            }
            else
                MessageBox.Show(ex, "Ошибка входа");

            title_TryCount.Text = $"Осталось попыток: {3 - tryCounter}";
        }

        private void tryConnectToDB()
        {
            bool lucky = false;

            for (int i = 0; i < DBCon.Length / 4; i++)
            {
                con_string = $"Host={DBCon[i, 0]};Database={DBCon[i, 1]};Username={DBCon[i, 2]};Password={DBCon[i, 3]};";
                con = new NpgsqlConnection(con_string);
                try
                {
                    con.Open();
                    con.Close();
                    lucky = true;
                }
                catch { }

                if (lucky)
                    break;
            }

            if (!lucky)
            {
                MessageBox.Show("Не удалось подключиться к базе данных.", "Ошибка");
                button_Login.Enabled = false;
                textBox_Login.Enabled = false;
                textBox_Password.Enabled = false;
            }
        }
    }
}
