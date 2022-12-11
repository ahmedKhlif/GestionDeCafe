namespace AhmedKhlif
{
    partial class Account
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tel = new MetroFramework.Controls.MetroLabel();
            this.nom = new MetroFramework.Controls.MetroLabel();
            this.mdp = new MetroFramework.Controls.MetroLabel();
            this.prenom = new MetroFramework.Controls.MetroLabel();
            this.role = new MetroFramework.Controls.MetroLabel();
            this.mdpTextBox = new MetroFramework.Controls.MetroTextBox();
            this.roleTextBox = new MetroFramework.Controls.MetroTextBox();
            this.nomTextBox = new MetroFramework.Controls.MetroTextBox();
            this.prenomTextBox = new MetroFramework.Controls.MetroTextBox();
            this.telTextBox = new MetroFramework.Controls.MetroTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 274);
            this.panel1.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(309, 204);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(327, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "welcome back Check your Information";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AhmedKhlif.Properties.Resources.skouu;
            this.pictureBox1.Location = new System.Drawing.Point(289, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // tel
            // 
            this.tel.AutoSize = true;
            this.tel.Location = new System.Drawing.Point(151, 488);
            this.tel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(72, 20);
            this.tel.TabIndex = 33;
            this.tel.Text = "telephone";
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Location = new System.Drawing.Point(151, 323);
            this.nom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(40, 20);
            this.nom.TabIndex = 34;
            this.nom.Text = "Nom";
            this.nom.Click += new System.EventHandler(this.nomTextBox_Click);
            // 
            // mdp
            // 
            this.mdp.AutoSize = true;
            this.mdp.Location = new System.Drawing.Point(490, 323);
            this.mdp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mdp.Name = "mdp";
            this.mdp.Size = new System.Drawing.Size(80, 20);
            this.mdp.TabIndex = 35;
            this.mdp.Text = "modepasse";
            // 
            // prenom
            // 
            this.prenom.AutoSize = true;
            this.prenom.Location = new System.Drawing.Point(151, 412);
            this.prenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(58, 20);
            this.prenom.TabIndex = 36;
            this.prenom.Text = "Prenom";
            // 
            // role
            // 
            this.role.AutoSize = true;
            this.role.Location = new System.Drawing.Point(490, 415);
            this.role.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(36, 20);
            this.role.TabIndex = 37;
            this.role.Text = "Role";
            // 
            // mdpTextBox
            // 
            // 
            // 
            // 
            this.mdpTextBox.CustomButton.Image = null;
            this.mdpTextBox.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.mdpTextBox.CustomButton.Name = "";
            this.mdpTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mdpTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mdpTextBox.CustomButton.TabIndex = 1;
            this.mdpTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mdpTextBox.CustomButton.UseSelectable = true;
            this.mdpTextBox.CustomButton.Visible = false;
            this.mdpTextBox.Lines = new string[] {
        "metroTextBox1"};
            this.mdpTextBox.Location = new System.Drawing.Point(622, 323);
            this.mdpTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mdpTextBox.MaxLength = 32767;
            this.mdpTextBox.Name = "mdpTextBox";
            this.mdpTextBox.PasswordChar = '\0';
            this.mdpTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mdpTextBox.SelectedText = "";
            this.mdpTextBox.SelectionLength = 0;
            this.mdpTextBox.SelectionStart = 0;
            this.mdpTextBox.ShortcutsEnabled = true;
            this.mdpTextBox.Size = new System.Drawing.Size(174, 24);
            this.mdpTextBox.TabIndex = 38;
            this.mdpTextBox.Text = "metroTextBox1";
            this.mdpTextBox.UseSelectable = true;
            this.mdpTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mdpTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // roleTextBox
            // 
            // 
            // 
            // 
            this.roleTextBox.CustomButton.Image = null;
            this.roleTextBox.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.roleTextBox.CustomButton.Name = "";
            this.roleTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.roleTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.roleTextBox.CustomButton.TabIndex = 1;
            this.roleTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.roleTextBox.CustomButton.UseSelectable = true;
            this.roleTextBox.CustomButton.Visible = false;
            this.roleTextBox.Lines = new string[] {
        "metroTextBox2"};
            this.roleTextBox.Location = new System.Drawing.Point(622, 415);
            this.roleTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.roleTextBox.MaxLength = 32767;
            this.roleTextBox.Name = "roleTextBox";
            this.roleTextBox.PasswordChar = '\0';
            this.roleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.roleTextBox.SelectedText = "";
            this.roleTextBox.SelectionLength = 0;
            this.roleTextBox.SelectionStart = 0;
            this.roleTextBox.ShortcutsEnabled = true;
            this.roleTextBox.Size = new System.Drawing.Size(174, 24);
            this.roleTextBox.TabIndex = 39;
            this.roleTextBox.Text = "metroTextBox2";
            this.roleTextBox.UseSelectable = true;
            this.roleTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.roleTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // nomTextBox
            // 
            // 
            // 
            // 
            this.nomTextBox.CustomButton.Image = null;
            this.nomTextBox.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.nomTextBox.CustomButton.Name = "";
            this.nomTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nomTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nomTextBox.CustomButton.TabIndex = 1;
            this.nomTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nomTextBox.CustomButton.UseSelectable = true;
            this.nomTextBox.CustomButton.Visible = false;
            this.nomTextBox.Lines = new string[] {
        "metroTextBox3"};
            this.nomTextBox.Location = new System.Drawing.Point(289, 323);
            this.nomTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nomTextBox.MaxLength = 32767;
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.PasswordChar = '\0';
            this.nomTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nomTextBox.SelectedText = "";
            this.nomTextBox.SelectionLength = 0;
            this.nomTextBox.SelectionStart = 0;
            this.nomTextBox.ShortcutsEnabled = true;
            this.nomTextBox.Size = new System.Drawing.Size(174, 24);
            this.nomTextBox.TabIndex = 40;
            this.nomTextBox.Text = "metroTextBox3";
            this.nomTextBox.UseSelectable = true;
            this.nomTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nomTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // prenomTextBox
            // 
            // 
            // 
            // 
            this.prenomTextBox.CustomButton.Image = null;
            this.prenomTextBox.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.prenomTextBox.CustomButton.Name = "";
            this.prenomTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.prenomTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.prenomTextBox.CustomButton.TabIndex = 1;
            this.prenomTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.prenomTextBox.CustomButton.UseSelectable = true;
            this.prenomTextBox.CustomButton.Visible = false;
            this.prenomTextBox.Lines = new string[] {
        "metroTextBox4"};
            this.prenomTextBox.Location = new System.Drawing.Point(289, 409);
            this.prenomTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.prenomTextBox.MaxLength = 32767;
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.PasswordChar = '\0';
            this.prenomTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.prenomTextBox.SelectedText = "";
            this.prenomTextBox.SelectionLength = 0;
            this.prenomTextBox.SelectionStart = 0;
            this.prenomTextBox.ShortcutsEnabled = true;
            this.prenomTextBox.Size = new System.Drawing.Size(174, 24);
            this.prenomTextBox.TabIndex = 41;
            this.prenomTextBox.Text = "metroTextBox4";
            this.prenomTextBox.UseSelectable = true;
            this.prenomTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.prenomTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.prenomTextBox.Click += new System.EventHandler(this.metroTextBox4_Click);
            // 
            // telTextBox
            // 
            // 
            // 
            // 
            this.telTextBox.CustomButton.Image = null;
            this.telTextBox.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.telTextBox.CustomButton.Name = "";
            this.telTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.telTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.telTextBox.CustomButton.TabIndex = 1;
            this.telTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.telTextBox.CustomButton.UseSelectable = true;
            this.telTextBox.CustomButton.Visible = false;
            this.telTextBox.Lines = new string[] {
        "metroTextBox5"};
            this.telTextBox.Location = new System.Drawing.Point(289, 488);
            this.telTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.telTextBox.MaxLength = 32767;
            this.telTextBox.Name = "telTextBox";
            this.telTextBox.PasswordChar = '\0';
            this.telTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.telTextBox.SelectedText = "";
            this.telTextBox.SelectionLength = 0;
            this.telTextBox.SelectionStart = 0;
            this.telTextBox.ShortcutsEnabled = true;
            this.telTextBox.Size = new System.Drawing.Size(174, 24);
            this.telTextBox.TabIndex = 42;
            this.telTextBox.Text = "metroTextBox5";
            this.telTextBox.UseSelectable = true;
            this.telTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.telTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 663);
            this.Controls.Add(this.telTextBox);
            this.Controls.Add(this.prenomTextBox);
            this.Controls.Add(this.nomTextBox);
            this.Controls.Add(this.roleTextBox);
            this.Controls.Add(this.mdpTextBox);
            this.Controls.Add(this.role);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.mdp);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Account";
            this.Padding = new System.Windows.Forms.Padding(25, 64, 25, 21);
            this.Text = "Account";
            this.Load += new System.EventHandler(this.Account_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroLabel tel;
        private MetroFramework.Controls.MetroLabel nom;
        private MetroFramework.Controls.MetroLabel mdp;
        private MetroFramework.Controls.MetroLabel prenom;
        private MetroFramework.Controls.MetroLabel role;
        private MetroFramework.Controls.MetroTextBox mdpTextBox;
        private MetroFramework.Controls.MetroTextBox roleTextBox;
        private MetroFramework.Controls.MetroTextBox nomTextBox;
        private MetroFramework.Controls.MetroTextBox prenomTextBox;
        private MetroFramework.Controls.MetroTextBox telTextBox;
    }
}