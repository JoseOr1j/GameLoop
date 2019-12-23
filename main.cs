/* MECHANICS AND RULES:
 While i is less than j then the loop will state the values of i and j. j is being incremented by one, while i is being multiplied by 2.
 The point of the game is to catch up to the value of j to 
 become an awesome player, although you can put close numbers such as (0,1), (0,2), (1,2), there is no fun in putting small numbers, go big for j and see how fast i catches up!*/

using System;
using static System.Console;
namespace Games
{
  // begin Main class 
class MainClass {
  // begin Main Program
  public static void Main (string[] args) {
    // Asks user to play 
    WriteLine("PLAY? Yes/No?");
    // Reads response, no need to convert
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
    WriteLine("You are currently not awesome yet player " + name);
    WriteLine("Let us begin! Enter two values integer values, one small and one big to begin the game.");
    // declares and converts integer values into string literals
    int BIG = Convert.ToInt32(ReadLine());
    int SMALL = Convert.ToInt32(ReadLine());
    // states your chosen values
    WriteLine("Your selcted values are: " + BIG + " " +  "and" + " " + SMALL);
    WriteLine("GAME START!");
    // begin while loop 
while (BIG < SMALL)
{
  // if i is greater than j then the game ends
  if(BIG > SMALL)
  {
    break;
  }
  // if the i is less than j then the game continues
  else 
  {
    WriteLine("You are not awesome YET! player: " + name);
  }
  // states values to make it easy to see the progress of the j and i
WriteLine(SMALL);
SMALL++;
// slower pace j incremented by 1
WriteLine(BIG);
BIG++;
// faster paced i multiplied by 2
BIG = BIG * 2;
}
// end of loop
WriteLine("You are now awesome! player: " + name);
// thanks user and asks if they would like to play again
WriteLine("Thank you for playing my game, wanna go again? Yes/No?");
// reads input
playAgain = ReadLine();
// if input is a N or n for No then the game ends 
 if(playAgain == "No" || playAgain == "no")
    WriteLine("GAME END");
}
  }

  }
}
