/*
 一个 C# 程序主要包括以下部分：

> 命名空间声明（Namespace declaration）
> 一个 class
> Class 方法
> Class 属性
> 一个 Main 方法
> 语句（Statements）& 表达式（Expressions）
> 注释
 */
/*
 以下几点值得注意：

> C# 是大小写敏感的。
> 所有的语句和表达式必须以分号（;）结尾。
> 程序的执行从 Main 方法开始。
> 与 Java 不同的是，文件名可以不同于类的名称。
 */
using System;

namespace HelloWorldApplication
{
    /* 类名为 HelloWorld */
    class HelloWorld
    {
        /* main函数 */
        static void Main(string[] args)
        {
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
            Console.ReadKey();
        }
    }
}