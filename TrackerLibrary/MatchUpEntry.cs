using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{

    /// <summary>
    ///  Represents one team in the matchup
    /// </summary>
    public class MatchUpEntry
    {
        /// <summary>
        ///  Represents one team in the matchup
        /// </summary>
        public Team TeamCompeting { get; set; }
        /// <summary>
        /// Represent score for this particular team
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Represents the matchuo that this team came 
        /// from as the winner 
        /// </summary>
        public MatchUp ParentMatchUp{ get; set; }

    }
}
