using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] texts = Console.ReadLine().Split();

            for (var i = 0; i < texts.Length / 2; i++)
            {
                string firstText = texts[i];
                texts[i] = texts[texts.Length - i - 1];
                texts[texts.Length - i - 1] = firstText;
            }
            for (var i = texts.Length - 1; i >= 0; i--)
            {
                Console.Write(texts[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
