﻿namespace BESTword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split()
                .ToArray();

            var bestWords = 
                input.Where(word => word.Contains("est"))
                .Select(word => word.ToUpper())
                .ToArray();

            string first = bestWords.FirstOrDefault(word => word.Contains("B"));
            Console.WriteLine($"First best word: {first}");

            string last = bestWords.LastOrDefault(word => word.Contains("B"));
            Console.WriteLine($"Last best word: {last}");
        }
    }
}