using System;
using CDFA.Core;
using System.Linq;
using System.Collections.Generic;

namespace CDFA
{
    class Program
    {
        static void Main(string[] args)
        {
            InvokeDFA();
        }



        static void MainMenu()
        {
            Console.WriteLine("Hello! What do you want to do today?\n");
            Console.WriteLine("1 - Define DFA");
            Console.WriteLine("\n Write a number to start your operation!");

            if ("1".Equals(Console.ReadLine()))
            {
                InvokeDFA();
            }
          
        }

        //L = {w | w ends with 001}
        static void InvokeDFA()
        {
            var symbolSet = new List<Symbol> { new Symbol("0"), new Symbol("1") };
            var language = new Language(symbolSet);

            var s1 = new State("")




        }
    }
}
