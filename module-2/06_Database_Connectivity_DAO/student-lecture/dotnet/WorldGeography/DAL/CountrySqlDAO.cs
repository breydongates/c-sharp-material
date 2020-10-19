using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WorldGeography.Models;

namespace WorldGeography.DAL
{
    public class CountrySqlDAO
    {
        private string connectionString;

        private string sqlGetCountry = "SELECT * FROM country;";

        /// <summary>
        /// Creates a sql based country dao.
        /// </summary>
        /// <param name="databaseconnectionString"></param>
        public CountrySqlDAO(string databaseconnectionString)
        {
            connectionString = databaseconnectionString;
        }

        public IList<Country> GetCountries()
        {
            IList<Country> countries = new List<Country>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(sqlGetCountry, conn);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Country country = new Country();
                    country.Code = Convert.ToString(reader["code"]);
                    country.Name = Convert.ToString(reader["name"]);
                    country.Continent = Convert.ToString(reader["continent"]);
                    country.Region = Convert.ToString(reader["region"]);
                    country.SurfaceArea = Convert.ToDouble(reader["surfacearea"]);

                    /*
                     * 
                     * [code]
                     ,[name]
                      ,[continent]
                      ,[region]
                      ,[surfacearea]
                     * 
                     * 
                     */

                    countries.Add(country);
                }
            }
            return countries;
        }

        public IList<Country> GetCountries(string continent)
        {
            throw new NotImplementedException();
        }
    }
}
