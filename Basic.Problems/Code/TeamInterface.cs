using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Problems.Code
{
    public class Team
    {
        public string teamName { get; set; }
        public int noOfPlayers { get; set; }

        public Team(string teamName, int noOfPlayers)
        {
            this.teamName = teamName;
            this.noOfPlayers = noOfPlayers;
        }

        public void AddPlayer(int count) 
        {
            noOfPlayers+= count;
        }
        public bool RemovePlayer(int count)
        {
            if (noOfPlayers - count < 0) return false;

            noOfPlayers = noOfPlayers - count;
            return true;
        }
    }

    public class Subteam : Team
    {
        public Subteam(string teamName, int noOfPlayers) : base(teamName, noOfPlayers)
        {

        }

        public void ChangeTeamName(string name) 
        {
            teamName = name;
        }


    }
}
