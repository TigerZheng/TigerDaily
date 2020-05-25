using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicOperation
{
    class LogicOp
    {
        public void DemoLoop()
        {
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Hello World! The counter1 is {counter}");
                counter++;
            }

            counter = 0;
            do
            {
                Console.WriteLine($"Hello World! The counter2 is {counter}");
                counter++;
            } while (counter < 10);

            for (int counter3 = 0; counter3 < 10; counter3++)
            {
                Console.WriteLine($"Hello World! The counter is {counter3}");
            }
        }

        public void DemoBranch()
        {
            int a = 5;
            int b = 3;
            int c = 4;
            if ((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not equal to the second");
            }

            if ((a + b + c > 10) || (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("Or the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("And the first number is not equal to the second");
            }

        }

    }
}
