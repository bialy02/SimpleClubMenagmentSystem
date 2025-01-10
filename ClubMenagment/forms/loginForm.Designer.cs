namespace ClubMenagment
{
    partial class loginForm
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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.logo_panel = new System.Windows.Forms.Panel();
            this.usernameTxtBox = new System.Windows.Forms.TextBox();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OverviewBtn = new System.Windows.Forms.Button();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.menuPanel.Controls.Add(this.logo_panel);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.ForeColor = System.Drawing.Color.Black;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(304, 409);
            this.menuPanel.TabIndex = 1;
            // 
            // logo_panel
            // 
            this.logo_panel.BackgroundImage = global::ClubMenagment.Properties.Resources.football_club;
            this.logo_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logo_panel.Location = new System.Drawing.Point(0, 0);
            this.logo_panel.Name = "logo_panel";
            this.logo_panel.Size = new System.Drawing.Size(304, 409);
            this.logo_panel.TabIndex = 4;
            this.logo_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.logo_panel_Paint);
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.Location = new System.Drawing.Point(424, 128);
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.Size = new System.Drawing.Size(200, 20);
            this.usernameTxtBox.TabIndex = 2;
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Location = new System.Drawing.Point(424, 184);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.Size = new System.Drawing.Size(200, 20);
            this.passwordTxtBox.TabIndex = 3;
            this.passwordTxtBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(432, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "password";
            // 
            // OverviewBtn
            // 
            this.OverviewBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.OverviewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OverviewBtn.FlatAppearance.BorderSize = 0;
            this.OverviewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OverviewBtn.Font = new System.Drawing.Font("Switzer Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverviewBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.OverviewBtn.Image = global::ClubMenagment.Properties.Resources.log_in;
            this.OverviewBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OverviewBtn.Location = new System.Drawing.Point(536, 256);
            this.OverviewBtn.Margin = new System.Windows.Forms.Padding(0);
            this.OverviewBtn.Name = "OverviewBtn";
            this.OverviewBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 2);
            this.OverviewBtn.Size = new System.Drawing.Size(112, 40);
            this.OverviewBtn.TabIndex = 1;
            this.OverviewBtn.Text = "             Log In";
            this.OverviewBtn.UseVisualStyleBackColor = false;
            this.OverviewBtn.Click += new System.EventHandler(this.OverviewBtn_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 409);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.usernameTxtBox);
            this.Controls.Add(this.OverviewBtn);
            this.Controls.Add(this.menuPanel);
            this.Name = "loginForm";
            this.Text = "loginForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.loginForm_FormClosing);
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel logo_panel;
        private System.Windows.Forms.Button OverviewBtn;
        private System.Windows.Forms.TextBox usernameTxtBox;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}