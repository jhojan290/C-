
using Microsoft.VisualBasic;

int[] twoSum(int[] nums, int target)
{
    for ( int i = 0; i < nums.Length; i++)
    {
        for (int j = i+1; j < nums.Length; j++)
        {
            if (target == nums[i] + nums[j])
            {
                int[] array = new int[2];

                array[0] = nums[i];

                array[1] = nums[j];

                return array;
            }
        }
    }
    int[] array2 = new int[0];
    return array2;
}

int[] array3 = new int[4];
array3[0] = 2;
array3[1] = 7;
array3[2] = 11;
array3[3] = 15;


var result = twoSum(array3, 26);
foreach (var i in result)
{
    Console.WriteLine(i);   
}




















