public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
    Dictionary<int, int> seenlist = new Dictionary<int,int>{};
    int diff =0;   
    int [] result = new int[2];
    for (int i=0;i<nums.Length;i++)
    {
        seenlist[nums[i]] = i;
    }
  
    //Console.WriteLine(seenlist);
    for(int i=0;i<nums.Length;i++)
    {   
         diff = 0;
         
        diff = target - nums[i];
       
        if(seenlist.ContainsKey(diff))
        {
            if(seenlist[diff] != i)
            {
            
            result[0] = i;
            result[1] = seenlist[diff];
            break;    
            }      
        }
       
    }   
    
    return result;
    }
}
