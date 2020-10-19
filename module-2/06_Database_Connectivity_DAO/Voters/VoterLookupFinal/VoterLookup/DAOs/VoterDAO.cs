using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using VoterLookup.Models;


namespace VoterLookup.DAOs
{
    public class VoterDAO
    {
        private string connectionString;

        private string sqlGetVotersByName = "SELECT * FROM Voter WHERE last_name LIKE '%' + @last_name + '%';";
        public VoterDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Voter> GetVotersByName(string name)
        {
            List<Voter> voters = new List<Voter>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sqlGetVotersByName, conn);

                cmd.Parameters.AddWithValue("@last_name", name);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Voter voter = new Voter();
                    voter.StateId = Convert.ToString(reader["state_id"]);
                    voter.CountyId = Convert.ToString(reader["county_id"]);
                    voter.Registered = Convert.ToDateTime(reader["registered"]);
                    voter.LastName = Convert.ToString(reader["last_name"]);
                    voter.FirstName = Convert.ToString(reader[ "first_name"]);
                    voters.Add(voter);
                }
            }

            return voters;
        }
    }
}
