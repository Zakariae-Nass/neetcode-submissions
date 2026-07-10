public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] answers = new int[nums.Length];
        int lastProd = 1;
        for(int i = 0; i < nums.Length  - 1; i++){
            lastProd *= nums[i];
            answers[i + 1] = lastProd;
        }
        
        lastProd = 1;
        answers[0] = 1;
        
        for(int i = nums.Length - 1; i > 0; i--){
            lastProd *= nums[i];
            answers[i - 1] *= lastProd;
        }

        return answers;
    }
}
