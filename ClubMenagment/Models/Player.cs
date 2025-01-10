using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubMenagment.Models
{
    
    public class Player
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Countries Country { get; set; }
        public int Age { get; set; }
        public int ShirtNumber { get; set; }
        public PlayerPosition Position { get; set; }
        public bool IsInjured { get; set; }
         public decimal Value { get; set; }
        public float Weight { get; set; }
        public float Height { get; set; }

        public string Squad { get; set; }

        public string PhotoUrl { get; set; }
        public int PositionId { get; internal set; }
        public int PlayerId { get; internal set; }

        public Player()
        {

        }
       public Player(string FirstName, string LastName, Countries Country, int Age, int ShirtNumber, PlayerPosition Position, bool IsInjured, decimal Value, float Weight, float Height, string Squad, string PhotoUrl)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Country = Country;
            this.Age = Age;
            this.ShirtNumber = ShirtNumber;
            this.Position = Position;
            this.IsInjured = IsInjured;
            this.Value = Value;
            this.Weight = Weight;
            this.Height = Height;
            this.Squad = Squad;
            this.PhotoUrl = PhotoUrl;
        }
        private readonly string connectionString = "Server=localhost;Database=clubmenagment;User Id=root;Password=;";
        int GetId(string FirstName, string LastName, int ShirtNumber, PlayerPosition Position)
        {
            
            int playerId = -1;  // Domyślnie, jeśli nie znajdziemy gracza, zwrócimy -1 (lub możesz ustawić inne domyślne zachowanie)

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Zapytanie do bazy danych, aby znaleźć gracza na podstawie danych
                    string query = "SELECT PlayerId FROM player WHERE FirstName = @FirstName AND LastName = @LastName AND ShirtNumber = @ShirtNumber AND PositionId = @PositionId";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Parametry do zapytania
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@ShirtNumber", ShirtNumber);
                    command.Parameters.AddWithValue("@PositionId", (int)Position);  // Zamiana PlayerPosition na int

                    // Wykonaj zapytanie
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        
                        playerId = reader.GetInt32("PlayerId");
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd: " + ex.Message);
            }

            return playerId;  // Zwróć PlayerId lub -1, jeśli nie znaleziono gracza
        }
    }


}
