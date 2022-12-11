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
    public partial class Account : MetroFramework.Forms.MetroForm
    {
        public Client MainAccount { get; set; }
        public Account()
        {
            InitializeComponent();
        }

        private void Account_Load(object sender, EventArgs e)
        {
            nom.Text = MainAccount.nom_cl.Trim();
            prenom.Text = MainAccount.prenom_cl.Trim();
            tel.Text = MainAccount.tel_cl.Trim();
            mdp.Text = MainAccount.Mdp.Trim();
            role.Text = MainAccount.role_cl.Trim();
            role.Enabled= false;
        }

        private void nomTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void nomTextBox_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
