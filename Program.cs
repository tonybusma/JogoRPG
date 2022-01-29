using System;
using JogoRPG.Entities;

namespace JogoRPG
{
    class Program
    {
        static void Main(string[] args)
        {
          Knight arus = new Knight("Arus", 23, "Knight");
          Wizard jenica = new Wizard("Jenica", 23, "White Wizard");
          Ninja half = new Ninja("Half", 20, "Ninja");
          Paladin john = new Paladin("John", 22, "Paladin");

          System.Console.WriteLine(half);
          
        }
    }
}
