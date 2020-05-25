using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataOperation
{
    class DataOp
    {
        public void Demo()
        {
            // String
            string aFriend = "Tiger";
            Console.WriteLine("Hello World! " + aFriend);
            Console.WriteLine($"Hello {aFriend} ");
            Console.WriteLine($"{aFriend} is my name , it has {aFriend.Length} letters.");
            string greeting = "      Hello World!       ";
            Console.WriteLine($"[{greeting}]");

            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");

            string sayHello = "Hello World!";
            Console.WriteLine(sayHello);
            string sayHelloNew = sayHello.Replace("Hello", "Greetings");
            Console.WriteLine(sayHelloNew);
            Console.WriteLine(sayHello);
            Console.WriteLine(sayHello.ToUpper());
            Console.WriteLine(sayHello.ToLower());

            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetings"));
            Console.WriteLine(songLyrics.StartsWith("goodbye"));
            Console.WriteLine(songLyrics.EndsWith("greetings"));
            Console.WriteLine(songLyrics.StartsWith("You"));
            Console.WriteLine(songLyrics.EndsWith("hello"));

            // Number int
            int a = 5;
            int b = 4;
            int c = 2;
            int d = a + b * c;
            Console.WriteLine(d);

            d = (a + b) / c;
            Console.WriteLine(d);

            d = (a + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");

            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");

            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");

            // Number double
            double aa = 5;
            double ab = 4;
            double ac = 2;
            double ad = (aa + ab) / ac;
            Console.WriteLine(ad);

            aa = 19;
            ab = 23;
            ac = 8;
            ad = (aa + ab) / ac;
            Console.WriteLine(ad);

            double dmax = double.MaxValue;
            double dmin = double.MinValue;
            Console.WriteLine($"The range of double is {dmin} to {dmax}");

            double third = 1.0 / 3.0;
            Console.WriteLine(third);

            // Number decimal
            decimal emin = decimal.MinValue;
            decimal emax = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {emin} to {emax}");

            double ea = 1.0;
            double eb = 3.0;
            Console.WriteLine(ea / eb);

            decimal ec = 1.0M;
            decimal ed = 3.0M;
            Console.WriteLine(ec / ed);

            double radius = 2.50;
            double area = Math.PI * radius * radius;
            Console.WriteLine(area);
        }
    }
}
