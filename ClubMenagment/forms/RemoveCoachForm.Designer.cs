namespace ClubMenagment.forms
{
    partial class RemoveCoachForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.removeCoachBtn = new System.Windows.Forms.Button();
            this.comboCoach = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select Coach to Remove";
            // 
            // removeCoachBtn
            // 
            this.removeCoachBtn.Location = new System.Drawing.Point(312, 80);
            this.removeCoachBtn.Name = "removeCoachBtn";
            this.removeCoachBtn.Size = new System.Drawing.Size(192, 23);
            this.removeCoachBtn.TabIndex = 4;
            this.removeCoachBtn.Text = "Remove Coach";
            this.removeCoachBtn.UseVisualStyleBackColor = true;
            this.removeCoachBtn.Click += new System.EventHandler(this.removeCoachBtn_Click);
            // 
            // comboCoach
            // 
            this.comboCoach.FormattingEnabled = true;
            this.comboCoach.Location = new System.Drawing.Point(200, 40);
            this.comboCoach.Name = "comboCoach";
            this.comboCoach.Size = new System.Drawing.Size(408, 21);
            this.comboCoach.TabIndex = 3;
            // 
            // RemoveCoachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 123);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeCoachBtn);
            this.Controls.Add(this.comboCoach);
            this.Name = "RemoveCoachForm";
            this.Text = "RemoveCoachForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button removeCoachBtn;
        private System.Windows.Forms.ComboBox comboCoach;
    }
}