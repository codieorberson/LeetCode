using LeetCode.MediumProblems;
using LeetCode.Models;

namespace LeetCodeTest.MediumProblems
{
    [TestClass]
    public class AddTwoNumbersProblemTest
    {
        AddTwoNumbersProblem addTwoNumberProblem;

        [TestInitialize]
        public void Setup()
        {
            addTwoNumberProblem = new AddTwoNumbersProblem();
        }

        [TestMethod]
        public void AddTwoNumbersCase1()
        {
            int[] firstNodeNum = new int[] { 2, 4, 3 };
            int[] secondNodeNum = new int[] { 5, 6, 4 };
            int[] expectedNodeNum = new int[] { 7, 0, 8 };

            ListNode firstNode = GenerateNode(firstNodeNum);
            ListNode secondNode = GenerateNode(secondNodeNum);
            ListNode expected = GenerateNode(expectedNodeNum);

            ListNode actual = addTwoNumberProblem.AddTwoNumbers(firstNode, secondNode);
            
            Assert.IsTrue(NodesEqual(expected, actual));

        }

        [TestMethod]
        public void AddTwoNumbersCase2()
        {
            int[] firstNodeNum = new int[] { 9, 9, 9, 9, 9, 9, 9 };
            int[] secondNodeNum = new int[] { 9, 9, 9, 9 };
            int[] expectedNodeNum = new int[] { 8, 9, 9, 9, 0, 0, 0, 1 };

            ListNode firstNode = GenerateNode(firstNodeNum);
            ListNode secondNode = GenerateNode(secondNodeNum);
            ListNode expected = GenerateNode(expectedNodeNum);

            ListNode actual = addTwoNumberProblem.AddTwoNumbers(firstNode, secondNode);

            Assert.IsTrue(NodesEqual(expected, actual));

        }

        [TestMethod]
        public void AddTwoNumbers2Case1()
        {
            int[] firstNodeNum = new int[] { 2, 4, 3 };
            int[] secondNodeNum = new int[] { 5, 6, 4 };
            int[] expectedNodeNum = new int[] { 7, 0, 8 };

            ListNode firstNode = GenerateNode(firstNodeNum);
            ListNode secondNode = GenerateNode(secondNodeNum);
            ListNode expected = GenerateNode(expectedNodeNum);

            ListNode actual = addTwoNumberProblem.AddTwoNumbers2(firstNode, secondNode);

            Assert.IsTrue(NodesEqual(expected, actual));

        }

        [TestMethod]
        public void AddTwoNumbers2Case2()
        {
            int[] firstNodeNum = new int[] { 9, 9, 9, 9, 9, 9, 9 };
            int[] secondNodeNum = new int[] { 9, 9, 9, 9 };
            int[] expectedNodeNum = new int[] { 8, 9, 9, 9, 0, 0, 0, 1 };

            ListNode firstNode = GenerateNode(firstNodeNum);
            ListNode secondNode = GenerateNode(secondNodeNum);
            ListNode expected = GenerateNode(expectedNodeNum);

            ListNode actual = addTwoNumberProblem.AddTwoNumbers2(firstNode, secondNode);

            Assert.IsTrue(NodesEqual(expected, actual));

        }

        public bool NodesEqual(ListNode n1,  ListNode n2)
        {
            while (n1 != null || n2 != null)
            {
                if (n1?.val != n2?.val) return false;
                n1 = n1.next;
                n2 = n2.next;
            }
            return true;
        }

        public ListNode GenerateNode(int[] numbers)
        {
            ListNode parentNode = new ListNode();
            ListNode node = parentNode;
            for (int x = 0; x < numbers.Length; x++)
            {
                if (x == numbers.Length - 1)
                {
                    node.val = numbers[x];
                    break;
                }
                node.val = numbers[x];
                node.next = new ListNode();
                node = node.next;
            }
           
            return parentNode;
        }
    }
}
