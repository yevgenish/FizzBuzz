using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            bool is_fizz;
            bool is_buzz;
            const string fizz = "Fizz";
            const string buzz = "Buzz";
            const string fizz_buzz = fizz + buzz;

            for (int i = 1; i <= 100; i++)
            {
                is_fizz = i % 3 == 0;
                is_buzz = i % 5 == 0;
     
                if (is_fizz && is_buzz)
                {
                    Console.WriteLine(fizz_buzz);
                }
                else if (is_fizz)
                {
                    Console.WriteLine(fizz);
                }
                else if (is_buzz)
                {
                    Console.WriteLine(buzz);
                }                
                else
                {
                    Console.WriteLine(i);
                }

            }

//v1
//             for (int i = 1; i <= 100; i++)
//             {
//                 is_fizz = i % 3 == 0;
//                 is_buzz = i % 5 == 0;

//                 if (is_fizz || is_buzz)
//                 {
//                     if (is_fizz && is_buzz)
//                     {
//                         Console.WriteLine(fizz_buzz);
//                     }
//                     else if (is_fizz)
//                     {
//                         Console.WriteLine(fizz);
//                     }
//                     else if (is_buzz)
//                     {
//                         Console.WriteLine(buzz);
//                     }
//                 }
//                 else
//                 {
//                     Console.WriteLine(i);
//                 }

//             }

            Console.ReadLine();
        }
    }
}
