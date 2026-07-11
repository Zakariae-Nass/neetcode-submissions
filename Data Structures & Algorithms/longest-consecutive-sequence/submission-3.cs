public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length == 0) return 0;
        int[] seqTable = new int[nums.Length];
        Array.Clear(seqTable, 0, seqTable.Length);
        int currentSeq = 0;

        Array.Sort(nums);

        for(int i = 1; i < nums.Length; i++){
            if(nums[i] - nums[i - 1] == 1)
                seqTable[currentSeq]++;
            else if(nums[i] - nums[i - 1] == 0)
                continue;
            else
                currentSeq++;
        }

        return seqTable.Max() + 1;
    }
}
