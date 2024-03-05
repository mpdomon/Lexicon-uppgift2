// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;

bool loopty = true;

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
        case "1":
            int age;
            Console.WriteLine("Please enter your age.");
            var ageInput = Console.ReadLine();
            bool isInt = int.TryParse(ageInput, out age);
            
            if (isInt)
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
                Console.WriteLine("You did not enter a valid number. Please enter a number between 1 and 2,147,483,647! Returning to main menu.");
            }
            break;

            case "2":

            int groupNumber;
            Console.WriteLine("Please enter how many people are in your group to proceed.");


            break;
        
    }

    /* Menyval 1: Ungdom eller pensionär
     * Menyval 2: Upprepa tio gånger
     * Menyval 3: Det tredje ordet
     */
} while (loopty);


