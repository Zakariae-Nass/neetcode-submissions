public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int, int> visited = new();

        for(int i = 0; i < nums.Length; i++){
            int current = nums[i];

            if(visited.ContainsKey(current))
                return true;
            
            visited.Add(current, i);
        }

        return false;
    }
}