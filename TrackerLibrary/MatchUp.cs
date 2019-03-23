using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents one match in the tournament 
    /// </summary>
    public class MatchUp
    {
        /// <summary>
        /// The set of teams that were involved in this match.
        /// </summary>
        public List<MatchUpEntry> Entries { get; set; } = new List<MatchUpEntry>();
        /// <summary>
        /// The winner of the match.
        /// </summary>
        public Team Winner { get; set; }
        /// <summary>
        /// Which round this match is a part of 
        /// </summary>
        public int MatchUpRounds { get; set; }


    }
}
