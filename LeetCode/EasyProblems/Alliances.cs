using System.Linq;
using static LeetCode.EasyProblems.Alliances;

namespace LeetCode.EasyProblems
{
    public class Alliances
    {
        public class PairedTeam
        {
            public List<string> teams;
            public int index;
        }

        public class Teams
        {
            public string name;
        }

        public List<PairedTeam> alliances;
        public Dictionary<string, string> parents;

        public Alliances(List<PairedTeam> pairedTeams)
        {
            parents = new Dictionary<string, string>();
            alliances = pairedTeams;

            int index = 0;
            foreach(var pairedTeam in pairedTeams)
            {
                alliances.Add(new PairedTeam()
                {
                    teams = pairedTeam.teams,
                    index = index
                });
                index++;
            }

            foreach (var pairedTeam in pairedTeams)
            {
                string parent = pairedTeam.teams[0];
                foreach (var team in pairedTeam.teams)
                {
                    if (!parents.ContainsKey(team))
                    {
                        parents[team] = parent;
                    }
                    else
                    {
                        parents[team] = Find(parent);
                    }
                }
            }
        }

       

        public bool isAlliance(Teams team1, Teams team2)
        {
            foreach(var alliance in alliances)
            {
                if(alliance.teams.Contains(team1.name) && alliance.teams.Contains(team2.name)) return true;
            }
            return false;
        }

        private string Find(string team)
        {
            if (parents[team] != team)
            {
                parents[team] = Find(parents[team]);
            }
            return parents[team];
        }

        public bool isAssociated(Teams team1, Teams team2)
        {
            if (!parents.ContainsKey(team1.name) || !parents.ContainsKey(team2.name))
            {
                return false;
            }
            return Find(team1.name) == Find(team2.name);
        }
    }
}
