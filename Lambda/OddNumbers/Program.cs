namespace OddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string result = " ";

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    result = "False";
                }
                else
                {
                    result = "True";
                }
                Console.WriteLine($"{nums[i]} is odd - {result}");
            }
        }
    }
}