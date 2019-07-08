using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckAndPasswordGenerator
{
    public partial class PasswordForm : Form
    {
        public PasswordForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void HowMuchSignTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GeneratorButton_Click(object sender, EventArgs e)
        {
            int n = 0;

            if (!int.TryParse(HowMuchSignTextBox.Text, out n))
            {

                MessageBox.Show("Podaj liczbę!");
                HowMuchSignTextBox.Text = "";

            }

            string password = "";
            Random rand = new Random();

            string digit = "0123456789";
            string letter = "ABCDEFGHIJKLMNOPRSTUVWXYZ";
            string letterLower = letter.ToLower();
            string punct = "`~`!@#$%^&*()_+-=|,./?<>{}[]'\"\\;:";

            ArrayList array = new ArrayList();

            if (checkBox123.Checked)
            array.Add(digit);
            else array.Remove(digit);

            if (checkBoxabc.Checked)
                array.Add(letterLower);
            else array.Remove(letterLower);

            if (checkBoxBCD.Checked)
                array.Add(letter);
            else array.Remove(letter);

            if (checkBoxSign.Checked)
                array.Add(punct);
            else array.Remove(punct);

            if (n > 0 && (checkBox123.Checked || checkBoxabc.Checked || checkBoxBCD.Checked || checkBoxSign.Checked))
            {

                for (int i = 0; i < n; i++)
                {
                    int r1 = rand.Next(array.Count);

                    string random = (string)array[r1];

                    int r2 = rand.Next(random.Length);

                    password += random[r2];

                    EnterPasswordTextBox.Text = password;
                }
            }
            else
            {
                MessageBox.Show("Hasło nie może być puste!");
                
            }
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            string password = EnterPasswordTextBox.Text;


            bool upper = false, lower = false, number = false, punct = false, symbol = false, length = false;

            if (password.Length >= 7)
            {
                length = true;

                for (int i = 0; i < password.Length; i++)
                {
                    if (upper && lower && number && punct)
                        break;

                    if (!upper)
                    {
                        if (Char.IsUpper(password[i]))
                            upper = true;
                    }

                    if (!lower)
                    {
                        if (Char.IsLower(password[i]))
                            lower = true;
                    }
                    if (!number)
                    {
                        if (Char.IsDigit(password[i]))
                            number = true;
                    }

                    if (!punct || !symbol)
                    {
                        if (Char.IsPunctuation(password[i]) || Char.IsSymbol(password[i]))
                            punct = true;
                        symbol = true;
                    }
                }
            }

            YourPasswordLabel.Visible = true;
            if (length && upper && lower && number && punct && symbol)
            {
                pictureBoxOK.Visible = true;
                pictureBoxNotOK.Visible = false;
            }
            else
            {
                pictureBoxNotOK.Visible = true;
                pictureBoxOK.Visible = false;
            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TitleLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
