using System;

Console.WriteLine("Welcome to my game! Would you like to play on Easy, Medium, or Hard mode?");
string difficultyLevel = Console.ReadLine().ToLower();

while (difficultyLevel == "easy")
{
    Console.WriteLine("Okay! Easy mode, it is!");
    PlayGame(8);
    return;
}
while (difficultyLevel == "medium")
{
    Console.WriteLine("Okay! Medium mode, it is!");
    PlayGame(6);
    return;
}
while (difficultyLevel == "hard")
{
    Console.WriteLine("Okay! Hard mode, it is!");
    PlayGame(4);
    return;
}
while (difficultyLevel != "easy" || difficultyLevel != "medium" || difficultyLevel != "hard")
{
    Console.WriteLine("That was not an option. You're not invited anymore.");
    return;
}


void PlayGame(int numOfTriesValue)
{
    Console.WriteLine("Can you guess the number I'm thinking of?");
    Console.Write("Your best guess: ");

    Random rnd = new Random();
    int secretNum = rnd.Next(1, 101);
    string Input = Console.ReadLine();

    for (int numOfTries = numOfTriesValue; numOfTries > 0; numOfTries--)
    {
        if (Int32.Parse(Input) == secretNum)
        {
            Console.WriteLine("You guessed the number I was thinking of!");
            return;
        }
        else if (Int32.Parse(Input) != secretNum && numOfTries == 1)
        {
            Console.WriteLine("Nice try. But now you owe me your firstborn.");
        }
        else if (Int32.Parse(Input) > secretNum && numOfTries == 2)
        {
            Console.WriteLine("That was a great guess, but it was too high!");
            Console.Write("You have ");
            Console.Write(numOfTries - 1);
            Console.WriteLine(" try left. You may try again now.");
            Input = Console.ReadLine();
        }
        else if (Int32.Parse(Input) > secretNum)
        {
            Console.WriteLine("That was a great guess, but it was too high!");
            Console.Write("You have ");
            Console.Write(numOfTries - 1);
            Console.WriteLine(" tries left. You may try again now.");
            Input = Console.ReadLine();
        }
        else if (Int32.Parse(Input) < secretNum && numOfTries == 2)
        {
            Console.WriteLine("That was a great guess, but it was too low!");
            Console.Write("You have ");
            //int counter = 3;
            Console.Write(numOfTries - 1);
            Console.WriteLine(" try left. You may try again now.");
            Input = Console.ReadLine();
        }
        else if (Int32.Parse(Input) < secretNum)
        {
            Console.WriteLine("That was a great guess, but it was too low!");
            Console.Write("You have ");
            //int counter = 3;
            Console.Write(numOfTries - 1);
            Console.WriteLine(" tries left. You may try again now.");
            Input = Console.ReadLine();
        }
    }
}


/* ------------------------Phase 1-----------------------------------
The program should...

Display a message to the user asking them to guess the 
secret number.
Display a prompt for the user's guess.
Take the user's guess as input and save it as a variable.
Display the user's guess back to the screen.
----------------------------Phase 1----------------------------------*/

/* ------------------Phase 2-----------------------------
The program should be updated to...

Create a variable to contain the secret number. This 
number should be hard-coded for now. 42 is a nice number.
No longer display the user's guess. They know what they 
guessed, right?
Compare the user's guess with the secret number. 
Display a success message if the guess is correct, 
otherwise display a failure message.
--------------------Phase 2----------------------------*/

/*---------------------Phase 3--------------------------
The program should be updated to...

Give the user four chances to guess the number.
Continue to display the success or failure messages 
as in phase 2

-----------------------Phase 3------------------------*/

/*---------------------Phase 4--------------------------
The program should be updated to...

Display the number of the user's current guess in 
the prompt. For example, if the user has already guessed
one time, the prommpt should say something like Your 
guess (2)>.
End the loop early if the user guesses the correct number.
----------------------Phase 4---------------------------*/


/*--------------------Phase 5---------------------------
The program should be updated to...

Use a random number between 1 and 100 instead of a 
hard-coded number.
The prompt should display the number of guesses the 
user has left.
---------------------Phase 5---------------------------*/

/*-------------------Phase 6----------------------------
The program should be updated to...

Inform the user if their guess was too high or too low, 
when they guess incorrectly.
---------------------Phase 6---------------------------*/

/*-------------------Phase 7----------------------------
The program should be updated to...

Prompt the user for a difficulty level before they are 
prompted to guess the number.
The difficulty level should determine how many guesses 
the user gets. The difficulty levels should be:
Easy - this gives the user eight guesses.
Medium - this gives the user six guesses.
Hard - this gives the user four guesses.
---------------------Phase 7---------------------------*/