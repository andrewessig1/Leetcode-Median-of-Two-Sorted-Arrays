public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
            int lenCombined = nums1.Length + nums2.Length;
            int[] nums3 = new int[lenCombined];
            int i = 0;
            int y = 0;
            int z = 0;
            while(i + y < lenCombined)
            {
                if (i > nums1.Length - 1)
                {
                    nums3[z] = nums2[y];
                    y++;
                    z++;
                    continue;
                }
                else if (y > nums2.Length - 1)
                {
                    nums3[z] = nums1[i];
                    i++;
                    z++;
                    continue;
                }
                else if (i < nums1.Length && nums1[i] < nums2[y])
                {
                    nums3[z] = nums1[i];
                    i++;
                    z++;
                    continue;
                }
                else
                {
                    nums3[z] = nums2[y];
                    y++;
                    z++;
                    continue;
                }
            }
            if (lenCombined == 1)
            {
                return nums3[0];
            }
            else if( lenCombined == 2)
            {
                return (nums3[0] + nums3[1]) / 2.0;
            }
            else if (lenCombined % 2 == 1)
            {
                return nums3[lenCombined / 2];
            }
            else
            {
                return (nums3[(lenCombined-1) / 2 + 1] + nums3[(lenCombined-1) / 2]) / 2.0;
            }
    }
}
