internal class Program
{
    public class ListNode {
     public int val;
     public ListNode next;
     public ListNode(int val=0, ListNode next=null) {
         this.val = val;
         this.next = next;
     }

     public ListNode Add(int v){
        next = new ListNode(v);
        return this.next;
     }
 }

 private static ListNode Adds(int[] vals)
 {
    ListNode root = new ListNode(vals[0]);
    ListNode s = root;
    for (int i = 1; i < vals.Length; i++)
    {
        s = s.Add(vals[i]);
    }
    return root;
 }
    private static void Main(string[] args)
    {
        ListNode l1 = Adds(new int[] {2,4,3});
        ListNode l2 = Adds(new int[] {5,6,4});
        ListNode r = AddTwoNumbers(l1, l2);
        while (r?.val != null)
        {
            Console.WriteLine(r.val);
            r = r.next;
        }
    }

    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        int ending = 0;

        int Sum(int? v1, int? v2) {
            v1 ??= 0;
            v2 ??= 0;
            int? sum = v1 + v2 + ending;
            ending = sum >=10 ? 1 : 0;
            return sum.Value % 10; 
        }

        ListNode resultRoot = new ListNode(Sum(l1.val, l2.val));
        ListNode result = resultRoot;
        while(l1?.next != null || l2.next != null || ending == 0)    {
            l1 = l1?.next;
            l2 = l2?.next;
            int sum = Sum(l1?.val, l2?.val);
            result.next = new ListNode(sum);
            result = result?.next;
        }
        return resultRoot;
    }
}