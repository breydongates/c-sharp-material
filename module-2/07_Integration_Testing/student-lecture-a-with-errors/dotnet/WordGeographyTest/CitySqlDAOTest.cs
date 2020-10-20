using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.SqlClient;
using System.Transactions;
using WorldGeography.DAL;
using WorldGeography.Models;

namespace WordGeographyTest
{
    [TestClass]
    public class CitySqlDAOTest
    {

        private TransactionScope transaction;

        private string connectionString = "Server=.\\SQLEXPRESS;Database=World;Trusted_Connection=True;";

        [TestMethod]
        public void AddCityTest()
        {
            int countBefore = 0;
            int countAfter = 0;

            transaction = new TransactionScope();

            //Arrange
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {

                    conn.Open();



                    SqlCommand command = new SqlCommand(
                        "SELECT count(*) FROM city;", conn);

                    countBefore = (int)command.ExecuteScalar();


                    CitySqlDAO dao = new CitySqlDAO(connectionString);
                    City city = new City();
                    city.Name = "Johntown";
                    city.CountryCode = "GBR";
                    city.Population = 4;
                    city.District = "England";

                    //Act
                    dao.AddCity(city);


                    command = new SqlCommand(
                        "SELECT count(*) FROM city;", conn);

                    countAfter = (int)command.ExecuteScalar();


                    //Assert
                    Assert.AreEqual(countBefore + 1, countAfter);
                }
            }
            finally
            {
                transaction.Dispose();
            }
        }

    }
}
