using System;
using System.Collections.Generic;

namespace family_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>(){
                {"name", "Krista"},
                {"age", "42"}
            });

            myFamily.Add("brother", new Dictionary<string, string>(){
                {"name", "Cannon"},
                {"age", "7"}
            });

            myFamily.Add("mom", new Dictionary<string, string>(){
                {"name", "Jen"},
                {"age", "43"}
            });

            foreach(KeyValuePair<string, Dictionary<string, string>> familyMember in myFamily)
            {
                Console.WriteLine($"{familyMember.Value["name"]} is my {familyMember.Key} and is {familyMember.Value["age"]} years old.");
            }
        }
    }
}
