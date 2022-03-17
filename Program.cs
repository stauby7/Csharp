using System;
namespace CsharpConsle{
class Program {

  

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
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Pick something to do:");
            Console.WriteLine("Option 1: Tell me your name.");
            Console.WriteLine("Option 2: Watch me do some Math.");
            Console.WriteLine("Option 3: Watch me do some cooler Math");
            Console.WriteLine("Option 4: Do some reading with me.");
            Console.WriteLine("Option 5: Get outta here.");
            Console.WriteLine("\r\nSelect an option: ");

            switch(Console.ReadLine())
            {
                case "1":
                    YaBoiName();
                    return true;
                case "2":
                    RectangleMath();
                    return true;
                case "3":
                    GasForLess();
                    return true;
                case "4":
                    AliceRead();
                    return true;
                case "5":
                    return false;
                default:
                    return true;
            }
        }
    private static void YaBoiName()
    {
      Console.WriteLine("What is your name?");

      string name = Console.ReadLine();

      Console.WriteLine("It's ya boi, um, " + name);

    }



    private static void RectangleMath()
     {
       Console.WriteLine("What is the length of your rectangle?");
      
      int length = Convert.ToInt32(Console.ReadLine());


      Console.WriteLine("What is the width of your rectangle?");

      int width = Convert.ToInt32(Console.ReadLine());

       int area = length * width;

       Console.WriteLine("Tada, here is you area: " + area);
     }



     private static void GasForLess()
    {
      Console.WriteLine("How many miles have you travled?");

      double miles = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("How many gallons of gas have you used?");

      double gas = Convert.ToDouble(Console.ReadLine());

      double MPG = miles / gas;

      Console.WriteLine("Your miles-per-gallon is: " + MPG);
    }



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