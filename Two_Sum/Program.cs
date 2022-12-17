using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 11, 15,18,24,2, 7 };
            int target = 9;


            foreach (var item in TwoSum(nums,target))
            {
                Console.WriteLine(item);
            }
            
            

            Console.ReadKey();
        }
        public static int[] TwoSum(int[] nums, int target)
        {

            int[] arr = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        arr[0] = i;
                        arr[1] = j;
                    }
                }
            }
            return arr;
        }
    }
}
