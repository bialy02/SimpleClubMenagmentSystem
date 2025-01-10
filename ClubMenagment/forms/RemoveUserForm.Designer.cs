namespace ClubMenagment.forms
{
    partial class RemoveUserForm
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
            this.rmUser = new System.Windows.Forms.Label();
            this.removeCoachBtn = new System.Windows.Forms.Button();
            this.comboUser = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // rmUser
            // 
            this.rmUser.AutoSize = true;
            this.rmUser.Location = new System.Drawing.Point(116, 50);
            this.rmUser.Name = "rmUser";
            this.rmUser.Size = new System.Drawing.Size(117, 13);
            this.rmUser.TabIndex = 8;
            this.rmUser.Text = "Select User to Remove";
            // 
            // removeCoachBtn
            // 
            this.removeCoachBtn.Location = new System.Drawing.Point(228, 106);
            this.removeCoachBtn.Name = "removeCoachBtn";
            this.removeCoachBtn.Size = new System.Drawing.Size(192, 23);
            this.removeCoachBtn.TabIndex = 7;
            this.removeCoachBtn.Text = "Remove User";
            this.removeCoachBtn.UseVisualStyleBackColor = true;
            this.removeCoachBtn.Click += new System.EventHandler(this.removeCoachBtn_Click);
            // 
            // comboUser
            // 
            this.comboUser.FormattingEnabled = true;
            this.comboUser.Location = new System.Drawing.Point(116, 66);
            this.comboUser.Name = "comboUser";
            this.comboUser.Size = new System.Drawing.Size(408, 21);
            this.comboUser.TabIndex = 6;
            // 
            // RemoveUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 179);
            this.Controls.Add(this.rmUser);
            this.Controls.Add(this.removeCoachBtn);
            this.Controls.Add(this.comboUser);
            this.Name = "RemoveUserForm";
            this.Text = "RemoveUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rmUser;
        private System.Windows.Forms.Button removeCoachBtn;
        private System.Windows.Forms.ComboBox comboUser;
    }
}