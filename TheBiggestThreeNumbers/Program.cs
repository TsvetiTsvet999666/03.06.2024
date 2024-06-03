namespace TheBiggestThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split()
            .Select(int.Parse)
            .ToList();
            var sortedNums = nums.OrderByDescending(x => x);
            var largest3Nums = sortedNums.Take(3);
            Console.WriteLine(string.Join(" ", largest3Nums));
        }
    }
}
