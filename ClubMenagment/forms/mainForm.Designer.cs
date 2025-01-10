namespace ClubMenagment
{
    partial class Dashboard
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
            this.top_panel = new System.Windows.Forms.Panel();
            this.UserNameText = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.injuredPlayerNum = new System.Windows.Forms.Label();
            this.InjuredCount = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.clubvaluNumb = new System.Windows.Forms.Label();
            this.valueCount = new System.Windows.Forms.Label();
            this.playerCount = new System.Windows.Forms.Label();
            this.playerNum = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Logout_btn = new System.Windows.Forms.Button();
            this.CoachBtn = new System.Windows.Forms.Button();
            this.PlayersBtn = new System.Windows.Forms.Button();
            this.logo_panel = new System.Windows.Forms.Panel();
            this.OverviewBtn = new System.Windows.Forms.Button();
            this.menuPanel.SuspendLayout();
            this.top_panel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.menuPanel.Controls.Add(this.CoachBtn);
            this.menuPanel.Controls.Add(this.PlayersBtn);
            this.menuPanel.Controls.Add(this.logo_panel);
            this.menuPanel.Controls.Add(this.OverviewBtn);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.ForeColor = System.Drawing.Color.Black;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(112, 457);
            this.menuPanel.TabIndex = 0;
            this.menuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.menuPanel_Paint);
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.top_panel.Controls.Add(this.UserNameText);
            this.top_panel.Controls.Add(this.Logout_btn);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(112, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(688, 40);
            this.top_panel.TabIndex = 1;
            // 
            // UserNameText
            // 
            this.UserNameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.UserNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserNameText.Font = new System.Drawing.Font("Switzer Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UserNameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.UserNameText.Location = new System.Drawing.Point(344, 8);
            this.UserNameText.Name = "UserNameText";
            this.UserNameText.Size = new System.Drawing.Size(240, 22);
            this.UserNameText.TabIndex = 5;
            this.UserNameText.Text = "Witaj, [Imię użytkownika]!";
            this.UserNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UserNameText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel2.Controls.Add(this.injuredPlayerNum);
            this.panel2.Controls.Add(this.InjuredCount);
            this.panel2.Location = new System.Drawing.Point(360, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 8;
            // 
            // injuredPlayerNum
            // 
            this.injuredPlayerNum.AutoSize = true;
            this.injuredPlayerNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.injuredPlayerNum.Location = new System.Drawing.Point(72, 32);
            this.injuredPlayerNum.Name = "injuredPlayerNum";
            this.injuredPlayerNum.Size = new System.Drawing.Size(57, 63);
            this.injuredPlayerNum.TabIndex = 2;
            this.injuredPlayerNum.Text = "0";
            // 
            // InjuredCount
            // 
            this.InjuredCount.AutoSize = true;
            this.InjuredCount.Location = new System.Drawing.Point(8, 8);
            this.InjuredCount.Name = "InjuredCount";
            this.InjuredCount.Size = new System.Drawing.Size(106, 13);
            this.InjuredCount.TabIndex = 0;
            this.InjuredCount.Text = "Injured Player in Club";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel3.Controls.Add(this.clubvaluNumb);
            this.panel3.Controls.Add(this.valueCount);
            this.panel3.Location = new System.Drawing.Point(584, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 9;
            // 
            // clubvaluNumb
            // 
            this.clubvaluNumb.AutoSize = true;
            this.clubvaluNumb.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clubvaluNumb.Location = new System.Drawing.Point(16, 32);
            this.clubvaluNumb.Name = "clubvaluNumb";
            this.clubvaluNumb.Size = new System.Drawing.Size(57, 63);
            this.clubvaluNumb.TabIndex = 3;
            this.clubvaluNumb.Text = "0";
            // 
            // valueCount
            // 
            this.valueCount.AutoSize = true;
            this.valueCount.Location = new System.Drawing.Point(8, 8);
            this.valueCount.Name = "valueCount";
            this.valueCount.Size = new System.Drawing.Size(57, 13);
            this.valueCount.TabIndex = 0;
            this.valueCount.Text = "club Value";
            // 
            // playerCount
            // 
            this.playerCount.AutoSize = true;
            this.playerCount.Location = new System.Drawing.Point(8, 8);
            this.playerCount.Name = "playerCount";
            this.playerCount.Size = new System.Drawing.Size(71, 13);
            this.playerCount.TabIndex = 0;
            this.playerCount.Text = "Player in Club";
            // 
            // playerNum
            // 
            this.playerNum.AutoSize = true;
            this.playerNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerNum.Location = new System.Drawing.Point(72, 32);
            this.playerNum.Name = "playerNum";
            this.playerNum.Size = new System.Drawing.Size(57, 63);
            this.playerNum.TabIndex = 1;
            this.playerNum.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.playerNum);
            this.panel1.Controls.Add(this.playerCount);
            this.panel1.Location = new System.Drawing.Point(136, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 7;
            // 
            // Logout_btn
            // 
            this.Logout_btn.AutoSize = true;
            this.Logout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.Logout_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logout_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Logout_btn.FlatAppearance.BorderSize = 0;
            this.Logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout_btn.Font = new System.Drawing.Font("Switzer", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.Logout_btn.Image = global::ClubMenagment.Properties.Resources.exit_sm;
            this.Logout_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Logout_btn.Location = new System.Drawing.Point(592, 0);
            this.Logout_btn.Margin = new System.Windows.Forms.Padding(0);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(96, 40);
            this.Logout_btn.TabIndex = 4;
            this.Logout_btn.Text = "Log Out";
            this.Logout_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logout_btn.UseVisualStyleBackColor = false;
            this.Logout_btn.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // CoachBtn
            // 
            this.CoachBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.CoachBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CoachBtn.FlatAppearance.BorderSize = 0;
            this.CoachBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CoachBtn.Font = new System.Drawing.Font("Switzer Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoachBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.CoachBtn.Image = global::ClubMenagment.Properties.Resources.whistle;
            this.CoachBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CoachBtn.Location = new System.Drawing.Point(0, 264);
            this.CoachBtn.Margin = new System.Windows.Forms.Padding(0);
            this.CoachBtn.Name = "CoachBtn";
            this.CoachBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 2);
            this.CoachBtn.Size = new System.Drawing.Size(112, 40);
            this.CoachBtn.TabIndex = 6;
            this.CoachBtn.Text = "         Coaches";
            this.CoachBtn.UseVisualStyleBackColor = false;
            // 
            // PlayersBtn
            // 
            this.PlayersBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.PlayersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayersBtn.FlatAppearance.BorderSize = 0;
            this.PlayersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayersBtn.Font = new System.Drawing.Font("Switzer Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayersBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.PlayersBtn.Image = global::ClubMenagment.Properties.Resources.soccer_player;
            this.PlayersBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PlayersBtn.Location = new System.Drawing.Point(0, 208);
            this.PlayersBtn.Margin = new System.Windows.Forms.Padding(0);
            this.PlayersBtn.Name = "PlayersBtn";
            this.PlayersBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 2);
            this.PlayersBtn.Size = new System.Drawing.Size(112, 40);
            this.PlayersBtn.TabIndex = 5;
            this.PlayersBtn.Text = "          Players";
            this.PlayersBtn.UseVisualStyleBackColor = false;
            this.PlayersBtn.Click += new System.EventHandler(this.PlayersBtn_Click);
            // 
            // logo_panel
            // 
            this.logo_panel.BackgroundImage = global::ClubMenagment.Properties.Resources.football_club;
            this.logo_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo_panel.Location = new System.Drawing.Point(16, 16);
            this.logo_panel.Name = "logo_panel";
            this.logo_panel.Size = new System.Drawing.Size(80, 72);
            this.logo_panel.TabIndex = 4;
            // 
            // OverviewBtn
            // 
            this.OverviewBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.OverviewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OverviewBtn.FlatAppearance.BorderSize = 0;
            this.OverviewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OverviewBtn.Font = new System.Drawing.Font("Switzer Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverviewBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.OverviewBtn.Image = global::ClubMenagment.Properties.Resources.menu;
            this.OverviewBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OverviewBtn.Location = new System.Drawing.Point(0, 152);
            this.OverviewBtn.Margin = new System.Windows.Forms.Padding(0);
            this.OverviewBtn.Name = "OverviewBtn";
            this.OverviewBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 2);
            this.OverviewBtn.Size = new System.Drawing.Size(112, 40);
            this.OverviewBtn.TabIndex = 0;
            this.OverviewBtn.Text = "             Dashboard";
            this.OverviewBtn.UseVisualStyleBackColor = false;
            this.OverviewBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.top_panel);
            this.Controls.Add(this.menuPanel);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Football Club Menegment System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuPanel.ResumeLayout(false);
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Button OverviewBtn;
        private System.Windows.Forms.Button Logout_btn;
        private System.Windows.Forms.Panel logo_panel;
        private System.Windows.Forms.Button PlayersBtn;
        private System.Windows.Forms.Button CoachBtn;
        public System.Windows.Forms.TextBox UserNameText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label injuredPlayerNum;
        private System.Windows.Forms.Label InjuredCount;
        private System.Windows.Forms.Label playerCount;
        private System.Windows.Forms.Label playerNum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label clubvaluNumb;
        private System.Windows.Forms.Label valueCount;
    }
}

