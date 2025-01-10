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
    public partial class addCoachForm : Form
    {
        private readonly string connectionString = "Server=localhost;Database=clubmenagment;User Id=root;Password=;";
        public addCoachForm()
        {
            InitializeComponent();
        }

        public void loadCountiesData()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT CountryId, CountryName FROM countries";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    MySqlDataReader reader = command.ExecuteReader();
                    CountrycomboBox.Items.Clear();

                    while (reader.Read())
                    {
                        var country = new { CountryId = reader["CountryId"], CountryName = reader["CountryName"] };
                        CountrycomboBox.Items.Add(new { country.CountryId, country.CountryName });
                    }

                    CountrycomboBox.DisplayMember = "CountryName";
                    CountrycomboBox.ValueMember = "CountryId";

                    reader.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addCoachForm_Load(object sender, EventArgs e)
        {
            loadCountiesData();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using(MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO menager (FirstName, LastName, CountryId) VALUES (@FirstName, @LastName, @CountryId)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                
                    command.Parameters.AddWithValue("@FirstName", nameTxtBox.Text);
                    command.Parameters.AddWithValue("@LastName", surnameTxtBox.Text);
                    var selectedCountry = (dynamic)CountrycomboBox.SelectedItem;
                    command.Parameters.AddWithValue("@CountryId", selectedCountry.CountryId);

                    command.ExecuteNonQuery();
                    this.Close();
                    MessageBox.Show("Coach added successfully");
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
