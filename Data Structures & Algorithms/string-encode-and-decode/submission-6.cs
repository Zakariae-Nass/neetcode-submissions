public class Solution {

    public string Encode(IList<string> strs) {
        string encodedString = "";

        foreach(string str in strs){
            encodedString +=  str + $"{(char)10}" ;
        }
        Console.WriteLine(encodedString);
        return encodedString;
    }

    public List<string> Decode(string s) {
        List<string> decodedStrs = new List<string>();
        int end = 0;
        int start = 0;
        while(end < s.Length){
            if(s[end] != (char)10){
                end++;
                continue;
            }

            decodedStrs.Add(s.Substring(start, end - start));

            start = end += 1;
        }
        return decodedStrs;
   }
}
