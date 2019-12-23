/* Designed and created by: Jose Orozco. 
Purpose: A Looping Game, created: 12/23/19
RULES AND MECHANICS: A game in where the user has to input two values one smaller and the other bigger.
The smaller value will be multiplied by 2 every turn (loop) and the bigger value will be incremented by
1 every turn (loop). The smaller value must be initially smaller in order to properly play, examples like:
(s -> smaller, b -> bigger) (s,b) -> (2,0) Results in an automatic win.
(0,100) Results in a longer lasting game.*/

using System;
using static System.Console;
namespace Games
{
  // begin Main class 
class MainClass {
  // begin Main Program
  public static void Main (string[] args) {
    // asks user to play 
    WriteLine("Would you like to play this Looping Game? Yes/No?");
    // reads response, no need to convert
    string playAgain = ReadLine();
    // if playAgain is a NO response then the game ends
    if(playAgain == "No" || playAgain == "no")
    WriteLine("GAME END");

// while playAgain is a Yes reponse the game continues
    while (playAgain == "Yes" || playAgain == "yes")
{
  // Prompts user for their name
    WriteLine("What is your name, Player?");
    // gets players name
    string name = ReadLine();
    // What is said before the game begins
    WriteLine("Welcome Player: " + name);
    WriteLine("Let us begin! Enter two values integer values, one small and one big to begin the game.");
    // declares and converts integer values into string literals
    int SMALL = Convert.ToInt32(ReadLine());
    int BIG = Convert.ToInt32(ReadLine());
    // states your chosen values
    WriteLine("Your selcted values are: " + SMALL + " " +  "and" + " " + BIG);
    /*WriteLine("Press any key to begin");
    ReadKey(); // To make the game pause, removed for speed
    WriteLine(" ");*/
  
    WriteLine("GAME START!");
    // begin while loop 
while (SMALL <= BIG)
{
  // if small is greater than big then the game ends
  if(SMALL >= BIG)
  {
    break;
  }
  // if the small is less than big then the game continues
  else 
  {
    WriteLine("You have not caught up to the bigger value, Player: " + name);
  }
  // states values to make it easy to see the progress of the small and big
WriteLine(SMALL);
SMALL++;
SMALL = SMALL * 2;
// faster paced small value multiplied by 2
WriteLine(BIG);
BIG++;
// slower paced big value incremented by 1
}
// end of loop
WriteLine("You caught up to the bigger value! Player: " + name + "!");
// thanks user and asks if they would like to play again
WriteLine("Thank you for playing my game, want to go again? Yes/No?");
// reads input
playAgain = ReadLine();
// if input is a No or no then the game ends
 if(playAgain == "No" || playAgain == "no")
    WriteLine("GAME END!");
}
  }

  }
}
// To Do: Add exception handling for I/O