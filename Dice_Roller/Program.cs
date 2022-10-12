
DiceOuput();



//METHOD FOR RANDOM NUMBERS
int DiceRandom(out int diceOne, out int diceTwo)
{
    
    Console.WriteLine("please enter the number of sides on your pair of dice");
    int diceSides;
    bool isValid = int.TryParse(Console.ReadLine(), out diceSides);
    
    if(!isValid)
    {
        Console.WriteLine("Invalid entry please try again");
        Environment.Exit(0);
    }
    Random firstDice = new Random();
    Random secondDice = new Random();
    diceOne = firstDice.Next(1, diceSides);
    diceTwo = secondDice.Next(1, diceSides);

    return diceSides;

}

//METHOD FOR SIXSIDED DICE
string SixSidedDice(int diceOne, int diceTwo)
{
    string results;
    if(diceOne==1 && diceTwo==1)
    {
        results = $"you rolled Snake Eyes: {diceOne} and {diceTwo}";
        return results;
    }
    else if (diceOne == 1 && diceTwo == 2)
    {
        results = $"you rolled Ace Deuce: a {diceOne} and {diceTwo}";
        return results;
    }
    else if (diceOne == 2 && diceTwo == 1)
    {
        results = $"you rolled Ace Deuce: a {diceOne} and {diceTwo}";
        return results;
    }
    else if (diceOne ==6 && diceTwo ==6)
    {
        results = "you rolled Box Cars: Two 6s";
        return results;
    }
    else if(diceOne+diceTwo==7 || diceOne+diceTwo==11)
    {
        results = $"you rolled {diceOne} and {diceTwo} A total of 7 or 11 YOU WINNN!!!";
        return results;
    }
    else
    {
        results = $"you rolled {diceOne} and {diceOne}";
        return results;
        
    }
}

// BONUS WINNING COMBO BESIDES SIX SIDED DICE
string EightSidedDice(int diceOne, int diceTwo)
{
    string results;
    if (diceOne == 1 && diceTwo == 1)
    {
        results = $"you rolled Snake Eyes: {diceOne} and {diceTwo}";
        return results;
    }
    else if (diceOne == 1 && diceTwo == 2)
    {
        results = $"you rolled Ace Deuce: a {diceOne} and {diceTwo}";
        return results;
    }
    else if (diceOne == 2 && diceTwo == 1)
    {
        results = $"you rolled Ace Deuce: a {diceOne} and {diceTwo}";
        return results;
    }
    else if (diceOne == 6 && diceTwo == 6)
    {
        results = "you rolled Box Cars: Two 6s";
        return results;
    }
    else if (diceOne + diceTwo == 7 || diceOne + diceTwo == 11)
    {
        results = $"you rolled {diceOne} and {diceTwo} A total of 7 or 11 YOU WINNN!!!";
        return results;
    }
    
    
    else
    {
        results = $"you rolled {diceOne} and {diceOne}";
        return results;

    }
}

//METHOD TO IMPLEMENT OUTPUT FOR DICE SIZES
void DiceOuput()
{
    while (true)
    {
        int diceOne;
        int diceTwo;
        int diceSides;
        diceSides = DiceRandom(out diceOne, out diceTwo);
        int diceTotal = diceOne + diceTwo;

        if (diceSides == 6)
        {
            Console.WriteLine(SixSidedDice(diceOne, diceTwo));
        }
        else if (diceSides == 8)
        {
            Console.WriteLine(EightSidedDice(diceOne, diceTwo));
        }
        else
        {
           Console.WriteLine($"you rolled {diceTotal} with {diceOne} and {diceTwo}");
        }

        bool continueOrEndLoop = BreakLoop();
        if (!continueOrEndLoop)
        {
            break;
        }
    }

}

//METHOD TO BREAK LOOP
bool BreakLoop()
{
    Console.WriteLine("Would you like to try again? please enter Yes or Y");
    string tryAgain = Console.ReadLine();
    if (tryAgain.ToLower() != "yes" && tryAgain.ToLower() != "y")
    {
        Console.WriteLine("Goodbye!");
        return false;
    }
    else
    {
        return true;
    }
}



