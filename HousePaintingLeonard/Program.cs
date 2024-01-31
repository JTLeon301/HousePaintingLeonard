using static System.Console;
namespace HousePaintingLeonard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Name: Jaiden Leonard
             * Class: CPSC 23000-001
             * Assignment: House Painter
             * Date: 1/30/2024
            */

            //initialize variables
            double rooms;
            double roomLength = 0;
            double roomWidth = 0;
            double roomHeight = 0;
            double ceilingFootage = 0;
            double primerSquareFootage = 0;
            double squareFootage = 0;
            string userEntry;
            string paintCeiling;
            string usePrimer;

            //print header
            WriteLine("*********************************************");
            WriteLine("            HOUSE PAINTER V1.0");
            WriteLine("*********************************************");

            //ask user for how many rooms they want painted
            Write("\nHow many rooms do you plan to paint? ");
            userEntry = ReadLine();
            try
            {
                rooms = Convert.ToDouble(userEntry);
            } 
            catch (FormatException)
            {
                WriteLine("You need to enter a number.\nSetting it to 1.\n");
                rooms = 1;
            }
            //do while loop for asking questions
            int i = 1;
            do
            {
                //ask user for room length
                WriteLine("For Room #" + i++ + "...");
                Write("        Enter length: ");
                userEntry = ReadLine();
                try
                {
                    roomLength = Convert.ToDouble(userEntry);
                }
                catch (FormatException)
                {
                    WriteLine("\nYou need to enter a number.\nSetting it to 1.\n");
                    roomLength = 1;
                }

                //ask user for room width
                Write("        Enter width: ");
                userEntry = ReadLine();
                try
                {
                    roomWidth = Convert.ToDouble(userEntry);
                }
                catch (FormatException)
                {
                    WriteLine("\nYou need to enter a number.\nSetting it to 1.\n");
                    roomWidth = 1;
                }

                //ask user for room height
                Write("        Enter height: ");
                userEntry = ReadLine();
                try
                {
                    roomHeight = Convert.ToDouble(userEntry);
                }
                catch (FormatException)
                {
                    WriteLine("\nYou need to enter a number.\nSetting it to 1.\n");
                    roomHeight = 1;
                }

                //ask user if they want to paint the ceiling
                Write("        Paint the ceiling? ");
                paintCeiling = ReadLine();
                //switch statement for painting ceiling
                switch (paintCeiling)
                {
                    case "y":
                    case "Y":
                        ceilingFootage = roomLength * roomWidth;
                        break;
                    case "n":
                    case "N":
                        ceilingFootage = 0;
                        break;
                    default:
                        WriteLine("\nYou need to enter (y/n).\nSetting it to n.\n");
                        ceilingFootage = 0;
                        break;
                }

                //ask user if they want to use primer
                Write("        Use primer? ");
                usePrimer = ReadLine();
                //switch statment for primer use
                switch (usePrimer)
                {
                    case "y":
                    case "Y":
                        primerSquareFootage += roomLength * roomWidth * roomHeight;
                        break;
                    case "n":
                    case "N":
                        primerSquareFootage = 0;
                        break;
                    default:
                        WriteLine("\nYou need to enter (y/n).\nSetting it to n.\n");
                        primerSquareFootage = 0;
                        break;
                }

                //get square footage of room
                squareFootage += roomLength * roomHeight * roomWidth + ceilingFootage;
            } while (i <= rooms);
            WriteLine();

            //calculations to output to user
            double paintGallonsNeeded = squareFootage / 400;
            double primerGallonsNeeded = primerSquareFootage / 250;

            //output to user
            WriteLine("To paint " + squareFootage + " square feet,");
            WriteLine("        you need " + paintGallonsNeeded + " gallons of paint.");
            WriteLine("To prime " + primerSquareFootage + " square feet,");
            WriteLine("        you need " + primerGallonsNeeded + " gallons of primer.");
            Write("\nThank you for using this program.");
        }
    }
}
