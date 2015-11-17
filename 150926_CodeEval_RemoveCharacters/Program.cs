using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _150926_CodeEval_RemoveCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program which removes specific characters from a string.            
            //The first argument is a path to a file. The file contains the source strings and the characters that need to be scrubbed. 
            //Each source string and characters you need to scrub are delimited by comma.
            
            /*Sample code to read in test cases:
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            if (null == line)
                continue;
            // do something with line
        }
    }
}*/
            //sample input
            string line = "how are you, abc";

            //let's try with a list
            string[] lineArr = line.Split(',');
            string textPart = lineArr[0];
            string letters = (lineArr[1]).Trim();

            List<char> textList = new List<char>();
            foreach (char letter in textPart)
            {
                textList.Add(letter);                
            }

            int c = 0;
            while (c < textList.Count)
                {
                    for (int i = 0; i < letters.Length; i++)
                    {
                        textList.Remove(letters[i]);
                    }
                c++;
                }
            
            foreach (char letter in textList)
            {
                Console.Write(letter);
            }
            Console.WriteLine();              
        }
    }
}
