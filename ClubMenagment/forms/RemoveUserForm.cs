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
    public partial class RemoveUserForm : Form
    {
        private readonly string connectionString = "Server=localhost;Database=clubmenagment;User Id=root;Password=;";
        public RemoveUserForm()
        {
            InitializeComponent();
            loadUser();
        }

        public void loadUser()
        {
            try
            {
                comboUser.Items.Clear();
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Id,Username, Name FROM users";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        User user = new User
                        {
                            UserId = reader.GetInt32("Id"),
                            Username = reader.GetString("Username"),
                            Name = reader.GetString("Name")

                        };
                        string userDetails = $"{user.UserId} Name: {user.Username} {user.Name}";
                        comboUser.Items.Add(userDetails);
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
                        string query = "DELETE FROM users WHERE Id = @userId";
                        MySqlCommand command = new MySqlCommand(query, connection);

                        string selectedCoach = comboUser.SelectedItem.ToString();
                        string[] coachDetails = selectedCoach.Split(new string[] { " Name: " }, StringSplitOptions.None);
                        int userId = int.Parse(coachDetails[0]);

                        command.Parameters.AddWithValue("@userId", userId);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Player removed successfully");
                        comboUser.Items.Clear();
                        comboUser.ResetText();
                        loadUser();
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
