using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using VotersLoad.Models;

namespace VotersLoad
{
    public class DatabaseDAO
    {
        private string connectionString;
        
        private string sqlVoterInsert = "INSERT INTO Voter (state_id, county_id, registered, last_name, first_name) " +
            "VALUES (@state_id, @county_id, @registered, @last_name, @first_name);";
        
        private string sqlElectionInsert = "INSERT INTO Election (state_id, election_year, election_month, election_type, ballot_type) " +
            "VALUES ( @state_id, @election_year, @election_month, @election_type, @ballot_type);";

        private string sqlDeleteRows = "DELETE FROM Election; DELETE FROM Voter;";

        public DatabaseDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void WriteData(List<string> rows)
        {
            const int startingIndexForElections = 30;

            string[] header = new string[0]; 
            if (rows.Count > 1)
            {
                //capture the header row
                header = rows[0].Split('\t');
            }


            for (int i = 1; i < rows.Count; i++)
            {

                //split the string
                string[] thisRow = rows[i].Split('\t');
                string stateId = thisRow[0];
                string countyId = thisRow[1];
                DateTime registered = Convert.ToDateTime(thisRow[2]);
                string lastName = thisRow[3];
                string firstName = thisRow[4];

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(sqlVoterInsert, conn);
                    cmd.Parameters.AddWithValue("@state_id", stateId);
                    cmd.Parameters.AddWithValue("@county_id", countyId);
                    cmd.Parameters.AddWithValue("@registered", registered);
                    cmd.Parameters.AddWithValue("@last_name", lastName);
                    cmd.Parameters.AddWithValue("@first_name", firstName);

                    int count = cmd.ExecuteNonQuery();

                    if (count < 1)
                    {
                        throw new ApplicationException("Unable to write to database for voter.");
                    }

                }

                // get the election records for this voter
                List<Election> elections = ConvertElectionInfo(header, thisRow, startingIndexForElections);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    foreach (Election election in elections)
                    {
                        SqlCommand cmd = new SqlCommand(sqlElectionInsert, conn);
                        cmd.Parameters.AddWithValue("@state_id", election.StateId);
                        cmd.Parameters.AddWithValue("@election_year", election.ElectionYear);
                        cmd.Parameters.AddWithValue("@election_month", election.ElectionMonth);
                        cmd.Parameters.AddWithValue("@election_type", election.ElectionType);
                        cmd.Parameters.AddWithValue("@ballot_type", election.BallotType);


                        int count = cmd.ExecuteNonQuery();

                        if (count < 1)
                        {
                            throw new ApplicationException("Unable to write to database for election.");
                        }
                    }
                }

            }

            return;
        }

        public bool DeleteData()
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sqlDeleteRows, conn);

                int count = cmd.ExecuteNonQuery();

                if (count >= 1)
                {
                    result = true;
                }
            }

            return result;
        }

        private List<Election> ConvertElectionInfo(string[] headers, string[] items, int startingIndex)
        {
            // header has form MMYYYY-T
            // YYYY is year
            // MM is month
            // T if type

            List<Election> elections = new List<Election>();
           
            for(int i = startingIndex; i < headers.Length; i++)
            {
                if (!String.IsNullOrWhiteSpace(items[i]))
                {
                    Election election = new Election();
                    election.Id = 0;
                    election.StateId = items[0];
                    election.ElectionMonth = int.Parse(headers[i].Substring(0, 2));
                    election.ElectionYear = int.Parse(headers[i].Substring(2, 4));
                    election.ElectionType = headers[i].Substring(7, 1);
                    election.BallotType = items[i];
                    elections.Add(election);
                }
            }

            return elections;
        }
    }
}

