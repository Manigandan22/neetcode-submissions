public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        
        int l=0,r=numbers.Length -1;
        while (l<r)
        {
            int current = numbers[l]+numbers[r];
            if(current == target)
            {
                return new int[]{l+1,r+1};
            }
            else if(current > target)
            {
                r--;
            }
            else if(current < target)
            {
                l++;
            }
           
        }
        return new int[0];      
        
    }
}
