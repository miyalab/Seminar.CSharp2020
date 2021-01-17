﻿using System;

/// <summary>
/// コンソールの文字列出力プログラム
/// </summary>
namespace _01_ConsoleWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            // 改行なし
            Console.Write("MiYA ");

            // 改行あり
            Console.WriteLine("Hello World!");

            // 改行あり 「Environment.NewLine」は改行コードの挿入
            Console.Write("Hello C# World!" + Environment.NewLine);
        }
    }
}