namespace ClubMenagment
{
    partial class addPlayerForm
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
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.surnameTxtBox = new System.Windows.Forms.TextBox();
            this.CountrycomboBox = new System.Windows.Forms.ComboBox();
            this.PositoncomboBox = new System.Windows.Forms.ComboBox();
            this.AgeNumeric = new System.Windows.Forms.NumericUpDown();
            this.shirtNumber = new System.Windows.Forms.NumericUpDown();
            this.isInjured = new System.Windows.Forms.ComboBox();
            this.ValueBox = new System.Windows.Forms.TextBox();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.weightBox = new System.Windows.Forms.TextBox();
            this.squadCombo = new System.Windows.Forms.ComboBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelPosiotn = new System.Windows.Forms.Label();
            this.labelShirt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AgeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shirtNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(8, 40);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(160, 20);
            this.nameTxtBox.TabIndex = 0;
            // 
            // surnameTxtBox
            // 
            this.surnameTxtBox.Location = new System.Drawing.Point(176, 40);
            this.surnameTxtBox.Name = "surnameTxtBox";
            this.surnameTxtBox.Size = new System.Drawing.Size(184, 20);
            this.surnameTxtBox.TabIndex = 1;
            // 
            // CountrycomboBox
            // 
            this.CountrycomboBox.FormattingEnabled = true;
            this.CountrycomboBox.Location = new System.Drawing.Point(8, 88);
            this.CountrycomboBox.Name = "CountrycomboBox";
            this.CountrycomboBox.Size = new System.Drawing.Size(121, 21);
            this.CountrycomboBox.TabIndex = 2;
            this.CountrycomboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // PositoncomboBox
            // 
            this.PositoncomboBox.FormattingEnabled = true;
            this.PositoncomboBox.Location = new System.Drawing.Point(144, 88);
            this.PositoncomboBox.Name = "PositoncomboBox";
            this.PositoncomboBox.Size = new System.Drawing.Size(121, 21);
            this.PositoncomboBox.TabIndex = 3;
            // 
            // AgeNumeric
            // 
            this.AgeNumeric.Location = new System.Drawing.Point(384, 40);
            this.AgeNumeric.Name = "AgeNumeric";
            this.AgeNumeric.Size = new System.Drawing.Size(80, 20);
            this.AgeNumeric.TabIndex = 4;
            // 
            // shirtNumber
            // 
            this.shirtNumber.Location = new System.Drawing.Point(280, 88);
            this.shirtNumber.Name = "shirtNumber";
            this.shirtNumber.Size = new System.Drawing.Size(96, 20);
            this.shirtNumber.TabIndex = 5;
            // 
            // isInjured
            // 
            this.isInjured.FormattingEnabled = true;
            this.isInjured.Location = new System.Drawing.Point(392, 88);
            this.isInjured.Name = "isInjured";
            this.isInjured.Size = new System.Drawing.Size(96, 21);
            this.isInjured.TabIndex = 6;
            // 
            // ValueBox
            // 
            this.ValueBox.Location = new System.Drawing.Point(8, 136);
            this.ValueBox.Name = "ValueBox";
            this.ValueBox.Size = new System.Drawing.Size(120, 20);
            this.ValueBox.TabIndex = 7;
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(144, 136);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(100, 20);
            this.heightBox.TabIndex = 8;
            // 
            // weightBox
            // 
            this.weightBox.Location = new System.Drawing.Point(264, 136);
            this.weightBox.Name = "weightBox";
            this.weightBox.Size = new System.Drawing.Size(112, 20);
            this.weightBox.TabIndex = 9;
            // 
            // squadCombo
            // 
            this.squadCombo.FormattingEnabled = true;
            this.squadCombo.Location = new System.Drawing.Point(392, 136);
            this.squadCombo.Name = "squadCombo";
            this.squadCombo.Size = new System.Drawing.Size(96, 21);
            this.squadCombo.TabIndex = 10;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(336, 168);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(136, 23);
            this.addBtn.TabIndex = 11;
            this.addBtn.Text = "Add Player";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(8, 24);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(67, 13);
            this.labelName.TabIndex = 12;
            this.labelName.Text = "Player Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(176, 24);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(81, 13);
            this.labelSurname.TabIndex = 13;
            this.labelSurname.Text = "Player Surname";
            this.labelSurname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(384, 24);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(58, 13);
            this.labelAge.TabIndex = 14;
            this.labelAge.Text = "Player Age";
            this.labelAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(8, 72);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(75, 13);
            this.labelCountry.TabIndex = 15;
            this.labelCountry.Text = "Player Country";
            this.labelCountry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPosiotn
            // 
            this.labelPosiotn.AutoSize = true;
            this.labelPosiotn.Location = new System.Drawing.Point(144, 72);
            this.labelPosiotn.Name = "labelPosiotn";
            this.labelPosiotn.Size = new System.Drawing.Size(76, 13);
            this.labelPosiotn.TabIndex = 16;
            this.labelPosiotn.Text = "Player Position";
            this.labelPosiotn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelShirt
            // 
            this.labelShirt.AutoSize = true;
            this.labelShirt.Location = new System.Drawing.Point(280, 72);
            this.labelShirt.Name = "labelShirt";
            this.labelShirt.Size = new System.Drawing.Size(100, 13);
            this.labelShirt.TabIndex = 17;
            this.labelShirt.Text = "Player Shirt Number";
            this.labelShirt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(392, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Player Injured";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Player Value";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Player Height";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Player Weight";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(392, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Player Squad";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 208);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelShirt);
            this.Controls.Add(this.labelPosiotn);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.squadCombo);
            this.Controls.Add(this.weightBox);
            this.Controls.Add(this.heightBox);
            this.Controls.Add(this.ValueBox);
            this.Controls.Add(this.isInjured);
            this.Controls.Add(this.shirtNumber);
            this.Controls.Add(this.AgeNumeric);
            this.Controls.Add(this.PositoncomboBox);
            this.Controls.Add(this.CountrycomboBox);
            this.Controls.Add(this.surnameTxtBox);
            this.Controls.Add(this.nameTxtBox);
            this.Name = "addPlayerForm";
            this.Text = "addPlayerForm";
            ((System.ComponentModel.ISupportInitialize)(this.AgeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shirtNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.TextBox surnameTxtBox;
        private System.Windows.Forms.ComboBox CountrycomboBox;
        private System.Windows.Forms.ComboBox PositoncomboBox;
        private System.Windows.Forms.NumericUpDown AgeNumeric;
        private System.Windows.Forms.NumericUpDown shirtNumber;
        private System.Windows.Forms.ComboBox isInjured;
        private System.Windows.Forms.TextBox ValueBox;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.TextBox weightBox;
        private System.Windows.Forms.ComboBox squadCombo;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelPosiotn;
        private System.Windows.Forms.Label labelShirt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}