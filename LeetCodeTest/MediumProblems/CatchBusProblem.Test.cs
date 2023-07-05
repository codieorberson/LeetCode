using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.MediumProblems;

namespace LeetCodeTest.MediumProblems
{
    [TestClass]
    public class CatchBusProblemTest
    {
        CatchBusProblem catchBusProblem;
        [TestInitialize]
        public void Setup()
        {
            catchBusProblem = new CatchBusProblem();
        }

        //[DataRow(new int[] { 3 }, new int[] { 2,4 }, 2, 3)]
        //[DataRow(new int[] { 10, 20, 30 }, new int[] { 4, 11, 13, 19, 21, 25, 26 }, 2, 20)]
        //[DataRow(new int[] { 20, 30, 10 }, new int[] { 19, 13, 26, 4, 25, 11, 21 }, 2, 20)]
        //[DataRow(new int[] { 10, 20 }, new int[] { 2, 17, 18, 19 }, 2, 16)]
        [DataRow(new int[] { 18, 8, 3, 12, 9, 2, 7, 13, 20, 5 }, new int[] { 13, 10, 8, 4, 12, 14, 18, 19, 5, 2, 30, 34 }, 1, 11)]
        [TestMethod]
        public void LatestTimeCatchTheBus(int[] buses, int[] passengers, int capacity, int expected)
        {
            int actual = catchBusProblem.LatestTimeCatchTheBus(buses, passengers, capacity);
            Assert.AreEqual(expected, actual);
        }
    }
}
