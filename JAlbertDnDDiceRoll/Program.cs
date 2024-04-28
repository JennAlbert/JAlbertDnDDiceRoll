
Console.WriteLine("Please choose one of the following: D4, D6, D8, D10, D12, D20. Or type X to quit.");
Random random = new Random();
string userInput = Console.ReadLine();
bool loopContinue = true;

while (loopContinue)
{ 
    switch (userInput)
    {
        case "D4":
            {
                if (userInput == "D4")
                {
                    int diceRoll = random.Next(1, 5);
                    Console.WriteLine("You rolled " + diceRoll);
                    loopContinue = false;
                }
            }
            break;

        case "D6":
            {
                if (userInput == "D6")
                {
                    int diceRoll = random.Next(1, 7);
                    Console.WriteLine("You rolled " + diceRoll);
                    loopContinue = false;
                }
            }
            break;

        case "D8":
            {
                if (userInput == "D8")
                {
                    int diceRoll = random.Next(1, 9);
                    Console.WriteLine("You rolled " + diceRoll);
                    loopContinue = false;
                    
                }
            }
            break;

        case "D10":
            {
                if (userInput == "D10")
                {
                    int diceRoll = random.Next(1, 11);
                    Console.WriteLine("You rolled " + diceRoll);
                    loopContinue = false;
                }
            }
            break;

        case "D12":
            {
                if (userInput == "D12")
                {
                    int diceRoll = random.Next(1, 13);
                    Console.WriteLine("You rolled " + diceRoll);
                    loopContinue = false;
                }
            }
            break;
        case "D20":
            {
                if (userInput == "D20")
                {
                    int diceRoll = random.Next(1, 21);
                    Console.WriteLine("You rolled " + diceRoll);
                    loopContinue = false;
                }

            }
            break;
        case "X":
            {
                if (userInput == "X")

                    Console.WriteLine("Goodbye. Application closing.");
                Environment.Exit(0);
            }
            break;

            default:
            {
                loopContinue = true;
                break;
            }
    }


}


