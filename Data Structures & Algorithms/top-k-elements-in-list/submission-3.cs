public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> frequences = new();
        List<int> returns = new();
        
        foreach(int num in nums){
            frequences[num] = frequences.GetValueOrDefault(num, 0) + 1;
        }

        var sorted = frequences.OrderByDescending(x => x.Value);

        foreach(var item in sorted){
            if(k == 0) break;
                returns.Add(item.Key);
                k--;
        }

        return returns.ToArray();
    }
}
