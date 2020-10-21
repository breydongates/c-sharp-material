using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using WorldGeography.DAL;
using WorldGeography.Models;

namespace WorldGeographyTest.cs
{
    [TestClass]
    public class CitySqlDAOTest
    {
        private string connectionString = "Server=.\\SQLEXPRESS;Database=World;Trusted_Connection=True;";


        [TestMethod]
        public void AddCityTest()
        {
            int countBefore = 0;
            int countAfter = 0;
            //arrange
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                SqlTransaction transaction;
                conn.Open();
                transaction = conn.BeginTransaction();
                SqlCommand command = new SqlCommand(
                    "SELECT count(*) FROM city;", conn, transaction);

                countBefore = (int)command.ExecuteScalar(); //counts everything in the cities before the new one is added

                CitySqlDAO dao = new CitySqlDAO(connectionString);
                City city = new City();
                city.Name = "Johntown";
                city.CountryCode = "GBR";
                city.Population = 4;
                city.District = "England";
                //act
                dao.AddCity(city);

                command = new SqlCommand(
                   "SELECT count(*) FROM city;", conn, transaction);

                countAfter = (int)command.ExecuteScalar(); //counts everything in the cities before the new one is added


                //assert
                Assert.AreEqual(countBefore + 1, countAfter);

                transaction.Rollback();
            }
        }

        //void AddCity (City city)
    }
}
