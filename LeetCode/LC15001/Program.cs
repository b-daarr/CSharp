namespace LC01
{
    internal class Program
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; ++j)
                {
                    Console.WriteLine("\n i --> {0}\n j --> {1}", i, j);
                    Console.WriteLine("temp Result >>> " + (nums[j] + nums[i]));

                    if (i != j && nums[i] + nums[j] == target)
                    {
                        result.Add(i);
                        result.Add(j);
                        i = nums.Length;
                        j = i;
                    }
                }
            }

            foreach (int k in result)
            {
                Console.WriteLine("Result " + k);
            }
            return result.ToArray();
        }

        static void Main(string[] args)
        {
            TwoSum(new int[] { 6, 5, 7, 8, 9, 3 }, 10);
            Console.ReadKey();
        }
    }
}
