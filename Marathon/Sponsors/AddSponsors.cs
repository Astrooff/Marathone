using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using MySql.Data.MySqlClient;
using Marathon.Database;

namespace Marathon.Sponsors
{
    public partial class AddSponsors : MetroFramework.Forms.MetroForm
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime(2021, 3, 20);
        public int a = 0;
        public string name;
        public string Id,Id2;
        public string Sum;
        public static int value,charity;
        bool checkCancelButton = false;
        string messageError;
        public static string sponsorName;
        public static int num;
        public static string[] fullName;
        public AddSponsors()
        {
            InitializeComponent();
            this.Resizable = false;
            this.MaximizeBox = false;
            this.ControlBox = false;
            metroTextBoxCharitySum.Text = "0";
            timer1.Start();
            showRunner();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            metroLabel1.Text = "До начала марафона осталось: " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds + " с. ";
        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            Sponsors.CharityInfo ci = new Sponsors.CharityInfo();
            ci.Show();
        }

        private void metroButtonPlus_Click(object sender, EventArgs e)
        {
            if (metroTextBoxCharitySum.Text != "")
            {
                a = Convert.ToInt32(metroTextBoxCharitySum.Text);
                a = a + 10;
                metroTextBoxCharitySum.Text = Convert.ToString(a);
            }
            else
            {
                metroTextBoxCharitySum.Text = "0";
                a = Convert.ToInt32(metroTextBoxCharitySum.Text);
                a = a + 10;
                metroTextBoxCharitySum.Text = Convert.ToString(a);
            }
        }

        private void metroTextBoxCharitySum_TextChanged(object sender, EventArgs e)
        {
            if (metroTextBoxCharitySum.Text != "")
            {
                a = Convert.ToInt32(metroTextBoxCharitySum.Text);
                labelBigNums.Text ="$" + metroTextBoxCharitySum.Text;
            }
            
        }

        private void metroTextBoxCharitySum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }
        private void checkField(string name, string authorCard, string numberCard, int cardMonth, int cardYear, string cvc, int money)
        {
            this.messageError = "";
            if (String.IsNullOrEmpty(name))
            {
                this.messageError = "Заполните обязательное поле Имя!";
            }
            else if (numberCard.Length != 16)
            {
                this.messageError = "Код карты должен состоять из 16 цифр";
            }
            else if (cvc.Length != 3)
            {
                this.messageError = "CVC код должен содержать 3 цифры";
            }
            else if (money <= 0)
            {
                this.messageError = "Невозможно пожертвовать 0$";
            }
        }
        private void metroButton3_Click(object sender, EventArgs e)
        {
            string name = metroTextBoxNameCard.Text;
            string cardNumber = metroTextBoxCardNum.Text;
            string cardCVC = metroTextBoxCVC.Text;
            int money = Convert.ToInt32(metroTextBoxCharitySum.Text);
            string authorCard = metroTextBoxNameCard.Text;
            int cardMonth = Convert.ToInt32(metroTextBoxDD.Text);
            int cardYear = Convert.ToInt32(metroTextBoxYYYY.Text);
            checkField(name, authorCard, cardNumber, cardMonth, cardYear, cardCVC, money);
            if (!String.IsNullOrEmpty(this.messageError))
            {
                MessageBox.Show(this.messageError, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                fullName = metroComboBoxRunner.SelectedItem.ToString().Split(new char[] { ' ', '.' });
                num = money;
                int idRunner = Convert.ToInt32(metroComboBoxRunner.SelectedItem.ToString().Split('.')[0]);
                string sql = String.Format("INSERT INTO Sponsorship (SponsorName, RegistrationId, Amount) VALUES ('{0}', '{1}', '{2}')", name, idRunner, money);
                Program.connectuon.Open();
                MySqlCommand command = new MySqlCommand(sql, Program.connectuon);
                command.ExecuteNonQuery();
                Program.connectuon.Close();
                ConfirmDonate formConfirmDonate = new ConfirmDonate();
                checkCancelButton = true;
                formConfirmDonate.Show();
                this.Close();
            }
        }

        private void metroButtonMinus_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(metroTextBoxCharitySum.Text);
            if (metroTextBoxCharitySum.Text != "" && a > 9)
            {
                a = a - 10;
                metroTextBoxCharitySum.Text = Convert.ToString(a);
            }
            else
            {
                metroTextBoxCharitySum.Text = "10";
                a = Convert.ToInt32(metroTextBoxCharitySum.Text);
                a = a - 10;
                metroTextBoxCharitySum.Text = Convert.ToString(a);
            }
        }
        public void showRunner()
        {
            try
            {
                metroComboBoxRunner.Items.Clear();
                Program.connectuon.Open();
                MySqlCommand command = new MySqlCommand("SELECT Registration.RegistrationId, User.LastName, User.FirstName FROM Registration, User WHERE Registration.RunnerId = (SELECT Runner.RunnerId FROM Runner WHERE Runner.Email = User.Email)", Program.connectuon);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    metroComboBoxRunner.Items.Add($"{reader.GetString("RegistrationId")}. {reader.GetString("FirstName")}  {reader.GetString("LastName")}");
                }
                reader.Close();
                metroComboBoxRunner.SelectedIndex = 1;
            }
            catch { }
            finally { Program.connectuon.Close(); }
        }
        private void metroComboBoxRunner_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroLabelCharityName.Text = metroComboBoxRunner.SelectedItem.ToString();
            string a = metroComboBoxRunner.SelectedItem.ToString();
            int.TryParse(string.Join("", a.Where(c => char.IsDigit(c))), out value);
            MySqlConnection connection2 = new MySqlConnection(MySQL.connectionUrl);//необходимая команда MySql
            MySqlConnection connection3 = new MySqlConnection(MySQL.connectionUrl);//необходимая команда MySql
            connection2.Open();//необходимая команда MySql
            connection3.Open();//необходимая команда MySql
            MySqlCommand runner2 = new MySqlCommand("SELECT CharityId FROM registration WHERE RunnerId =\"" + value + "\"  ", connection2);
            MySqlDataReader runnerreader2 = runner2.ExecuteReader();
            while (runnerreader2.Read())
            {
                charity = Convert.ToInt32(runnerreader2.GetString("CharityId"));
            }
            MySqlCommand chart = new MySqlCommand("SELECT CharityName FROM charity WHERE CharityId =\"" + charity + "\"  ", connection3);
            MySqlDataReader chartreader = chart.ExecuteReader();
            while (chartreader.Read())
            {
                metroLabelCharityName.Text = chartreader.GetString("CharityName");
            }
            connection2.Close();//необходимая команда MySql
            connection3.Close();//необходимая команда MySql
        }
    }
}
