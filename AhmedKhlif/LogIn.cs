using AhmedKhlif.Data;
using AhmedKhlif.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AhmedKhlif
{
    public partial class LogIn : MetroFramework.Forms.MetroForm
    {

        public bool UserSuccessfullyAuthenticated { get; private set; }
        public Client Account { get; private set; }
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            try
            {
                DbContext.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            if (nomTextBox.Text.Length == 0)
            {
                MessageBox.Show("donner votre nom !");
                nomTextBox.Focus();
            }
            else if (mdpTextBox.Text.Length == 0)
            {
                MessageBox.Show("donner votre mot de passe !");
                mdpTextBox.Focus();
            }
            else
            {
                try
                {
                    if (ClientAdo.Login(nomTextBox.Text, mdpTextBox.Text))
                    {
                        UserSuccessfullyAuthenticated = true;
                        Account = ClientAdo.GetClient(nomTextBox.Text, mdpTextBox.Text);
                        Close();
                    }
                    else
                    {
                        // clear the textBoxes
                        nomTextBox.Clear();
                        mdpTextBox.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void nomLabel_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nomTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           if(mdpTextBox.Text.Length >0 )
            {
                mdpTextBox.UseSystemPasswordChar = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (mdpTextBox.Text.Length > 0)
            {
                mdpTextBox.UseSystemPasswordChar = true;
            }
        }
    }
}
