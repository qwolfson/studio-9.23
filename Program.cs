using System;
using System.Collections.Generic;

namespace _9._23_Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> characterCount = new Dictionary<char, int>();
            string str;
            //string str = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            
            Console.WriteLine("String: ");
            string input = Console.ReadLine();
            str = input;
            
            foreach (char c in str)
            {
                if (!(characterCount.ContainsKey(c)))
                {
                    characterCount.Add(c, 1);
                }
                else
                {
                    characterCount[c] += 1;
                }
            }
            foreach (KeyValuePair<char, int> character in characterCount)
            {
                Console.WriteLine(character.Key + " : " + character.Value);
            }
            
        }
        
    }
}
