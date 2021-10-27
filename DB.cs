using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyrimPlayer
{
    class DB
    {
        private readonly MySqlConnection connection = new(ConfigurationManager.ConnectionStrings["DBCharact"].ConnectionString);

        public void openDB()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
                Console.WriteLine("ДА");
            }
        }

        public string AddToDB(MyCharacter character)
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                MySqlCommand command = new MySqlCommand($"INSERT INTO [character] (Race, HomeTown, Profession, WorldVision, BadHabbit) VALUES ('{character.MyRace}', '{character.MyTown}', '{character.MyProfecy}', '{character.MyWorldVision}', '{character.MyBadHabbit}')", connection);
                int i = command.ExecuteNonQuery();
                return "Good";
            }
            else return "Bad";
        }

        //public List<MyCharacter> Filter(string[] param, string[] value)
        //{
        //    int temp = 0;
        //    string filt = "";
        //    for(int i = 0; i<param.Length-1; i++)
        //    {
        //        filt += $"{param[i]}={value[i]} AND";
        //        temp++;
        //    }
        //    filt += $"{param[temp]}={value[temp]}";
        //    MySqlCommand command = new MySqlCommand($"SELECT * FROM [character] WHERE {filt} ");
        //    command.ExecuteNonQuery();
        //}

        public void closeDB()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}