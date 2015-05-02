using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
//The original post is here: http://www.reddit.com/r/dailyprogrammer/comments/2xoxum/20150302_challenge_204_easy_remembering_your_lines/
//The idea is to enter a bit of a line from macbeth and it shows the whole line 
//I will be placing all the lines in a seperate region at the bottom
namespace Rememberyourlines
{

    class Program
    {
        //make global string for entire .txt
        public static List<string> listMacBeth = new List<string>{};
        static void Main(string[] args)
        {
            GetMacBethText();
            Console.ReadKey();
        }
        public static void GetMacBethText()
        {
            using (StreamReader reader = new StreamReader("MacBeth.txt"))
            {
                // Loop through the rest of the lines
                while (!reader.EndOfStream)
                {
                    listMacBeth.Add(reader.ReadLine());
                }
            }
            string stringMacBeth = string.Join("\n", listMacBeth);
            string[] linesMacBeth = stringMacBeth.Split('\n');
            
        }
    }
    //make a class for line remembering
    public class LineRemember
    {
        
        //constructor that takes in write line as 

    }
}
