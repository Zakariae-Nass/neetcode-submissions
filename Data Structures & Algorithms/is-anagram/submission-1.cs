public class Solution {
    public bool IsAnagram(string s, string t) {
            if(s.Length != t.Length) return false;
            
            char[] sChars = s.ToCharArray();
            char[] tChars = t.ToCharArray();

            Array.Sort(sChars);
            Array.Sort(tChars);

            s = new string(sChars);
            t = new string(tChars);

            if(s != t) return false;
            
            return true;
    }
}
