using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Indtast x");
            string x =Console.ReadLine();
            int talX;
            if (int.TryParse(x, out talX) == false)
            {
                x = Console.ReadLine(); 
                Console.WriteLine("det forkert jonny");
                if (int.TryParse(x, out talX) == false)
                {
                Console.WriteLine("det forkert igen jonny");
                    
                }
                
            }
          

            Console.WriteLine("Indtast y");
            string y =Console.ReadLine();
            int talY;
            if (int.TryParse(y, out talY) == false)
            {
                y = Console.ReadLine();
                Console.WriteLine("det forkert jonny");
                if (int.TryParse(y, out talY) == false)
             {
                Console.WriteLine("det forkert igen jonny");

             }
            
            }

            
            
            Console.WriteLine("x + y er");
            Console.WriteLine(talX+talY);

        }
    }
}
