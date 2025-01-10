using ClubMenagment.Models;
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

namespace ClubMenagment.forms
{
    public partial class RemovePlayerForm : Form
    {
        private readonly string connectionString = "Server=localhost;Database=clubmenagment;User Id=root;Password=;";
        public RemovePlayerForm()
        {
            InitializeComponent();
            loadPlayers();
        }

        void loadPlayers()
        {
            try { 
                comboPlayers.Items.Clear();
                using(MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT PlayerId,FirstName,LastName,ShirtNumber,PositionId,Squad FROM player";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Player player = new Player
                        {
                            PlayerId = reader.GetInt32("PlayerId"),
                            FirstName = reader.GetString("FirstName"),
                            LastName = reader.GetString("LastName"),
                            ShirtNumber = reader.GetInt32("ShirtNumber"),
                            PositionId = reader.GetInt32("PositionId"),
                            Squad = reader.GetString("Squad")
                        };
                        string playerDetails = $"{player.PlayerId} Name: {player.FirstName} {player.LastName} Number: {player.ShirtNumber} Position: {(PlayerPosition)player.PositionId} Squad: {player.Squad}";
                        comboPlayers.Items.Add(playerDetails);
                    }

                   

                    reader.Close();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void RemovePlayer_Load(object sender, EventArgs e)
        {

        }

        private void removePlayerBtn_Click(object sender, EventArgs e)
        {
            ComfirmRemoveForm comfirm = new ComfirmRemoveForm();
            comfirm.ShowDialog();

            if (comfirm.isConfirmed)
            {
                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM player WHERE PlayerId = @PlayerId";
                        MySqlCommand command = new MySqlCommand(query, connection);

                        string selectedPlayer = comboPlayers.SelectedItem.ToString();
                        string[] playerDetails = selectedPlayer.Split(new string[] { " Name: ", " Number: ", " Position: ", " Squad: " }, StringSplitOptions.None);
                        int playerId = int.Parse(playerDetails[0]);

                        command.Parameters.AddWithValue("@PlayerId", playerId);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Player removed successfully");
                        comboPlayers.Items.Clear();
                        comboPlayers.ResetText();
                        loadPlayers();
                    }
                }
                catch (Exception ex)
                {
                    Clipboard.SetText(ex.Message);
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
