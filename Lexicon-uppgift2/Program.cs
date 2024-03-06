// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using System.Runtime.CompilerServices;

bool loopty = true;

/* because y'all always keep saying not to repeat code :) */
static bool tryParseToInt(string input, out int result)
{
    return int.TryParse(input, out result);
}

static int calculatePrice(int age)
{
    if (age < 20)
    { return 80; }
    else if (age > 64)
    { return 90; }
    else 
    { return 120; }
}

do
{
    Console.WriteLine("This is the main menu, please use the following numbers to navigate and test different functions");
    Console.WriteLine("" +
        "Press 0 to exit.\n" +
        "Press 1 to check your price for the local cinema.\n" +
        "Press 2 to check your price for the local cinema as a GROUP.\n" +
        "Press 3 to repeat 10 times.\n" +
        "Press 4 to get the third word of whatever sentence you enter in the next step."
        );
    var menuChoice = Console.ReadLine();
   
    

    switch (menuChoice)
    {
        case "0":
            Console.WriteLine("Thanks for your time and have a good day.");
            loopty = false;
            break;
           /*******************************************************************/
        case "1":
            Console.WriteLine("Please enter your age.");
            var ageInput = Console.ReadLine();
            
            if (tryParseToInt(ageInput, out int age))
            {
               if (age < 20)
                {
                    Console.WriteLine("Youth price: 80kr");
                } else if (age > 64)
                {
                    Console.WriteLine("Senior price: 90kr");
                } else
                {
                    Console.WriteLine("Standard price: 120kr");
                }
                
            } else
            {
                Console.WriteLine("You did not enter a valid number. Please enter a number between 1 and 2,147,483,647! Returning to main menu..");
            }
            break;
        /*******************************************************************/
        case "2":
            Console.WriteLine("Please enter how many people are in your group to proceed.");
            var groupInput = Console.ReadLine();
            int totalPrice = 0;


            if (tryParseToInt(groupInput, out int groupNumber))
            {
                for (int i = 0; i < groupNumber; i++)
                {
                    while (true)
                    {
                        Console.WriteLine($"Enter age for person {i + 1}:");
                         ageInput = Console.ReadLine();
                        if (tryParseToInt(ageInput, out age))
                        {
                            int ticketPrice = calculatePrice(age);
                            totalPrice += ticketPrice;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                        }
                    }
                }

                Console.WriteLine($"Total cost for the group of {groupInput} is: {totalPrice}kr.");


            } else
            {
                Console.WriteLine("You did not enter a valid number. Please enter just a number.  Returning to main menu..");
            }
            break;
         /*******************************************************************/
         case "3":
            Console.WriteLine("I'm not honestly sure I get this, if its supposed to be the SAME or 10 different texts so we'll just go with the same one.\n" +
                "So please go ahead and write something and we'll repeat it 10 times.");
            var repeat = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}. " + repeat + " ");
            }
            Console.WriteLine("\n");
            break;
        /*******************************************************************/
        case "4":
            Console.WriteLine("Write at least 3 words in a sentence...");
            var words = Console.ReadLine();
            var thirdWord = words?.Split(" ");
            Console.WriteLine(thirdWord[2]);
            break;
        /*******************************************************************/
        default:
            Console.WriteLine("Invalid choice, please try again...");
            break;
    }

    /* Menyval 1: Ungdom eller pensionär DONE
     * Menyval 2: Upprepa tio gånger
     * Menyval 3: Det tredje ordet
     */
} while (loopty);


