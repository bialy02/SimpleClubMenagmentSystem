using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

using Mysqlx.Session;

namespace ClubMenagment
{
    public partial class addPlayerForm : Form
    {
        private readonly string connectionString = "Server=localhost;Database=clubmenagment;User Id=root;Password=;";

       
       public addPlayerForm()
        {
            InitializeComponent();
            loadCountiesData();
            loadPostionData();
            loadIsInjured();
            loadSquad();
        }

        public void loadSquad()
        {
            squadCombo.Items.Add("First Team");
            squadCombo.Items.Add("Second Team");
            squadCombo.Items.Add("Youth Team");
        }

        public void loadIsInjured()
        {
            isInjured.Items.Add("Yes");
            isInjured.Items.Add("No");

  
            isInjured.SelectedIndex = 1;

        }

        public void loadPostionData()
        {
            try {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT PositionId, PositionName FROM playerposition";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    MySqlDataReader reader = command.ExecuteReader();
                    PositoncomboBox.Items.Clear();

                    while (reader.Read())
                    {
                        var position = new { PositionId = reader["PositionId"], PositionName = reader["PositionName"] };
                        PositoncomboBox.Items.Add(new { position.PositionId, position.PositionName });
                    }

                    PositoncomboBox.DisplayMember = "PositionName";
                    PositoncomboBox.ValueMember = "PositionId";

                    reader.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try {
                 using(MySqlConnection connection = new MySqlConnection(connectionString))
                  {
                      connection.Open();
                      string query = "INSERT INTO player (FirstName, LastName, CountryId, Age, ShirtNumber, PositionId, IsInjured, Value, Weight, Height, Squad) VALUES (@FirstName, @LastName, @CountryId, @Age, @ShirtNumber, @PositionId, @IsInjured, @Value, @Weight, @Height, @Squad)";
                      MySqlCommand command = new MySqlCommand(query, connection);

                      command.Parameters.AddWithValue("@FirstName", nameTxtBox.Text);
                      command.Parameters.AddWithValue("@LastName", surnameTxtBox.Text);
                      var selectedCountry = (dynamic)CountrycomboBox.SelectedItem;
                      command.Parameters.AddWithValue("@CountryId", selectedCountry.CountryId);
                      command.Parameters.AddWithValue("@Age",AgeNumeric.Value);
                      command.Parameters.AddWithValue("@ShirtNumber", shirtNumber.Value);
                      var selectedPosition = (dynamic)PositoncomboBox.SelectedItem;
                      command.Parameters.AddWithValue("@PositionId", selectedPosition.PositionId);
                      command.Parameters.AddWithValue("@IsInjured", (isInjured.Text.ToString()) == "Yes" ? true : false);
                      command.Parameters.AddWithValue("@Value", decimal.Parse(ValueBox.Text));
                      command.Parameters.AddWithValue("@Weight", float.Parse(weightBox.Text));
                      command.Parameters.AddWithValue("@Height", float.Parse(heightBox.Text));
                      command.Parameters.AddWithValue("@Squad", squadCombo.Text);


                      command.ExecuteNonQuery();

                      MessageBox.Show("Player added successfully!");
                     this.Close();

                  } 

               

            }
            catch (Exception ex)
            {
                Clipboard.SetText(ex.Message);
              
                MessageBox.Show(ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
