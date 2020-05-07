using System;
//using System.Collections.Generic;
using Garden.Plant;
//using Disaster.Plant;

namespace Garden
{
  public class Program
  {
    public static void Main()
    {
      bool play = false;
      Console.WriteLine("Let's go on a herb adventure! Do you want to play?");
      string response = Console.ReadLine();
      if (response == "yes") 
      {
        play = true;
        Console.WriteLine("Great! Let's get growing! What would you like to name your plant?");
      } 
      else 
      {
        play = false;
        Console.WriteLine("Too bad! See you later!");
      }
      
      string myName = Console.ReadLine();
      Herb myHerb = new Herb(myName, 1, 0, 1);

      Console.WriteLine("Your plant " + myName + " is ready for you to take care of it!");

      while (play == true) //myHerb.health > 0 
      {
        Console.WriteLine("What would you like to do? Your action choices are: 'water', 'sun', 'feed', or 'exit'.");
        string action = Console.ReadLine();        
        action = Console.ReadLine();

        if (action == "water")
        {
          myHerb.Height = myHerb.Height + 1;
        }
        else if (action == "sun")
        {
          
        }
        else if (action == "feed")
        {
          
        }
        else if (myHerb.Health <= 0)
        {
          play = false;
        }
        else if (action == "exit")
        {
          Console.WriteLine("Hope you enjoyed growing!");
        }
        else
        {
          Console.WriteLine("Sorry I didn't understand your input");
        }
      }
    }
  }
}