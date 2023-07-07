using System.Linq;
using static LeetCode.EasyProblems.Alliances;

namespace LeetCode.EasyProblems
{
    public class Alliances
    {
        public class PairedTeam
        {
            public List<string> teams;
        }

        public class Team
        {
            public string name;
        }

        public List<PairedTeam> alliances;
        public List<PairedTeam> associations;


        public void setAlliances(List<PairedTeam> pairedTeams)
        {
            alliances = pairedTeams.OrderBy(x => x.teams.Min()).ToList();
            List<PairedTeam> newAssociations = new();
            for(int i =0; i< alliances.Count; i++)
            {
                List<string> newTeam = new()
                {
                    alliances[i].teams[0],
                    alliances[i].teams[1]
                };

               
                List<PairedTeam> otherAlliances = alliances.GetRange(i + 1, alliances.Count - i-1);
                foreach(var otherAlliance in otherAlliances)
                {
                    if (otherAlliance.teams.Intersect(newTeam).Any())
                    {
                        newTeam.AddRange(otherAlliance.teams);
                    }
                }

                newAssociations.Add(new PairedTeam()
                {
                    teams = newTeam.Distinct().ToList(),
                });
            }
            associations = newAssociations;

        }

       

        public bool isAlliance(Team team1, Team team2)
        {
            return PairTeamsContains(team1, team2, alliances);
        }

        

        public bool isAssociated(Team team1, Team team2)
        {
            return PairTeamsContains(team1, team2, associations);
           
        }

        private bool PairTeamsContains(Team team1, Team team2, List<PairedTeam> groups) {
        
            foreach(PairedTeam group in groups)
            {
                if(group.teams.Contains(team1.name) && group.teams.Contains(team2.name)) return true;
            }
            return false;
        }

        
    }
}
