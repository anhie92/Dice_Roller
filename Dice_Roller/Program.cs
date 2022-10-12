
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
    
    diceOne = firstDice.Next(1, diceSides);
    
    diceTwo = firstDice.Next(1, diceSides);

    return diceSides;

}

//METHOD FOR SIXSIDED DICE
string SixSidedDice(int diceOne, int diceTwo)
{
    
    if(diceOne==1 && diceTwo==1)
    {
        
        return $"you rolled Snake Eyes: {diceOne} and {diceTwo}";
    }
    else if (diceOne == 1 && diceTwo == 2)
    {
        
        return $"you rolled Ace Deuce: a {diceOne} and {diceTwo}";
    }
    else if (diceOne == 2 && diceTwo == 1)
    {
        
        return $"you rolled Ace Deuce: a {diceOne} and {diceTwo}";
    }
    else if (diceOne ==6 && diceTwo ==6)
    {
        
        return  "you rolled Box Cars: Two 6s";
    }
    else if(diceOne+diceTwo==7 || diceOne+diceTwo==11)
    {
        
        return $"you rolled {diceOne} and {diceTwo} A total of 7 or 11 YOU WINNN!!!";
    }
    else
    {
        
        return $"you rolled {diceOne} and {diceTwo}";

    }
}

// BONUS WINNING COMBO BESIDES SIX SIDED DICE
string EightSidedDice(int diceOne, int diceTwo)
{
    
    if (diceOne == 1 && diceTwo == 1)
    {
        
        return $"you rolled Snake Eyes: {diceOne} and {diceTwo}";
    }
    else if (diceOne == 1 && diceTwo == 2)
    {
        
        return $"you rolled Ace Deuce: a {diceOne} and {diceTwo}";
    }
    else if (diceOne == 2 && diceTwo == 1)
    {
        
        return $"you rolled Ace Deuce: a {diceOne} and {diceTwo}";
    }
    else if (diceOne == 6 && diceTwo == 6)
    {
        
        return "you rolled Box Cars: Two 6s";
    }
    else if (diceOne + diceTwo == 7 || diceOne + diceTwo == 11)
    {
        
        return $"you rolled {diceOne} and {diceTwo} A total of 7 or 11 YOU WINNN!!!";
    }
    
    
    else
    {
        
        return $"you rolled {diceOne} and {diceTwo}";

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



