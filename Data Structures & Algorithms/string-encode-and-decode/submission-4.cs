public class Solution {

    public string Encode(IList<string> strs) {
        
        String ret = String.Empty;

        foreach(string s in strs)
        {
            ret += $"{(char)s.Length}{s}";
        }

        return ret;
    }

    public List<string> Decode(string s) {
        int pos = 0;
        List<string> ret = new List<string>();

        while(pos < s.Length)
        {
            int len_val = (int)s[pos];
            pos++;
            ret.Add(s.Substring(pos, len_val));
            pos += len_val;
        }

        return ret;
   }
}
