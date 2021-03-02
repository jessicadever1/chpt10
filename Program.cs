using System;

/* ------------------------Phase 1-----------------------------------
The program should...

Display a message to the user asking them to guess the 
secret number.
Display a prompt for the user's guess.
Take the user's guess as input and save it as a variable.
Display the user's guess back to the screen.
----------------------------Phase 1----------------------------------*/

Console.WriteLine("Hey there, you! Can you guess the number I'm thinking of?");
Console.Write("Your best guess: ");
string input = Console.ReadLine();
//Console.Write(input);
//Console.WriteLine(" was a great guess!");


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
int secretNum = 42;
if (Int32.Parse(input) == secretNum)
{
    Console.WriteLine("You guessed the number I was thinking of!");
}
else
{
    Console.WriteLine("That was a great guess, but it wasn't the number I was thinking of!");
}