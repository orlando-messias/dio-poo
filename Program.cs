using System;
using rpg_poo.src.Entities;

namespace rpg_poo
{
  class Program
  {
    static void Main(string[] args)
    {
      Knight arus = new Knight("Arus", 23, "knight");
      Wizzard wizzard = new Wizzard("Jennica", 23, "white wizzard");

      Console.WriteLine(wizzard.Attack(1));
      Console.WriteLine(wizzard.Attack(7));
    }
  }
}
