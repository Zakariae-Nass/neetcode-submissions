public class Solution {

    public string Encode(IList<string> strs) {
        string encodedString = "";

        foreach(string str in strs){
            encodedString += $"{str.Length}#" + str ;
        }
        Console.WriteLine(encodedString);
        return encodedString;
    }

    public List<string> Decode(string s) {
        List<string> decodedStrs = new List<string>();
        int car = 0;
        int nextLength = 0;
        while(car < s.Length){
            if(s[car] != '#'){
                car++;
                continue;
            }

            string length = s.Substring(nextLength, car - nextLength);

            if(!Char.IsDigit(length[0])){
                car++;
                continue;
            }

            Console.WriteLine($"[{nextLength},{car - nextLength}]");
            int strLength = int.Parse(length);

            Console.WriteLine($"[{car + 1},{strLength}]");
            decodedStrs.Add(s.Substring(car + 1, strLength));

            nextLength = car += strLength + 1;
        }
        return decodedStrs;
   }
}
