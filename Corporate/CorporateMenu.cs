using System;
using System.Windows.Forms;

namespace cdo_den
{
    public partial class CorporateMenu : Form
    {
        int accountId = 0;
        int ruleId = 0;
        string surname = "";
        string name = "";
        string patronymic = "";

        public CorporateMenu(int aid, int rid, string surn, string n, string patr)
        {
            accountId = aid;
            ruleId = rid;
            surname = surn;
            name = n;
            patronymic = patr;

            InitializeComponent();

            title_FullName.Text = $"{surname} {name} {patronymic}";
            ActiveControl = button_EducationalProgram;
        }

        private void CorporateMenu_Load(object sender, EventArgs e)
        {
            setAccess();
        }

        private void button_AccountExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CorporateMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти из аккаунта?", "Выход", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void CorporateMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Show();
        }




        private void setAccess()
        {
            bool[] buttons_enable = new bool[] { false, false, false};
            switch (ruleId)
            {
                case 2:
                    buttons_enable = new bool[] { true, true, true};
                    break;
                case 3:
                    buttons_enable = new bool[] { true, true, false };
                    break;
                default:
                    break;
            }

            button_EducationalProgram.Enabled = buttons_enable[0];
            button_Individual.Enabled = buttons_enable[1];
            button_Contract.Enabled = buttons_enable[2];
        }

        private void button_EducationalProgram_Click(object sender, EventArgs e)
        {
            // образовательная программа
        }

        private void button_Individual_Click(object sender, EventArgs e)
        {
            // физическое лицо
        }

        private void button_Contract_Click(object sender, EventArgs e)
        {
            Contract c = new Contract();
            c.Show();
            Hide();
        }
    }
}
