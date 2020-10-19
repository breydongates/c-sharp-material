using System;
using System.Collections.Generic;
using System.Text;

namespace VoterLookup.Models
{
    public class Voter
    {
        public Voter()
        {

        }

        public Voter(string stateId, string countyId, string registered,
            string lastName, string firstName)
        {
            StateId = stateId;
            CountyId = countyId;
            Registered = Convert.ToDateTime( registered);
            LastName = lastName;
            FirstName = firstName;
        }

        public string StateId { get; set; }
        public string CountyId { get; set; }
        public DateTime Registered { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
    }
}
