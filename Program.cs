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
Console.Write(input);
Console.WriteLine(" was a great guess!");