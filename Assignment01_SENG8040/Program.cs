using System;

namespace Assignment01_SENG8040
{
    class Program
    {
        public static int menuselection()
        {
            bool exitloop = false;
            string selection = "";
            while (exitloop == false)
            {
                Console.WriteLine("1 = Get Rectangle Length");
                Console.WriteLine("2 = Change Rectangle Length");
                Console.WriteLine("3 = Get Rectangle Width");
                Console.WriteLine("4 = Change Rectangle Width");
                Console.WriteLine("5 = Get Rectangle Perimeter");
                Console.WriteLine("6 = Get Rectangle Area");
                Console.WriteLine("7 = Exit");

                Console.WriteLine("Please select the number by to perform Operation : ");
                selection = Console.ReadLine();

                if (selection != "1" && selection != "2" && selection != "3" && selection != "4" && selection != "5" && selection != "6" && selection != "7")
                {
                    Console.WriteLine("Please select valid number");
                }
                else
                {
                    exitloop = true;
                }
            }
            Console.WriteLine();
            return int.Parse(selection);
        }

        public static int ValidateUserInput(string chosenNumber)
        {
            int aNumber = 1;
            bool isValid = false;

            while (isValid == false)
            {
                Console.WriteLine($"Please enter the {chosenNumber}:");
                string userInput = Console.ReadLine();
                Console.WriteLine();

                bool result = int.TryParse(userInput, out aNumber);

                if (result == false)
                {
                    Console.WriteLine("That's not a valid input please, please try again.\n");
                }

                else
                {
                    isValid = true;
                    Console.WriteLine($"Your {chosenNumber} has been changed to: {aNumber}.\n");
                }
            }

            return aNumber;
        }



        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            int selection;
            selection = menuselection();
            if (selection == 5 || selection == 6)
            {
                int Length, Width;
                Length = ValidateUserInput("Rectangel Length");
                Width = ValidateUserInput("Rectangle Width");
                Console.WriteLine($"Your Length for calculation is : {Length}");
                Console.WriteLine($"Your Width for calculation is : {Width}");
                r.SetLength(Length);
                r.SetWidht(Width);
            }
            while (selection != 7)
            {
                int result;
                switch (selection)
                {
                    case 1:
                        Console.WriteLine($"Rectangle length is : {r.GetLength()}");
                        break;
                    case 2:
                        result = ValidateUserInput("Rectangle Length");
                        r.SetLength(result);
                        break;
                    case 3:
                        Console.WriteLine($"Rectangle widht is : {r.GetWidth()}");
                        break;
                    case 4:
                        result = ValidateUserInput("Rectangle Width");
                        r.SetWidht(result);
                        break;
                    case 5:
                        Console.WriteLine($"The Perimeter of rectangle with (length : {r.GetLength()} and width : {r.GetWidth()}) is : {r.GetPerimeter()}");
                        break;
                    case 6:
                        Console.WriteLine($"The Area of rectangle with (length : {r.GetLength()} and width : {r.GetWidth()}) is : {r.GetArea()}");
                        break;
                    default:
                        break;

                }
                selection = menuselection();
            }
        }
    }
}
