using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizz_Buzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int ctr = 0; ctr <= 100; ctr++)
            {
                if (ctr % 3 == 0)
                {
                    Console.Write("Fizz ");
                }
                else if (ctr % 5 == 0)
                {
                    Console.Write("Buzz ");
                }
                else if ( ctr % 15 == 0)
                {
                    Console.Write("Fizz Buzz ");
                }
                else;
                {
                    Console.Write(ctr );                 
                }
            }
            Console.ReadLine();
        }
    }
}
