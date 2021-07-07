using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWord
{
    class Worded
    {

        public void Reverse(string word)
        {
            string newWord = "";
            for (int i = 0; i < word.Length; i++)
            {
                var x = word.Length - 1;
                var temp = x - i;
                newWord += word[temp];
            }
            Console.WriteLine("The new Reverse Word: \"{0}\"", newWord);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var worded = new Worded();

            Console.WriteLine("Enter a Word: ");
            var word1 = Console.ReadLine();

            worded.Reverse(word1);
            Console.Read();
        }
    }
}
