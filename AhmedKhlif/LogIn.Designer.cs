namespace AhmedKhlif
{
    partial class LogIn
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
            this.nomLabel = new System.Windows.Forms.Label();
            this.MdpLabel = new System.Windows.Forms.Label();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.mdpTextBox = new System.Windows.Forms.TextBox();
            this.logInBtn = new System.Windows.Forms.Button();
            this.registerBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.show = new System.Windows.Forms.PictureBox();
            this.hide = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.show)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nomLabel.Location = new System.Drawing.Point(70, 240);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(70, 16);
            this.nomLabel.TabIndex = 0;
            this.nomLabel.Text = "Username";
            this.nomLabel.Click += new System.EventHandler(this.nomLabel_Click);
            // 
            // MdpLabel
            // 
            this.MdpLabel.AutoSize = true;
            this.MdpLabel.Location = new System.Drawing.Point(68, 317);
            this.MdpLabel.Name = "MdpLabel";
            this.MdpLabel.Size = new System.Drawing.Size(70, 16);
            this.MdpLabel.TabIndex = 1;
            this.MdpLabel.Text = "Password ";
            // 
            // nomTextBox
            // 
            this.nomTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomTextBox.Location = new System.Drawing.Point(73, 269);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(184, 22);
            this.nomTextBox.TabIndex = 2;
            this.nomTextBox.Text = "wissem";
            this.nomTextBox.TextChanged += new System.EventHandler(this.nomTextBox_TextChanged);
            // 
            // mdpTextBox
            // 
            this.mdpTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mdpTextBox.Location = new System.Drawing.Point(73, 345);
            this.mdpTextBox.Name = "mdpTextBox";
            this.mdpTextBox.Size = new System.Drawing.Size(184, 22);
            this.mdpTextBox.TabIndex = 3;
            this.mdpTextBox.Text = "wissem123";
            this.mdpTextBox.UseSystemPasswordChar = true;
            // 
            // logInBtn
            // 
            this.logInBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInBtn.Location = new System.Drawing.Point(73, 397);
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.Size = new System.Drawing.Size(75, 38);
            this.logInBtn.TabIndex = 4;
            this.logInBtn.Text = "Login";
            this.logInBtn.UseVisualStyleBackColor = false;
            this.logInBtn.Click += new System.EventHandler(this.logInBtn_Click);
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.registerBtn.Location = new System.Drawing.Point(210, 397);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(75, 38);
            this.registerBtn.TabIndex = 5;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(23, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Please enter your information.";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 222);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // show
            // 
            this.show.Image = global::AhmedKhlif.Properties.Resources.shows1;
            this.show.Location = new System.Drawing.Point(263, 345);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(26, 22);
            this.show.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.show.TabIndex = 11;
            this.show.TabStop = false;
            this.show.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // hide
            // 
            this.hide.Image = global::AhmedKhlif.Properties.Resources.hide;
            this.hide.Location = new System.Drawing.Point(295, 346);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(28, 21);
            this.hide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hide.TabIndex = 10;
            this.hide.TabStop = false;
            this.hide.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AhmedKhlif.Properties.Resources.client;
            this.pictureBox1.Location = new System.Drawing.Point(55, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 458);
            this.Controls.Add(this.show);
            this.Controls.Add(this.hide);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.logInBtn);
            this.Controls.Add(this.mdpTextBox);
            this.Controls.Add(this.nomTextBox);
            this.Controls.Add(this.MdpLabel);
            this.Controls.Add(this.nomLabel);
            this.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.Name = "LogIn";
            this.Text = "Login In";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.show)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomLabel;
        private System.Windows.Forms.Label MdpLabel;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.TextBox mdpTextBox;
        private System.Windows.Forms.Button logInBtn;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox hide;
        private System.Windows.Forms.PictureBox show;
    }
}