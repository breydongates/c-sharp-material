using System;
using System.Collections.Generic;
using System.Text;

namespace VotersLoad.Models
{
    public class Election
    {
        public int Id { get; set; }
        public string StateId { get; set; }
        public int ElectionYear { get; set; }
        public int ElectionMonth { get; set; }
        public string ElectionType { get; set; }
        public string BallotType { get; set; }
    }
}
