using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a regular expression to match a valid phone number from Sofia. After you find all valid phones, print them on the console, separated by a comma and a space ", ".
            //\+[3-9]{3}[ \-][2][ \-][0-9]{3}[ \-][0-9]{4}
            //\+[3-9]{3}(?<separator>[ \-])[2]\k<separator>[0-9]{3}\k<separator>[0-9]{4}

            MatchCollection matches = Regex.Matches(Console.ReadLine(), @"\+[3-9]{3}(?<separator>[-| ])[2]\k<separator>[0-9]{3}\k<separator>[0-9]{4}\b");
            List<string> validNumber = new List<string>();

            foreach  (Match match in matches)
            {
                validNumber.Add(match.ToString());
                
            }
            Console.Write(String.Join(", ", validNumber));
        }
    }
}
