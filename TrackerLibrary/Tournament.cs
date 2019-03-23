using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    class Tournament
    {
        public string TournamentName { get; set; }
        public decimal EntryFee { get; set; }
        public List<Team> EnteredTeams { get; set; } = new List<Team>();
        public List<Prize> Prizes { get; set; } = new List<Prize>();
        public List<List<MatchUp>> Rounds { get; set; } = new List<List<MatchUp>>();
    }
}
