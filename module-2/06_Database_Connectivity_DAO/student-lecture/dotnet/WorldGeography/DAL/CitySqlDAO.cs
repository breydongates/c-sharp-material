using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WorldGeography.Models;

namespace WorldGeography.DAL
{
    public class CitySqlDAO
    {
        private string connectionString;

        private string sqlGetCitiesByCountryCode = "SELECT * FROM city WHERE " + "countrycode = @countrycode;";

        private string sqlAddCity = "INSERT INTO city (name, countrycode, district, population)" 
            + " VALUES (@name, @countrycode, @district, @population);";

        /// <summary>
        /// Creates a new sql-based city dao.
        /// </summary>
        /// <param name="databaseconnectionString"></param>
        public CitySqlDAO(string databaseconnectionString)
        {
            connectionString = databaseconnectionString;
        }

        public void AddCity(City city)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(sqlAddCity, conn);

                command.Parameters.AddWithValue("@name", city.Name);
                command.Parameters.AddWithValue("@countrycode", city.CountryCode);
                command.Parameters.AddWithValue("@district", city.District);
                command.Parameters.AddWithValue("@population", city.Population);
                //name, countrycode, district, population

                int count = command.ExecuteNonQuery();

             
            }
            return;
        }
    }

        public IList<City> GetCitiesByCountryCode(string countryCode)
        {
            IList<City> cities = new List<City>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(sqlGetCitiesByCountryCode, conn);

                command.Parameters.AddWithValue("@countrycode", countryCode);
                //parameter? 

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    City city = new City();
                    city.Name = Convert.ToString(reader["name"]);
                    city.CityId = Convert.ToInt32(reader["id"]);
                    city.CountryCode = Convert.ToString(reader["countrycode"]);
                    city.District = Convert.ToString(reader["district"]);
                    city.Population = Convert.ToInt32(reader["population"]);

                    /*
                     * 
                       [id]
                      ,[name]
                      ,[countrycode]
                      ,[district]
                      ,[population]
                     * 
                     */

                    cities.Add(city);
                }
            }
            return cities;
        }
    }
}
