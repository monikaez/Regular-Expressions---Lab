using System;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	A valid full name has the following characteristics:
            //            o It consists of two words.
            //o Each word starts with a capital letter.
            //o After the first letter, it only contains lowercase letters afterward.
            //o Each of the two words should be at least two letters long.
            //o The two words are separated by a single space.

            string input = Console.ReadLine();
            Regex regex = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+");

            MatchCollection matches = regex.Matches(input);
            foreach (Match match in matches)
            {
                Console.Write(match.Value + " ");

            }
        }
    }
}
