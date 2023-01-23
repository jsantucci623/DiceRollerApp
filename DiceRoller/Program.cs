// Dice Roller
// Jeff Santucci
// 01/19/23

using DiceRoller;

bool isValidNum;
bool tryAgain = true;
do
{
    Console.WriteLine("Enter the number of sides for a pair of dice? ");
    string sides = Console.ReadLine();
    isValidNum = int.TryParse(sides, out int numSides);

    do
    {
        if (!isValidNum)
        {
            Console.WriteLine(sides + " Is not a valid number! Try Again (y/n)? ");
            string answer = Console.ReadLine();
            if (answer != "y")
            {
                tryAgain = false;
            }
        }
        else
        {
            Console.WriteLine("Roll the dice!");
            int dieNum1 = DiceRollerMethods.DieNumber(numSides);
            Console.WriteLine(dieNum1 + " first die");
            int dieNum2 = DiceRollerMethods.DieNumber(numSides);
            Console.WriteLine(dieNum2 + " Second die");
            if (int.Parse(sides) == 6)
            {
                int totalDie = DiceRollerMethods.DiceTotal(dieNum1, dieNum2);
                string diceResult = DiceRollerMethods.DiceResult(totalDie);
                Console.WriteLine(diceResult);
                string diceWinner = DiceRollerMethods.WinCraps(dieNum1, dieNum2);
                Console.WriteLine(diceWinner);
            }
            tryAgain = false;
        }
    } while (tryAgain);

    Console.WriteLine("Would you like to roll the dice again? (y/n)? ");
    string anotherAnswer = Console.ReadLine();
    if (anotherAnswer != "y")
    {
        tryAgain = false;   
    }
    else
    {
        tryAgain = true;
    }
} while (tryAgain);





