using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ConsoleApplication
{
    public class leksion4
    {
        public static void run()
        {
           var calculator = new Calculator();
           
           string operation = "+";
           do 
           {

                Console.WriteLine("intast et tal");
                string numberText = Console.ReadLine();
                int number = int.Parse(numberText);

                 
                if (operation == "+")
                {
                    calculator.Add(number);
                }
                else if (operation == "-")
                {
                    calculator.Minus(number);
                }
                else if (operation == "*")
                {
                   calculator.Multiply(number); 
                }
                else if (operation == "/")
                {
                    calculator.Divide(number);
                }
                else if (operation == "=")
                {
                }
                else
                {
                    
                }
                 Console.WriteLine("intast +, -, *, /, =");
                 operation = Console.ReadLine();
                 if (operation != "+" || operation !="-" || operation !="*" || operation !="/")
                 {
                    Console.WriteLine("ugyldigt tegn");
                 }

           }
            while(operation != "=");


           int resultat = calculator.Resultat();

           Console.Write("resultat: ");
           Console.WriteLine(resultat);
        }
    }
}
