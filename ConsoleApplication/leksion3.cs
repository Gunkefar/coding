using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ConsoleApplication
{
    public class leksion3
    {
        public static void run()
        {
            Console.WriteLine("vælg dit første tal");
            string x =Console.ReadLine();
            int talX;
            if (int.TryParse(x, out talX) == false)
            {
                x = Console.ReadLine(); 
                Console.WriteLine("");
                if (int.TryParse(x, out talX) == false)
                {
                Console.WriteLine("");
                    
                }
                
            }
          

            Console.WriteLine("vil du pluse eller minuse, gange eller dividere");
            string komando = Console.ReadLine();
    
            Console.WriteLine("vælg dit sidste tal");
            string Z =Console.ReadLine();
            int talZ;
            if (int.TryParse(Z, out talZ) == false)
            {
                Z = Console.ReadLine();
                Console.WriteLine("");
                if (int.TryParse(Z, out talZ) == false)
                {
                Console.WriteLine("");

                }

            }

            
            
            Console.WriteLine("her er dit resultat");
            if (komando == "+")
            {
                Console.WriteLine(talX+talZ);
            }
            else if (komando == "-")
            {
                Console.WriteLine(talX-talZ);
            }
            if (komando == "*")
            {
                Console.WriteLine(talX*talZ);
            }
            else if (komando == "/")
            {
                Console.WriteLine(talX / talZ);

            }
        }
    }
}
