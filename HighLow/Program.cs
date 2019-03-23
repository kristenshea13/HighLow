using System;
using System.Collections.Generic;
using System.Linq;

namespace HighLow
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            string numbers = "1 -22 3 -4 55";

            List<string> numList = numbers.Split(' ').ToList();

            List<int> numParseList = new List<int>();

            foreach (var item in numList)
            {
                int numParse = int.Parse(item);
                numParseList.Add(numParse);
            }

            int highNum = numParseList.Max();

            var lowNum = numParseList.Min();

            string answer = highNum + " " + lowNum;

            Console.WriteLine($"{answer}");

            Console.ReadLine();
        }
    }
}