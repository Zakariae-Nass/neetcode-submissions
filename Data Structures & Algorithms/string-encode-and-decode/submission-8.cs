public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();

        foreach (string str in strs)
        {
            sb.Append((char)str.Length);
            sb.Append(str);
        }

        return sb.ToString();
    }

    public List<string> Decode(string s) {
        List<string> decodedStrs = new List<string>();
        int start = 0;
        while(start < s.Length){
            int str_len = (int) s[start];
            start++;

            decodedStrs.Add(s.Substring(start, str_len));

            start += str_len;
        }
        return decodedStrs;
   }
}
