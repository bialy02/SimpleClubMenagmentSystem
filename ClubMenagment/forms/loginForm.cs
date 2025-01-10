using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

using MySql.Data.MySqlClient;
using Mysqlx.Session;

namespace ClubMenagment
{

    public partial class loginForm : Form
    {
      
        public loginForm()
        {
            InitializeComponent();
        }

        private void logo_panel_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void OverviewBtn_Click(object sender, EventArgs e)
        {

           LoginAuth logindata = new LoginAuth(usernameTxtBox.Text,passwordTxtBox.Text);
        
            (bool succes, string name) = logindata.Authenticate();

            if (succes)
            {
                if (name.ToLower() == "admin" )
                {
                    adminDashboard adminForm = new adminDashboard();
                    
                    adminForm.Show();
                    adminForm.UserNameText.Text = $"Hi! {name}";
                    this.Hide();
                }
                else
                {
                    Dashboard dash = new Dashboard();
                    dash.Show();
                    dash.UserNameText.Text = $"Hi! {name}";
                    this.Hide();
                }   
            }
            else
            {
                MessageBox.Show("Login failed!");
            }
        }

       

        private void loginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
