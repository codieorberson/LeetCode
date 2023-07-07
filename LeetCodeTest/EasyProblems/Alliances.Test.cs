using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.EasyProblems;
using static LeetCode.EasyProblems.Alliances;

namespace LeetCodeTest.EasyProblems
{
    [TestClass]
    public class AlliancesTest
    {

        Alliances alliances;
        [TestInitialize]
        public void Setup()
        {
            alliances = new Alliances();
        }

        [TestMethod]
        [DataRow("A", "B", true)]
        [DataRow("B", "A", true)]
        [DataRow("A", "C", false)]
        [DataRow("A", "D", false)]
        [DataRow("C", "F", false)]
        public void isAlliance_Returns_Correct_Response(string firstTeam, string secondTeam, bool expected)
        {
            List<PairedTeam> pairedTeam = new List<PairedTeam>()
            {
                new PairedTeam()
                {
                    teams = new List<string>(){"A", "B" }
                },
                new PairedTeam()
                {
                    teams = new List<string>(){"B", "C" }
                },
                new PairedTeam()
                {
                    teams = new List<string>(){"C", "D" }
                }
            };

            alliances.setAlliances(pairedTeam);

            Team team1 = new Team() { name = firstTeam };
            Team team2 = new Team() { name= secondTeam };
            bool actual = alliances.isAlliance(team1, team2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("A", "C", true)]
        [DataRow("A", "D", false)]
        [DataRow("A", "B", true)]
        [DataRow("X", "L", true)]
        [DataRow("Y", "A", false)]
        [DataRow("E", "D", false)]
        public void isAssociated_Returns_Correct_Response(string firstTeam, string secondTeam, bool expected)
        {
            List<PairedTeam> pairedTeam = new List<PairedTeam>()
            {
                new PairedTeam()
                {
                    teams = new List<string>(){"A", "B" }
                },
                new PairedTeam()
                {
                    teams = new List<string>(){"A", "E" }
                },
                new PairedTeam()
                {
                    teams = new List<string>(){"B", "C" }
                },
                new PairedTeam()
                {
                    teams = new List<string>(){"D", "F" }
                },
                new PairedTeam()
                {
                    teams = new List<string>(){"X", "Y" }
                }
                ,
                new PairedTeam()
                {
                    teams = new List<string>(){"T", "Y" }
                },

                new PairedTeam()
                {
                    teams = new List<string>(){"L", "T" }
                },
            };

            alliances.setAlliances(pairedTeam);

            Team team1 = new Team() { name = firstTeam };
            Team team2 = new Team() { name = secondTeam };
            bool actual = alliances.isAssociated(team1, team2);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow("A", "C", true)]
        [DataRow("A", "D", true)]
        [DataRow("C", "B", true)]
       
        public void isAssociated_Returns_Correct_Response_Case2(string firstTeam, string secondTeam, bool expected)
        {
            List<PairedTeam> pairedTeam = new List<PairedTeam>()
            {
                new PairedTeam()
                {
                    teams = new List<string>(){"A", "B" }
                },
                new PairedTeam()
                {
                    teams = new List<string>(){"C", "D" }
                },
                new PairedTeam()
                {
                    teams = new List<string>(){"B", "C" }
                }
            };

            alliances.setAlliances(pairedTeam);

            Team team1 = new Team() { name = firstTeam };
            Team team2 = new Team() { name = secondTeam };
            bool actual = alliances.isAssociated(team1, team2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("A", "D", true)]
        [DataRow("A", "B", true)]
        [DataRow("C", "D", true)]

        public void isAssociated_Returns_Correct_Response_Case3(string firstTeam, string secondTeam, bool expected)
        {
            List<PairedTeam> pairedTeam = new List<PairedTeam>()
            {
                new PairedTeam()
                {
                    teams = new List<string>(){"B", "A" }
                },
                new PairedTeam()
                {
                    teams = new List<string>(){"C", "B" }
                },
                new PairedTeam()
                {
                    teams = new List<string>(){"D", "C" }
                }
            };

            alliances.setAlliances(pairedTeam);

            Team team1 = new Team() { name = firstTeam };
            Team team2 = new Team() { name = secondTeam };
            bool actual = alliances.isAssociated(team1, team2);
            Assert.AreEqual(expected, actual);
        }
    }
}
