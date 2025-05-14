using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunLog
{
    internal class GunDatabase
    {
    
        private static string dbFile = "gunlist.sqlite";
        private static string connectionString = $"Data Source={dbFile};Version=3;";
        public static void initializeDatabase()
        {
            if (!File.Exists(dbFile))
            {
                SQLiteConnection.CreateFile(dbFile);
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // SQL to create table if it doesn't exist
                    string createTableSql = @"CREATE TABLE IF NOT EXISTS Guns (
                                              serial TEXT NOT NULL,
                                              make TEXT NOT NULL,
                                              model TEXT NOT NULL,
                                              caliber TEXT NOT NULL,
                                              roundCount INTEGER NOT NULL DEFAULT 0,
                                              price REAL NOT NULL,
                                              dateAcquired TEXT NOT NULL)";
        
                    using (SQLiteCommand command = new SQLiteCommand(createTableSql, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
        
        public static List<Gun> GetAllGuns()
        {
            var guns = new List<Gun>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string selectQuery = "SELECT * FROM Guns"; //selects and returns all columns
                using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                using(var reader =  command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string serial = reader.GetString(0); 
                        string make = reader.GetString(1); 
                        string model = reader.GetString(2); 
                        string caliber = reader.GetString(3); 
                        int roundCount = reader.GetInt32(4); 
                        double price = reader.GetDouble(5);
                        string dateAcquired = reader.GetString(6);

                        guns.Add(new Gun(serial, make, model, caliber, roundCount, price, dateAcquired));
                    }
                    
                }
            }
            return guns;
        }

        public static void InsertGun(Gun gun)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string insertQuery = "INSERT INTO Guns(serial, make, model, caliber, roundCount, price, dateAcquired) VALUES (@serial, @make, @model, @caliber, @roundCount, @price, @dateAcquired)";
                using(SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@serial", gun.serial);
                    command.Parameters.AddWithValue("@make", gun.make);
                    command.Parameters.AddWithValue("@model", gun.model);
                    command.Parameters.AddWithValue("@caliber", gun.caliber); 
                    command.Parameters.AddWithValue("@roundCount", gun.roundCount);
                    command.Parameters.AddWithValue("@price", gun.price);
                    command.Parameters.AddWithValue("@dateAcquired", gun.dateAcquired);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteGunBySerial(string serial)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string deleteQuery = "DELETE FROM Guns WHERE serial = @serial";
                using (SQLiteCommand command = new SQLiteCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@serial", serial);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateGun(Gun gun) //updates gun objects based on changes made
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string updateQuery = "UPDATE guns SET make = @make, model = @model, caliber = @caliber, roundCount = @roundCount, price = @price, dateAcquired = @dateAcquired WHERE serial = @serial";
                using (SQLiteCommand command = new SQLiteCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@serial", gun.serial);
                    command.Parameters.AddWithValue("@make", gun.make);
                    command.Parameters.AddWithValue("@model", gun.model);
                    command.Parameters.AddWithValue("@caliber", gun.caliber);
                    command.Parameters.AddWithValue("@roundCount", gun.roundCount);
                    command.Parameters.AddWithValue("@price", gun.price);
                    command.Parameters.AddWithValue("@dateAcquired", gun.dateAcquired);
                    command.ExecuteNonQuery();
                }

            }
        }
        public static void UpdateRoundCount(string serial, int newRoundCount)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string updateQuery = "UPDATE Guns SET roundCount = @roundCount WHERE serial = @serial";
                using (SQLiteCommand command = new SQLiteCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@serial", serial);
                    command.Parameters.AddWithValue("@roundCount", newRoundCount);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
