using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateR
{
    class Program
    {
        static void Main(string[] args)
        {
            ActionAndFunc aaf = new ActionAndFunc();
            aaf.AddOperation("mod", (x, y) => x % y);
            char choise = 'o';
            do
            {
                Console.WriteLine("Enter operator and operation. \n Enter first operand");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter operator + or - or * or /");
                string operand = Console.ReadLine();
                Console.WriteLine("Enter second operand");
                int y = int.Parse(Console.ReadLine());
                Console.WriteLine(aaf.PerfOperation(operand, x, y));
                Console.WriteLine();
                Console.WriteLine("If you want finish enter \"X\"");
                choise = char.Parse(Console.ReadLine());
                Console.Clear();
            }
            while (choise != 'X');
            
        }
    }
}
