﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubMenagment.forms
{
    public partial class ComfirmRemoveForm : Form
    {

       public bool isConfirmed = false;
        public ComfirmRemoveForm()
        {
            InitializeComponent();
        }

        private void ComfirmRemove_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            isConfirmed = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            isConfirmed = false;
            this.Close();
        }
    }
}
