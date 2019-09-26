using System;
using System.Collections.Generic;
using GamePlay;

class Program
{
    static void Main()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine("What is your dog's name?");
        string dogName = Console.ReadLine();
        Game newGame = new Game(name, dogName);
        newGame.firstScenario();
    }
}