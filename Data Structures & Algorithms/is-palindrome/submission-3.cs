public class Solution {
    public bool IsPalindrome(string s) {
        if(s.Length == 1) return true;

        s = s.Replace(" ", "");

        int start = 0;
        int end = s.Length - 1;
        
        while(start <= end){
            while(!char.IsLetterOrDigit(s[start]) && start < end)
                start++;

            while(!char.IsLetterOrDigit(s[end]) && end > start)
                end--;

            if(char.ToLower(s[start]) != char.ToLower(s[end]))
                return false;
            
            start++;
            end--;
        }
        return true;
    }
}