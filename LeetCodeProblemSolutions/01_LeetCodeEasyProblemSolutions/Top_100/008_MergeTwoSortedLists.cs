namespace _01_LeetCodeEasyProblemSolutions.Top_100;

internal class _008_MergeTwoSortedLists
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        // 1 3 4 5
        // 2 4 5 6
        // 1 2 3 4 4 5 5 6

        ListNode sorted1 = new ListNode();
        ListNode sorted2 = new ListNode();
        int countOfElements = 0;

        

        while (list1.next is not null)
        {
            sorted1.val = list1.val;
            sorted1 = list1.next;
            countOfElements++;
        }
        while (list1.next is not null)
        {
            sorted2.val = list2.val;
            sorted2 = list2.next;
            countOfElements++;
        }

        ListNode mergedList = new ListNode();
        int counter = 0;
        while (counter < countOfElements)
        {
            // if the test fails we should check for null
            if (sorted1.val <= sorted2.val)
            {
                mergedList.val = sorted1.val;
                mergedList = sorted1.next;
            }
            else
            {
                mergedList.val = sorted2.val;
                mergedList = sorted2.next;
            }
        }
        return mergedList;
    }
    
}

internal class SecondVersion
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        var nums = new List<int>();
        while (list1.next is not null)
        {
            nums.Add(list1.val);
            list1 = list1.next;
        }
        while (list2.next is not null)
        {
            nums.Add(list2.val);
            list2 = list2.next;
        }

        nums.Sort();
        ListNode listNode = new ListNode();
        foreach (var num in nums)
        {
            listNode.next = new ListNode(num);
            listNode = listNode.next;
        }

        return listNode;
    }

}

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
