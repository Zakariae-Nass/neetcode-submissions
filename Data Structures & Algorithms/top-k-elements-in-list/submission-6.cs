public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> frequences = new();
        List<int> returns = new();

        foreach(int num in nums){
            frequences[num] = frequences.GetValueOrDefault(num, 0) + 1;
        }

        List<int>[] buckets = new List<int>[nums.Length + 1];
        for(int i = 0; i < buckets.Length; i++)
            buckets[i] = new List<int>();
        
        foreach(int key in frequences.Keys){
            buckets[frequences[key]].Add(key);
        }

        for(int i = buckets.Length - 1; i > 0; i--){
            if(k == 0) break;
            if(buckets[i] == null) continue;

            foreach(int val in buckets[i]){
                returns.Add(val);
                k--;
            }
        }
        return returns.ToArray();
    }
}
