public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> frequences = new();
        int[] returns = new int[k];

        foreach(int num in nums){
            frequences[num] = frequences.GetValueOrDefault(num, 0) + 1;
        }

        List<int>[] buckets = new List<int>[nums.Length + 1];
        for(int i = 0; i < buckets.Length; i++)
            buckets[i] = new List<int>();
        
        foreach(int key in frequences.Keys){
            buckets[frequences[key]].Add(key);
        }

        int index = 0;
        for(int i = buckets.Length - 1; i > 0 && index < k; i--){
            foreach(int val in buckets[i]){
                returns[index++] = val;
                if(index == k)
                    return returns;
            }
        }
        return returns;
    }
}
