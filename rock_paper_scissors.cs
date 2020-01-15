using System;
using static System.Console;
using static System.Math;
namespace Bme121
{
	static class Program
	{
        static Random rGen = new Random( );

        static void Main( )
		{
            bool continueGame = true;
            bool playAgain = true;
            int userScore = 0;
            int cpuScore = 0;
            
            while (playAgain == true)
            {

                WriteLine("{--- WELCOME TO ROCK, PAPER, SCISSORS ---}");
                WriteLine();
                Write("Please enter your preferred name: ");
                string userName = ReadLine();
                Clear();
                
                while (continueGame == true)
                {
                    WriteLine("     {--- ROCK PAPER SCISSORS ---}");
                    WriteLine();
                    WriteLine("               SCORE");
            
                    WriteLine("         {0}: {1}     CPU: {2}", userName, userScore, cpuScore);
                    WriteLine();
                    Write("Choose ROCK, PAPER, or SCISSORS: ");
                    
                    string userOutput = ReadLine();
                    int userOut = 0;
                    if (userOutput == "ROCK") {userOut = 1;}
                    else if (userOutput == "PAPER") {userOut = 2;}
                    else if (userOutput == "SCISSORS") {userOut = 3;}
                    
                    int cpuOut = rGen.Next(1,3);
                    string cpuOutput;
                    
                    if (cpuOut == 1) {cpuOutput = "ROCK";}
                    else if (cpuOut == 2) {cpuOutput = "PAPER";}
                    else if (cpuOut == 3) {cpuOutput = "SCISSORS";}
                    else { cpuOutput = "";}
                    
                    WriteLine("         {0}: {1}     CPU: {2}", userName, userOutput, cpuOutput);
                    WriteLine();
                    
                    if ((cpuOut == 1 && userOut == 1) || (cpuOut == 2 && userOut == 2) || (cpuOut == 3 && userOut == 3))
                    {
                        WriteLine("Round Tied");
                    }
                    else if ((cpuOut == 1 && userOut == 2) || (cpuOut == 2 && userOut == 3) || (cpuOut == 3 && userOut == 1))
                    {
                        WriteLine("{0} wins the Round", userName);
                        userScore++;
                    }
                    else if ((userOut == 1 && cpuOut == 2) || (userOut == 2 && cpuOut == 3) || (userOut == 3 && cpuOut == 1))
                    {
                        WriteLine("CPU wins the Round");
                        cpuScore++;
                    }
                    
                    if (cpuScore == 5)
                    {
                        WriteLine("The CPU wins the game");
                        continueGame = false;
                    }
                    
                    else if (userScore == 5)
                    {
                        WriteLine("{0} wins the game", userName);
                        continueGame = false;
                    }
                }
                 
                Write("Would you like to play again (Y for yes, N for No): ");
                    string userResponse = ReadLine();
                    
                    if (userResponse == "Y")
                    {
                        playAgain = true;
                    }
                    else if (userResponse == "N")
                    {
                        playAgain = false;
                    }
            }
		}
	}
}
