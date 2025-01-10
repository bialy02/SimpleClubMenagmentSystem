using ClubMenagment.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubMenagment
{
    public partial class adminDashboard : Form
    {
        public adminDashboard()
        {
            InitializeComponent();
        }

        private void OverviewBtn_Click(object sender, EventArgs e)
        {

        }

        private void addPlayer_Click(object sender, EventArgs e)
        {
            addPlayerForm add = new addPlayerForm();
            add.Show();
        }

        private void PlayersBtn_Click(object sender, EventArgs e)
        {
            PlayersForm pf = new PlayersForm();
            pf.Show();
            this.Close();
        }

        private void menuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void top_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logo_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addCoach_Click(object sender, EventArgs e)
        {
            addCoachForm add = new addCoachForm();
            add.Show();

        }

        private void addUser_Click(object sender, EventArgs e)
        {
            addUserForm add = new addUserForm();
            add.Show();
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            loginForm login = new loginForm();
            login.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RemoveCoachForm remove = new RemoveCoachForm();
            remove.Show(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RemovePlayerForm remove = new RemovePlayerForm();
            remove.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RemoveUserForm remove = new RemoveUserForm();
            remove.Show();
        }
    }
}
