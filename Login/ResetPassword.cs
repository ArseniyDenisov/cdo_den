using System;
using System.Windows.Forms;
using Npgsql;

namespace cdo_den
{
    public partial class ResetPassword : Form
    {
        NpgsqlConnection con = new NpgsqlConnection(Auth.con_string);

        string lastLogin = "";

        char[] alf = new char[] { '!', '@', '#', '$', '^', '&', '*', '(', ')', '_', '+',
                '|', '"', '№', ';', '%', ':', '?', '-', '/', '.', '<', '>'};

        public ResetPassword(string ll)
        {
            lastLogin = ll;
            InitializeComponent();

            if (lastLogin != "")
            {
                textBox_Login.Text = lastLogin;
                ActiveControl = textBox_Pass1;
            }
            else
                ActiveControl = textBox_Login;
        }

        private void textBox_Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox_Pass1.Focus();
        }

        private void textBox_Pass1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox_Pass2.Focus();
        }

        private void textBox_Pass2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tryResetPassword();
        }

        private void button_TryReset_Click(object sender, EventArgs e)
        {
            tryResetPassword();
        }



        private void tryResetPassword()
        {
            string pass1 = textBox_Pass1.Text;
            string pass2 = textBox_Pass2.Text;

            if (pass1 != "" && pass2 != "")
            {
                if (pass1 == pass2)
                {
                    int id = isLoginValid(textBox_Login.Text);
                    if (id != -1)
                    {
                        if (isPasswordValid(pass1))
                        {
                            con.Open();
                            using (var cmd = new NpgsqlCommand($"update \"user_data\" set \"Password\" = '{pass1}' where \"ID\" = {id}", con))
                            {
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Пароль сброшен, возврат ко входу.", "Удачный сброс");
                                Close();
                            }
                            con.Close();
                        }
                    }
                    else
                        MessageBox.Show("Указан неверный логин.", "Ошибка сброса");
                }
                else
                    MessageBox.Show("Пароли не совпадают.", "Ошибка сброса");
            }
            else
                MessageBox.Show("Одно из полей пустое.", "Ошибка сброса");
        }

        private int isLoginValid(string login)
        {
            int res = -1;

            con.Open();
            using (var cmd = new NpgsqlCommand($"select \"ID\" from \"user_data\" where \"Login\" = '{login}'", con))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                        res = reader.GetInt32(0);
                }
            }
            con.Close();

            return res;
        }

        private bool isPasswordValid(string pass)
        {
            bool res = false;

            bool isHaveSymbol = false;
            int letterCount = 0;
            int numberCount = 0;

            if (pass.Length >= 9)
            {
                foreach (char s in pass)
                {
                    if (isLetterAreSymbol(s))
                        isHaveSymbol = true;
                    if (Char.IsLetter(s))
                        letterCount++;
                    if (Char.IsNumber(s))
                        numberCount++;
                }

                if (letterCount >= 5 && numberCount >= 3 && isHaveSymbol)
                    res = true;
                else
                {
                    string ex = (letterCount < 5 ? "" : "\r\n   Не менее 5 букв.");
                    ex += (numberCount < 3 ? "" : "\r\n   Не менее 3 цифр.");
                    ex += (isHaveSymbol ? "" : "\r\n   Нет специальных символов.");
                    MessageBox.Show("Пароль не соответствует требованиям:" + ex, "Ошибка регистрации");
                }
            }
            else
                MessageBox.Show("Пароль не соответствует требованиям:\r\n   Не менее 9 символов.", "Ошибка сброса");

            return res;
        }

        private bool isLetterAreSymbol(char s)
        {
            bool res = false;

            foreach (char c in alf)
            {
                if (s == c)
                {
                    res = true;
                    break;
                }
            }

            return res;
        }

        private void title_Main_Click(object sender, EventArgs e)
        {

        }
    }
}
