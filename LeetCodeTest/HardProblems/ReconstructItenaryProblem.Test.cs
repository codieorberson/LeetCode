using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.HardProblems;

namespace LeetCodeTest.HardProblems
{
    [TestClass]
    public class ReconstructItenaryProblemTest
    {

        ReconstructItenaryProblem reconstructItenaryProblem;

        [TestInitialize]
        public void Setup()
        {
            reconstructItenaryProblem = new ReconstructItenaryProblem();
        }


        [TestMethod]
        public void ReconstructIternaryCase1()
        {
            IList<IList<string>> itenary = new List<IList<string>>()
            {
                new List<string>(){"MUC", "LHR"},
                new List<string>(){"JFK", "MUC"},
                new List<string>(){"SFO", "SJC"},
                new List<string>(){"LHR", "SFO"}
            };

            IList<string> expected = new List<string>()
            {
                "JFK","MUC","LHR","SFO","SJC"
            };
            
            var actual = reconstructItenaryProblem.FindItinerary(itenary);

            Assert.IsTrue(actual.SequenceEqual(expected));
        }

        [TestMethod]
        public void ReconstructIternaryCase2()
        {
            IList<IList<string>> itenary = new List<IList<string>>()
            {
                new List<string>(){"JFK","SFO"},
                new List<string>(){"JFK","ATL"},
                new List<string>(){"SFO","ATL"},
                new List<string>(){ "ATL", "JFK" },
                new List<string>(){ "ATL", "SFO" }
            };

            IList<string> expected = new List<string>()
            {
                "JFK","ATL","JFK","SFO","ATL","SFO"
            };

            var actual = reconstructItenaryProblem.FindItinerary(itenary);

            Assert.IsTrue(actual.SequenceEqual(expected));
        }

        [TestMethod]
        public void ReconstructIternaryCase3()
        {
            IList<IList<string>> itenary = new List<IList<string>>()
            {
                new List<string>(){"JFK","KUL"},
                new List<string>(){"JFK","NRT"},
                new List<string>(){ "NRT", "JFK" }
            };

            IList<string> expected = new List<string>()
            {
                "JFK","NRT","JFK","KUL"
            };

            var actual = reconstructItenaryProblem.FindItinerary(itenary);

            Assert.IsTrue(actual.SequenceEqual(expected));
        }
    }
}
