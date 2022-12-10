using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    class ReverseWord
    {
        public static void reverseword(String name)
        {
            string reverse = " ";
            char[] chars = name.ToCharArray();
            Console.WriteLine("Display the character");
            for (int i = 0; i < chars.Length; i++)
            {
                Console.WriteLine(chars[i] + " ");
            }
            for (int i = 0; i < chars.Length; i++)
            {
                reverse = chars[i] + reverse;
            }
            Console.WriteLine("Reverse word is " + reverse);
        }
    }
