using System;

public class LovelyProgram
{
  public static void Main (string[] args)
  {
    Console.WriteLine("=== Love Calculator ===");
    Console.WriteLine();
    Console.WriteLine("Hello! please enter the name of the first person");
    string name1 = Console.ReadLine();
    
    Console.WriteLine();
    Console.WriteLine("Great! Now, enter the second person, and let's see if you two have something special...");
    string name2 = Console.ReadLine();
     
    if (name1 == "Luiz" && name2 == "Pão de queijo")
    {
      Console.WriteLine();
      Console.WriteLine($"{name1} + {name2} = ∞%");
      Console.WriteLine();
      Console.WriteLine("What? I really like 'Pão de queijo' (search it)");
    }
    else
    {
      Random random = new Random();
      int percent = random.Next(0, 101);
       
      Console.WriteLine();
      Console.WriteLine($"{name1} + {name2} = {percent}%");
       
      if (percent <= 25)
      {
        Console.WriteLine();
        Console.WriteLine("Oh... It's just friends... Maybe.");
      }
      else if (percent <= 50)
      {
        Console.WriteLine();
        Console.WriteLine("Something is happening with you two...");
      }
      else if (percent <= 75)
      {
        Console.WriteLine();
        Console.WriteLine("Love is all around both of you.");
      }
      else if (percent <= 85)
      {
        Console.WriteLine();
        Console.WriteLine("It's time to make a move, baby! Love is waiting for both of you!");
      }
      else if (percent <= 100)
      {
        Console.WriteLine();
        Console.WriteLine("Prepare to get married, my friend!");
      }
    }
  }
}