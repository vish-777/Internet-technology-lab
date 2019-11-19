using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticOperations
{
    class Calculator
    {
        static void Main(string[] args)
        {
            double num1, num2;
            char op;

            Console.WriteLine("Enter 2 numbers: ");
            string n1 = Console.ReadLine();
            string n2 = Console.ReadLine();
            double.TryParse(n1, out num1);
            double.TryParse(n2, out num2);

            Console.WriteLine("Enter Operator:");
            string n3 = Console.ReadLine();
            char.TryParse(n3, out op);

            double res = 0;
            switch (op)
            {
                case '+':
                    res = num1 + num2;
                    break;
                case '-':
                    res = num1 - num2;
                    break;
                case '*':
                    res = num1 * num2;
                    break;
                case '/':
                    res = num1 / num2;
                    break;
                case '%':
                    res = num1 % num2;
                    break;
                default:
                    Console.WriteLine("Invalid Operator!! Please try again");
                    break;
            }

            Console.WriteLine("Result: {0} {1} {2} = {3}", num1, op, num2, res);

            Console.Read();
        }
    }
}
