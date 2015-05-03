using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
//The original post is here: http://www.reddit.com/r/dailyprogrammer/comments/2xoxum/20150302_challenge_204_easy_remembering_your_lines/
//The idea is to enter a bit of a line from macbeth and it shows the whole line 
//I took this idea and made it my own where it shows the full dialog of the line as opposed to just the one line also I made it so you can type anything not just the one example and get all instances of that word
//My Idea was to sort inside of the actual reading process so it would be sorted into dialog right off the bat
namespace Rememberyourlines
{

    class Program
    {
        //make a string to hold the lines until a blank
        public static List<string> tempString = new List<string> { };
        public static List<string> listMacBeth = new List<string>{};
        public static string userInput = string.Empty;
        static void Main(string[] args)
        {
            GetMacBethText();
            userInput = Console.ReadLine();
            LineRemember macBeth = new LineRemember(userInput);
            Console.ReadKey();
        }
        /// <summary>
        /// reads MacBeth.txt and sorts by dialog
        /// </summary>
        public static void GetMacBethText()
        {
            using (StreamReader reader = new StreamReader("MacBeth.txt"))
            {
                // Loop through the rest of the lines
                while (!reader.EndOfStream)
                {
                    //adds to a temp list of strings until the line is null or white space then adds to the listMacBeth and clears the temp list
                    if (string.IsNullOrWhiteSpace(reader.ReadLine()))
                    {
                        string line = string.Join("\n", tempString);
                        listMacBeth.Add(line);
                        tempString.Clear();
                    }
                    else
                    {
                        tempString.Add(reader.ReadLine());
                    }
                }
            }
        }
    }
    //make a class for line remembering
    public class LineRemember
    {
        //constructor that takes in write line to compare
        public LineRemember(string userStringInput)
        {
            List<string> lines = Program.listMacBeth.Where(x => x.ToLower().Contains(userStringInput.ToLower())).ToList();
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
