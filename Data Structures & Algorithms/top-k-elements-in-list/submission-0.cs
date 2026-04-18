public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        int [] result = new int [k];
        var dict = new Dictionary <int,int>();
        for(int i = 0; i<nums.Length;i++)
        {
            if(dict.ContainsKey(nums[i]))
            {
                dict[nums[i]] = dict[nums[i]] + 1;
            }
            else
            {
                dict[nums[i]] = 1;
            }
        }
        var q = new PriorityQueue<int,int>();
        foreach(var count in dict)
        {
            q.Enqueue(count.Key,count.Value);
            if(q.Count > k)
            {
                q.Dequeue();
            }
        }
       for(int i=0;i<k;i++)
       {
            result[i]= q.Dequeue();
       }
       return result;
    }
}
