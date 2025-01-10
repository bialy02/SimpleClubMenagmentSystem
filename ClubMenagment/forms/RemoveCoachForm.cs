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

   
    public partial class RemoveCoachForm : Form
    {
        private readonly string connectionString = "Server=localhost;Database=clubmenagment;User Id=root;Password=;";
        public RemoveCoachForm()
        {
            InitializeComponent();
            LoadCoaches();  
        }

        public void LoadCoaches()
        {
            try
            {
                comboCoach.Items.Clear();
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT MenagerId,FirstName,LastName FROM menager";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Menager coach = new Menager
                        {
                            CoachId = reader.GetInt32("MenagerId"),
                            FirstName = reader.GetString("FirstName"),
                            LastName = reader.GetString("LastName")
                        };
                        string coachDetails = $"{coach.CoachId} Name: {coach.FirstName} {coach.LastName}";
                        comboCoach.Items.Add(coachDetails);
                    }
                    reader.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void removeCoachBtn_Click(object sender, EventArgs e)
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
                        string query = "DELETE FROM menager WHERE MenagerId = @coachId";
                        MySqlCommand command = new MySqlCommand(query, connection);

                        string selectedCoach = comboCoach.SelectedItem.ToString();
                        string[] coachDetails = selectedCoach.Split(new string[] { " Name: " }, StringSplitOptions.None);
                        int coachId = int.Parse(coachDetails[0]);

                        command.Parameters.AddWithValue("@coachId", coachId);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Player removed successfully");
                        comboCoach.Items.Clear();
                        comboCoach.ResetText();
                        LoadCoaches();
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
