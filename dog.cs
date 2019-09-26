using System;
using System.Collections.Generic;

namespace GamePlay 
{

class Game
        {
            public string Name { get; set; }
            public List<string> DefenseItems { get; set; }
            public string DogName { get; set; }
            // public string DogMood { get; set; }
            // public string RobberAnger { get; set; }

            public Game(string name, string dogName)
            {
                Name = name;
                DefenseItems = new List<string>();
                DogName = dogName;
                // DogMood = "neutral";
                // RobberAnger = "low";
            }



            public string firstScenario()
            {
                Console.WriteLine("You just stepped into a convenience store, when all of a sudden a robber steals your car. But your dog is still in the car! What do you do?");
                Console.WriteLine("Option 1: You see a motorcycle with a sidecar in the partking lot that you could steal. You lose 5 minutes hotwiring it and you have never ridden a moto before, BUT, it is really fast.");
                Console.WriteLine("Option 2: Steal a bicycle. You lose no time, but it can go places the moto can't, so you may be able to intercept the robber.");
                Console.WriteLine("Option 3: Call the police. You like your dog and car, but not worth getting hurt for.");
                Console.WriteLine("Which option do you take? Time is of the essence. [Choose 1, 2, or 3]");
                string scenarioOne = Console.ReadLine();
                if(scenarioOne == "1")
                    {
                        DefenseItems.Add("1. A helmet");
                        DefenseItems.Add("2. A wrench");
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
            public string motoScenario()
            {
                Console.WriteLine("You find that there is a learning curve to riding a motorcycle and you don't know how to shift!!");
                Console.WriteLine("You lose even more time and you see your car and your dog, now incredibly sad, riding away in the distance. You see a motorcycle shop nearby, and you drag the motorcycle towards it.");
                Console.WriteLine("Option 1: Do you ask for a crash-course (no pun intended) on how to ride a motorcycle?");
                Console.WriteLine("Option 2: Do you hire the mechanic to pursue the theif with you hanging on behind?");
                Console.WriteLine("Which option do you take? Every moment you hesitate, the miles between you and your dog lengthen. [Choose 1 or 2]");
                string scenarioTwo = Console.ReadLine();
                if(scenarioTwo == "1")
                {
                    motoCrashCourse();
                }
                else if(scenarioTwo == "2")
                {
                    motoPassenger();
                }
                else
                {
                    Console.WriteLine("Please select an option");
                }
                    return scenarioTwo;

            }
            public void bikeScenario()
            {
                Console.WriteLine("Good choice. This is more your speed, anyhow.");
                Console.WriteLine("The robber gets stuck in traffic, so you are gaining on him. He takes a sudden left to get around the congestion. You are way slower, but you know a shortcut through a park. The shortcut is obviously faster, but there are a few obstacles.");
                Console.WriteLine("Do you take the shortcut or do you stay to the pavement?");
                Console.WriteLine("Option 1: Take the shortcut. You beloved dog is getting further away!");
                Console.WriteLine("Option 2: Stick to the pavement. You can't afford any risks right now.");
                string scenarioTwo = Console.ReadLine();
                if(scenarioTwo == "1" || scenarioTwo == "2")
                {
                    Console.WriteLine("Oh no!! You got a flat tire. Game Over.");
                }
               
            }

            public void motoCrashCourse()
            {
                Console.WriteLine("You lose another 10 minutes learning how to ride a motorcycle!! You can't afford this. " + DogName + "is getting further away.");
                Console.WriteLine("You are back in the chase, but you are stuck in the same traffic that stopped the robber and unable to lane-split.");
                Console.WriteLine("You catch up to the robber and realize that he is armed with a sock full of coins. He launches it at you, but are able to dodge the projectile. ");
                Console.WriteLine("You have to fight back! BUT, you have two items at your disposal.");
                // Console.WriteLine("You decide to abandon the motorcylce and try to run after the robber. Unfortunately, you were never good at sprinting or long-distance running. The robber and" + DogName + "are too far away. The robber has stolen one more thing today: your happiness. Game over");
                foreach (string item in DefenseItems)
                {
                    Console.WriteLine(item);
                    
                }
                Console.WriteLine("Which item do you choose? Helmet or wrench?");
                string weaponChoice = Console.ReadLine();
                if(weaponChoice == "helmet" || weaponChoice == "Helmet")
                {
                    something();
                }
                else if(weaponChoice == "wrench" || weaponChoice == "Wrench")
                {
                    soemthing();
                }
            }

            public void motoPassenger()
            {
                Console.WriteLine("You make it two blocks before the mechanic realizes this isn't worth his time or life. He leaves you stranded. Game Over.");
            }
        }  
}


