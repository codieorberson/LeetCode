using LeetCode.Models;

namespace LeetCode.MediumProblems
{
    public class AddTwoNumbersProblem
    {
        public AddTwoNumbersProblem() { }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2, int carry = 0) 
        {
            if (l1 == null && l2 == null && carry == 0) return null;

            int sum = (l1?.val ?? 0) + (l2?.val ?? 0) + carry;
            carry = sum / 10;
            sum = sum % 10;


            return new ListNode() { val = sum, next = AddTwoNumbers(l1?.next, l2?.next, carry)};
        }

        public ListNode AddTwoNumbers2(ListNode l1, ListNode l2)
        {
            ListNode parentNode = new ListNode();
            ListNode currentNode = parentNode;

            int carry = 0;
            while(l1 != null || l2 != null)
            {
                int sum = carry;
                if(l1 != null) { 
                    sum += l1.val;
                    l1 = l1.next;
                }

                if(l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }
                carry = sum / 10;
                sum = sum % 10;

                currentNode.val = sum;

                if(carry != 0 && l1 == null && l2 == null)
                {
                    currentNode.next = new ListNode(carry);
                    break;
                }
                if (carry == 0 && l1 == null && l2 == null)
                {
                    break;
                }
                currentNode.next = new ListNode();
                currentNode = currentNode.next;
            }
            return parentNode;
        }
    }
}
