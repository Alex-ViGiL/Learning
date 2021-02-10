using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleReadKey
{
    class Program
    {
        static void Main(string[] args)
        {

            ConsoleKeyInfo key = Console.ReadKey();
            char ch = key.KeyChar;



            Console.WriteLine("Symbol = "+ch);
            

            Console.ReadKey();

        }
    }
}
