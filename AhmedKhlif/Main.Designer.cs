namespace AhmedKhlif
{
    partial class Main
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
            this.MotherContainer = new System.Windows.Forms.Panel();
            this.AccountBtn = new System.Windows.Forms.Button();
            this.BuyBtn = new System.Windows.Forms.Button();
            this.MenuBtn = new System.Windows.Forms.Button();
            this.MotherContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // MotherContainer
            // 
            this.MotherContainer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MotherContainer.Controls.Add(this.AccountBtn);
            this.MotherContainer.Controls.Add(this.BuyBtn);
            this.MotherContainer.Controls.Add(this.MenuBtn);
            this.MotherContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.MotherContainer.Location = new System.Drawing.Point(0, 0);
            this.MotherContainer.Name = "MotherContainer";
            this.MotherContainer.Size = new System.Drawing.Size(255, 570);
            this.MotherContainer.TabIndex = 3;
            this.MotherContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.MotherContainer_Paint);
            // 
            // AccountBtn
            // 
            this.AccountBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AccountBtn.FlatAppearance.BorderSize = 0;
            this.AccountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AccountBtn.Image = global::AhmedKhlif.Properties.Resources.client_2s;
            this.AccountBtn.Location = new System.Drawing.Point(0, 205);
            this.AccountBtn.Name = "AccountBtn";
            this.AccountBtn.Size = new System.Drawing.Size(255, 93);
            this.AccountBtn.TabIndex = 2;
            this.AccountBtn.UseVisualStyleBackColor = true;
            this.AccountBtn.Click += new System.EventHandler(this.AccountBtn_Click);
            // 
            // BuyBtn
            // 
            this.BuyBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.BuyBtn.Enabled = false;
            this.BuyBtn.FlatAppearance.BorderSize = 0;
            this.BuyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyBtn.Image = global::AhmedKhlif.Properties.Resources._1019607sds1;
            this.BuyBtn.Location = new System.Drawing.Point(0, 109);
            this.BuyBtn.Name = "BuyBtn";
            this.BuyBtn.Size = new System.Drawing.Size(255, 96);
            this.BuyBtn.TabIndex = 1;
            this.BuyBtn.UseVisualStyleBackColor = true;
            this.BuyBtn.Click += new System.EventHandler(this.BuyBtn_Click);
            // 
            // MenuBtn
            // 
            this.MenuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuBtn.FlatAppearance.BorderSize = 0;
            this.MenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuBtn.ForeColor = System.Drawing.Color.Chartreuse;
            this.MenuBtn.Image = global::AhmedKhlif.Properties.Resources._1046747efd;
            this.MenuBtn.Location = new System.Drawing.Point(0, 0);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(255, 109);
            this.MenuBtn.TabIndex = 0;
            this.MenuBtn.UseVisualStyleBackColor = true;
            this.MenuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 570);
            this.Controls.Add(this.MotherContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cafe Manager";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MotherContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MotherContainer;
        private System.Windows.Forms.Button MenuBtn;
        private System.Windows.Forms.Button AccountBtn;
        private System.Windows.Forms.Button BuyBtn;
    }
}