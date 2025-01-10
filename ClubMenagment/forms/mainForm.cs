using ClubMenagment.forms;
using MySql.Data.MySqlClient;
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
    public partial class Dashboard : Form
    {
        private readonly string connectionString = "Server=localhost;Database=clubmenagment;User Id=root;Password=;";
        public Dashboard()
        {
            InitializeComponent();
            loadPlayerNumber();
            loadInjuredNumber();
            loadClubValue();
        }

        private string FormatValue(decimal value)
        {
            if (value >= 1000000)
                return $"{value / 1000000:0.#} mln $";
            else if (value >= 1000)
                return $"{value / 1000:0.#} tys. $";
            else
                return $"{value} $";
        }
        public void loadClubValue()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT sum(Value) FROM player";
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    decimal count = Convert.ToDecimal(cmd.ExecuteScalar());
                    clubvaluNumb.Text = FormatValue(count);
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void loadInjuredNumber()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT COUNT(*) FROM player WHERE IsInjured = True";
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    injuredPlayerNum.Text = count.ToString();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void loadPlayerNumber()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT COUNT(*) FROM player";
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    playerNum.Text = count.ToString();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            loginForm login = new loginForm();
            login.Show();
            this.Close();
        }

        private void menuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PlayersBtn_Click(object sender, EventArgs e)
        {
            PlayersForm players = new PlayersForm();
            players.Show();
            this.Close();
          
        }
    }
}
