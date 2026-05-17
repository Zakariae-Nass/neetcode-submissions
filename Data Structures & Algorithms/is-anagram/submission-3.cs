public class Solution {
    public bool IsAnagram(string s, string t) {
            if(s.Length != t.Length) return false;
            
            Dictionary<char,  int>  content = new();

            for(int i = 0; i < s.Length; i++){
                if(! content.ContainsKey(s[i]))
                    content[s[i]] = 1;
                else
                    content[s[i]]++;

                if(! content.ContainsKey(t[i]))
                    content[t[i]] = 1;
                else
                    content[t[i]]++;
            }

            foreach(var key in content.Keys)
                if(!s.Contains(key) || content[key] % 2 != 0)
                    return false;
            return true;
    }
}