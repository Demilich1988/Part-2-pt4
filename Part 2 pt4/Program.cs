using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2_pt4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Chapter 11 Switches 
             */

            //Variables need
            int inputA;
            int inputB;
            String userA;
            String userB;
            String userC;
            char inputC;

            //Ask user for inputs
            Console.Write("First number:");
            userA = Console.ReadLine();
            inputA = Convert.ToInt32(userA);

            Console.Write("Second number:");
            userB = Console.ReadLine();
            inputB = Convert.ToInt32(userB);

            Console.Write("Symbol:");
            userC = Console.ReadLine();
            inputC = Convert.ToChar(userC);


            //Create switch statement that then does the math based on the symbol the user entered
            switch (inputC)
            {
                
                case '+':
                    Console.WriteLine(inputA + inputB);
                    break;
                case '-':
                    Console.WriteLine(inputA - inputB);
                    break;
                case '*':
                    Console.WriteLine(inputA * inputB);
                    break;
                case '/':
                    Console.WriteLine(inputA / inputB);
                    break;
                case '%':
                    Console.WriteLine(inputA % inputB);
                    break;
                case '^':
                    Console.WriteLine(Math.Pow(inputA,inputB));
                    break;
                default:
                    Console.WriteLine("Invalid Order");
                    break;
            }
        }
    }
}
