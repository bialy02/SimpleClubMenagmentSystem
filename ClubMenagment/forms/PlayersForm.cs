using ClubMenagment.Models;
using Google.Protobuf.WellKnownTypes;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClubMenagment.forms
{
    public partial class PlayersForm : Form
    {

        private readonly string connectionString = "Server=localhost;Database=clubmenagment;User Id=root;Password=;";
        public PlayersForm()
        {
            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
            loadColumns();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT FirstName, LastName, CountryId, Age, ShirtNumber, PositionId, IsInjured, Value, Weight, Height, Squad FROM player";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Player player = new Player
                        {
                            FirstName = reader.GetString("FirstName"),
                            LastName = reader.GetString("LastName"),
                            Country = (Countries)(reader.GetInt32("CountryId")-1),
                            Age = reader.GetInt32("Age"),
                            ShirtNumber = reader.GetInt32("ShirtNumber"),
                            Position = (PlayerPosition)reader.GetInt32("PositionId"),
                            IsInjured = reader.GetBoolean("IsInjured"),
                            Value = reader.GetDecimal("Value"),
                            Weight = reader.GetFloat("Weight"),
                            Height = reader.GetFloat("Height"),
                            Squad = reader.GetString("Squad")
                        };
                       // dataPlayers.Rows.Add(reader.GetString("FirstName"), reader.GetString("LastName"), reader.GetInt32("CountryId"), reader.GetInt32("Age"), reader.GetInt32("ShirtNumber"), reader.GetInt32("PositionId"), reader.GetBoolean("IsInjured"), reader.GetDouble("Value"), reader.GetDouble("Weight"), reader.GetDouble("Height"), reader.GetString("Squad"));
                       dataPlayers.Rows.Add(player.FirstName, player.LastName,  player.Country, player.Age, player.ShirtNumber, player.Position, player.IsInjured, player.Value, player.Weight, player.Height, player.Squad);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void loadColumns()
        {
            dataPlayers.Columns.Add("FirstName", "FirstName");
            dataPlayers.Columns.Add("LastName", "LastName");
            dataPlayers.Columns.Add("CountryId", "CountryId");
            dataPlayers.Columns.Add("Age", "Age");
            dataPlayers.Columns.Add("ShirtNumber", "ShirtNumber");
            dataPlayers.Columns.Add("Position", "Position");
            dataPlayers.Columns.Add("IsInjured", "IsInjured");
            dataPlayers.Columns.Add("Value", "Value");
            dataPlayers.Columns.Add("Weight", "Weight");
            dataPlayers.Columns.Add("Height", "Height");
            dataPlayers.Columns.Add("Squad", "Squad");
            this.Controls.Add(dataPlayers);
        }
        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void OverviewBtn_Click(object sender, EventArgs e)
        {
            Dashboard mainForm = new Dashboard();
            mainForm.Show();
            this.Close();
        }
    }
}
