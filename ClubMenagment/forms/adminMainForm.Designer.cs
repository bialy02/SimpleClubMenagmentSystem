namespace ClubMenagment
{
    partial class adminDashboard
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
            this.top_panel = new System.Windows.Forms.Panel();
            this.UserNameText = new System.Windows.Forms.TextBox();
            this.Logout_btn = new System.Windows.Forms.Button();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.usersBtn = new System.Windows.Forms.Button();
            this.CoachBtn = new System.Windows.Forms.Button();
            this.PlayersBtn = new System.Windows.Forms.Button();
            this.logo_panel = new System.Windows.Forms.Panel();
            this.OverviewBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.addUser = new System.Windows.Forms.Button();
            this.addCoach = new System.Windows.Forms.Button();
            this.addPlayer = new System.Windows.Forms.Button();
            this.top_panel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.top_panel.TabIndex = 3;
            this.top_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.top_panel_Paint);
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
            this.Logout_btn.Click += new System.EventHandler(this.Logout_btn_Click);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.menuPanel.Controls.Add(this.usersBtn);
            this.menuPanel.Controls.Add(this.CoachBtn);
            this.menuPanel.Controls.Add(this.PlayersBtn);
            this.menuPanel.Controls.Add(this.logo_panel);
            this.menuPanel.Controls.Add(this.OverviewBtn);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.ForeColor = System.Drawing.Color.Black;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(112, 441);
            this.menuPanel.TabIndex = 2;
            this.menuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.menuPanel_Paint);
            // 
            // usersBtn
            // 
            this.usersBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.usersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usersBtn.FlatAppearance.BorderSize = 0;
            this.usersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersBtn.Font = new System.Drawing.Font("Switzer Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.usersBtn.Image = global::ClubMenagment.Properties.Resources.users;
            this.usersBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usersBtn.Location = new System.Drawing.Point(0, 320);
            this.usersBtn.Margin = new System.Windows.Forms.Padding(0);
            this.usersBtn.Name = "usersBtn";
            this.usersBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 2);
            this.usersBtn.Size = new System.Drawing.Size(112, 40);
            this.usersBtn.TabIndex = 7;
            this.usersBtn.Text = "         Users";
            this.usersBtn.UseVisualStyleBackColor = false;
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
            this.logo_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.logo_panel_Paint);
            // 
            // OverviewBtn
            // 
            this.OverviewBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.OverviewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OverviewBtn.FlatAppearance.BorderSize = 0;
            this.OverviewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OverviewBtn.Font = new System.Drawing.Font("Switzer Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverviewBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.OverviewBtn.Image = global::ClubMenagment.Properties.Resources.adminpanel;
            this.OverviewBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OverviewBtn.Location = new System.Drawing.Point(0, 152);
            this.OverviewBtn.Margin = new System.Windows.Forms.Padding(0);
            this.OverviewBtn.Name = "OverviewBtn";
            this.OverviewBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 2);
            this.OverviewBtn.Size = new System.Drawing.Size(112, 40);
            this.OverviewBtn.TabIndex = 0;
            this.OverviewBtn.Text = "             Admin                  Panel";
            this.OverviewBtn.UseVisualStyleBackColor = false;
            this.OverviewBtn.Click += new System.EventHandler(this.OverviewBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Switzer Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.button1.Image = global::ClubMenagment.Properties.Resources.remove_user;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(336, 232);
            this.button1.Margin = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 2);
            this.button1.Size = new System.Drawing.Size(112, 216);
            this.button1.TabIndex = 12;
            this.button1.Text = "             Remove User";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Switzer Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.button2.Image = global::ClubMenagment.Properties.Resources.whistle;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(224, 232);
            this.button2.Margin = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 2);
            this.button2.Size = new System.Drawing.Size(112, 216);
            this.button2.TabIndex = 11;
            this.button2.Text = "             Remove Coach";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Switzer Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.button3.Image = global::ClubMenagment.Properties.Resources.soccer_player_add;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(112, 232);
            this.button3.Margin = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 2);
            this.button3.Size = new System.Drawing.Size(112, 216);
            this.button3.TabIndex = 10;
            this.button3.Text = "             Remove Player";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // addUser
            // 
            this.addUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.addUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addUser.FlatAppearance.BorderSize = 0;
            this.addUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUser.Font = new System.Drawing.Font("Switzer Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.addUser.Image = global::ClubMenagment.Properties.Resources.add_user1;
            this.addUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addUser.Location = new System.Drawing.Point(336, 40);
            this.addUser.Margin = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.addUser.Name = "addUser";
            this.addUser.Padding = new System.Windows.Forms.Padding(5, 0, 0, 2);
            this.addUser.Size = new System.Drawing.Size(112, 205);
            this.addUser.TabIndex = 9;
            this.addUser.Text = "             Add User";
            this.addUser.UseVisualStyleBackColor = false;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // addCoach
            // 
            this.addCoach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.addCoach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCoach.FlatAppearance.BorderSize = 0;
            this.addCoach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCoach.Font = new System.Drawing.Font("Switzer Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCoach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.addCoach.Image = global::ClubMenagment.Properties.Resources.whistle;
            this.addCoach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addCoach.Location = new System.Drawing.Point(224, 40);
            this.addCoach.Margin = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.addCoach.Name = "addCoach";
            this.addCoach.Padding = new System.Windows.Forms.Padding(5, 0, 0, 2);
            this.addCoach.Size = new System.Drawing.Size(112, 205);
            this.addCoach.TabIndex = 8;
            this.addCoach.Text = "             Add Coach";
            this.addCoach.UseVisualStyleBackColor = false;
            this.addCoach.Click += new System.EventHandler(this.addCoach_Click);
            // 
            // addPlayer
            // 
            this.addPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.addPlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addPlayer.FlatAppearance.BorderSize = 0;
            this.addPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPlayer.Font = new System.Drawing.Font("Switzer Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPlayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.addPlayer.Image = global::ClubMenagment.Properties.Resources.soccer_player_add;
            this.addPlayer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addPlayer.Location = new System.Drawing.Point(112, 40);
            this.addPlayer.Margin = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.addPlayer.Name = "addPlayer";
            this.addPlayer.Padding = new System.Windows.Forms.Padding(5, 0, 0, 2);
            this.addPlayer.Size = new System.Drawing.Size(112, 205);
            this.addPlayer.TabIndex = 7;
            this.addPlayer.Text = "             Add Player";
            this.addPlayer.UseVisualStyleBackColor = false;
            this.addPlayer.Click += new System.EventHandler(this.addPlayer_Click);
            // 
            // adminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 441);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.addUser);
            this.Controls.Add(this.addCoach);
            this.Controls.Add(this.addPlayer);
            this.Controls.Add(this.top_panel);
            this.Controls.Add(this.menuPanel);
            this.Name = "adminDashboard";
            this.Text = "adminMainForm";
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel top_panel;
        public System.Windows.Forms.TextBox UserNameText;
        private System.Windows.Forms.Button Logout_btn;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button CoachBtn;
        private System.Windows.Forms.Button PlayersBtn;
        private System.Windows.Forms.Panel logo_panel;
        private System.Windows.Forms.Button OverviewBtn;
        private System.Windows.Forms.Button usersBtn;
        private System.Windows.Forms.Button addPlayer;
        private System.Windows.Forms.Button addCoach;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}