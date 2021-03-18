using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._03._21
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (;;) 
            //{
            //    Console.WriteLine("Введите строку");

            //    string line = Console.ReadLine();

            //    string[] terms = { "Exit", "Stop" };

            //    bool quit = false;

            //    foreach (string term in terms) 
            //    {
            //        if (String.Compare(line , term)==0) 
            //        {
            //            quit = true;
            //        }


            //    }

            //    if (quit == true) 
            //    {
            //        break;
            //    }
            //}

            //string a = "GG";

            //string b = "gg";

            //if (String.Compare(a, b) == 0)
            //{
            //    Console.WriteLine(" вы похожи");
            //}
            //else {

            //    Console.WriteLine("Nea");
            //}



            //string a = "objo";

            //string b = a.ToUpper();

            //Console.WriteLine(b);


            //string favoriteFood = "Burger";

            //foreach (char c in favoriteFood) 
            //{
            //    Console.Write(c);
            //}

            //bool isUppercase = true;

            //foreach (char c in favoriteFood) 
            //{
            //    if (!char.IsUpper(c)) 
            //    {
            //        Console.WriteLine(c);
            //    }

            //}

            //string favoriteFood = "BurgerKill";
            //if (favoriteFood.Contains("e")) 

            //{
            //    Console.WriteLine("Sucsec");
            //}

            //string a = "ggggfr";

            //if (string.IsNullOrEmpty(a)) 
            //{
            //    Console.WriteLine("Not");

            //}
            //else { Console.WriteLine("yes"); }


            //int b = Convert.ToInt32('f');
            //Console.WriteLine(b);




            string pass = "vovkodav";

            
           
            foreach (char c in pass) 
            {
                int a = Convert.ToInt32(c) + 5 ;
                char d = Convert.ToChar(a);
                Console.Write(a);
                Console.Write(d);

                int b = Convert.ToInt32(d) - 5;
                char r = Convert.ToChar(b);
                Console.Write(b);
                Console.Write(r);
                Console.WriteLine();
            }


        }
    }
}
