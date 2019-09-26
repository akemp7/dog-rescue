using System;
using System.Collections.Generic;

namespace GamePlay 
{

class Game
        {
            public string Name { get; set; }
            // public string DefenseItem { get; set; }
            public string DogName { get; set; }
            // public string DogMood { get; set; }
            // public string RobberAnger { get; set; }

            public Game(string name, string dogName)
            {
                Name = name;
                // DefenseItem = defenseItem;
                DogName = dogName;
                // DogMood = "neutral";
                // RobberAnger = "low";
            }



            public string firstScenario()
            {
                Console.WriteLine("You just stepped into a convenience store, when all of a sudden a robber steals your car. But your dog is still in the car! What do you do?");
                Console.WriteLine("Option 1: Steal a motorcycle. You lose 5 minutes hotwiring it and you have never ridden a moto before, BUT, it is super fast");
                Console.WriteLine("Option 2: Steal a bike. You lose no time, but it can go places the moto can't, so you may be able to intercept the robber.");
                Console.WriteLine("Option 3: Call the police. You like your dog and car, but not worth getting hurt for.");
                Console.WriteLine("Which option do you take? Time is of the essence. [Choose 1, 2, or 3]");
                string scenarioOne = Console.ReadLine();
                if(scenarioOne == "1")
                    {
                        motoScenario();
                    } 
                    else if(scenarioOne == "2")
                    {
                        bikeScenario();
                    }
                    else if(scenarioOne == "3")
                    {
                        Console.WriteLine("Go home and wait for the police to find your furry friend. Game Over.");
                    }
                    else 
                    {
                        Console.WriteLine("Choose an actual option.");
                    }
                    return scenarioOne;
            }
            public void motoScenario()
            {
                Console.WriteLine("You find that there is a learning curve to riding a motorcycle and you don't know how to shift!!");
            }
            public void bikeScenario()
            {
                Console.WriteLine("Good choice. This is more your speed, anyhow.");
            }
        }  
}


