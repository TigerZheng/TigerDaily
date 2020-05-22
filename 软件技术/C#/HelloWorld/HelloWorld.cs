﻿/*
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
            /* 我的第一个 C# 程序 */
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}