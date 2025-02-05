﻿using AhmedKhlif.Data;
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
    public partial class Register : MetroFramework.Forms.MetroForm
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
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

        private void registerBtn_Click(object sender, EventArgs e)
        {
            int xx;
            
            if (nomTextBox.Text.Length == 0)
            {
                MessageBox.Show("donner un nom !");
                nomTextBox.Focus();
            }
            else if (mdpTextBox.Text.Length == 0)
            {
                MessageBox.Show("donner un mot de passe !");
                mdpTextBox.Focus();
            }
            else if (prenomTextBox.Text.Length == 0)
            {
                MessageBox.Show("donner un prenom !");
                prenomTextBox.Focus();
            }
            else if (telTextBox.Text.Length == 0)
            {
                MessageBox.Show("donner un numero de telephone !");
                telTextBox.Focus();
            }
            else
            {
                try
                {
                    if (ClientAdo.Login(nomTextBox.Text, mdpTextBox.Text) == false)
                    {
                        Client c = new Client();

                        c.Id = ClientAdo.GetLastId() + 1;
                        c.nom_cl = nomTextBox.Text;
                        c.prenom_cl = prenomTextBox.Text;
                        c.tel_cl = telTextBox.Text;
                        c.Mdp = mdpTextBox.Text;

                        ClientAdo.Register(c);

                        Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
