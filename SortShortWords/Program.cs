using System.Text.RegularExpressions;

namespace SortShortWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] words = Regex.Split(input, @"[.,:;()\[\]""'\\/!? ]+");
            var shortWords = words
                .Where(word => word.Length < 5 && word.Length > 0) 
                .Select(word => word.ToLower()) 
                .Distinct() 
                .OrderBy(word => word); 
            foreach (var word in shortWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}
