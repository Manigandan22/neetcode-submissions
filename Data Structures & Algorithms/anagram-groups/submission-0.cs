public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string, List<string>>();
        foreach(var s in strs)
        {
            int[] freq = new int[26];
            foreach (char c in s)
            {
                freq[c - 'a']++;
            }
            string key = string.Join(",",freq);
            if (!dict.ContainsKey(key))
            {
                //group = new List<string>();
                dict[key] = new List<string>();
            }
            dict[key].Add(s);
        }
        return dict.Values.ToList<List<string>>();
    }
}