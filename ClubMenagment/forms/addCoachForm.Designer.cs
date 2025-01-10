namespace ClubMenagment.forms
{
    partial class addCoachForm
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
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.CountrycomboBox = new System.Windows.Forms.ComboBox();
            this.surnameTxtBox = new System.Windows.Forms.TextBox();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(40, 88);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(77, 13);
            this.labelCountry.TabIndex = 21;
            this.labelCountry.Text = "Coach Country";
            this.labelCountry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(208, 40);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(83, 13);
            this.labelSurname.TabIndex = 20;
            this.labelSurname.Text = "Caoch Surname";
            this.labelSurname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(40, 40);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(69, 13);
            this.labelName.TabIndex = 19;
            this.labelName.Text = "Caoch Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CountrycomboBox
            // 
            this.CountrycomboBox.FormattingEnabled = true;
            this.CountrycomboBox.Location = new System.Drawing.Point(40, 104);
            this.CountrycomboBox.Name = "CountrycomboBox";
            this.CountrycomboBox.Size = new System.Drawing.Size(121, 21);
            this.CountrycomboBox.TabIndex = 18;
            // 
            // surnameTxtBox
            // 
            this.surnameTxtBox.Location = new System.Drawing.Point(208, 56);
            this.surnameTxtBox.Name = "surnameTxtBox";
            this.surnameTxtBox.Size = new System.Drawing.Size(184, 20);
            this.surnameTxtBox.TabIndex = 17;
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(40, 56);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(160, 20);
            this.nameTxtBox.TabIndex = 16;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(184, 104);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(176, 23);
            this.addBtn.TabIndex = 22;
            this.addBtn.Text = "Add Coach";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // addCoachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 175);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.CountrycomboBox);
            this.Controls.Add(this.surnameTxtBox);
            this.Controls.Add(this.nameTxtBox);
            this.Name = "addCoachForm";
            this.Text = "addCoachForm";
            this.Load += new System.EventHandler(this.addCoachForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ComboBox CountrycomboBox;
        private System.Windows.Forms.TextBox surnameTxtBox;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.Button addBtn;
    }
}