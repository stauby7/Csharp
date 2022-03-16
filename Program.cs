using System;
class Program {

  
  namespace CsharpConsle

    {
        static void Main(string[] args)
        {
            bool Menu = true;
            while(Menu)
            {
                Menu = TheMenu();
            }
        }
    
        private static bool TheMenu()
        {
            Console.Clear();
            Console.WriteLine("Pick something to do:");
            Console.WriteLine("Option 1: Tell me your name.");
            Console.WriteLine("Option 2: Watch me do some Math.");
            Console.WriteLine("Option 3: Watch me do some cooler Math");
            Console.WriteLine("Option 4: Do some reading with me.");
            Console.WriteLine("Option 5: Leave the program");
            Console.WriteLine("\r\nSelect an option: ");

            switch(Console.ReadLine())
            {
                case "1":
                    YaBoiName();
                    return true;
                    break;
                case "2":
                    RectangleMath();
                    return true;
                    break;
                case "3":
                    GasForLess();
                    return true;
                    break;
                case "4":
                    AliceRead();
                    return true;
                    break;
                case "5":
                    return false;
                    break;
                default:
                    return true;
                    break;
            }
        }
    }

namespace CsharpConsle

  {
    private static void YaBoiName()
    {
      Console.Writeline("What is your name?");

      Console.Writeline("It's ya boi, um,", Console.Readline());
    }
  }

namespace CsharpConsle

  {
    private static void RectangleMath()
    {
      int length = Console.Readline("What is the length of your rectangle?");

      int width = Console.ReadLine("What is the width of your rectangle?");

      int Area = length * width;

      Console.WriteLine("Tada, here is you area:", area);
    }
  }

namespace CsharpConsle

  {
    private static void GasForLess()
    {
      float miles = Console.ReadLine("How far have you driven in mile?");

      float gas = Console.ReadLine("How much gas have you used in gallons?");

      float MPG = miles / gas;

      Console.WriteLine("Your miles-per-gallon is:", MPG);
    }
  }


namespace CsharpConsle

  {
    private static void AliceRead()
      {
        string search;
        
        string sentence = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book thought Alice 'without pictures or conversation?";

        Console.WriteLine("Enter string to search:");

        search = Console.ReadLine();
        sentence = search.ToLower();
        search = search.ToLower();

        if (sentence.Contains(search))
        {
          Console.WriteLine("true");
        }
        else
        {
          Console.WriteLine("false");
        }

        
      }
    }
}
