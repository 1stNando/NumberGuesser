using System;
using System.Collections.Generic;
namespace NumberGuesser
{
    class Program
    {
        //Create a list to represent the range of numbers based on what the user inputs.


        //Greeting
        //static void DisplayGreeting()
        //{
        //  Console.WriteLine("-----------------");
        //Console.WriteLine("Welcome to the worlds smartest number guessing machine!");
        //Console.WriteLine("-----------------");
        //Console.WriteLine();
        //Console.WriteLine();

        // static void Main(string[] args)

        //Method to call for greeting
        //   DisplayGreeting();

        //Method 1: Start
        //Display Greeting with instructions to the user

        //Get user response

        //1st step: Is your number >= 511?

        //If user response is greater than 511, then branch to greater index.
        //If user response is less than 511, then branch to lesser index.
        //Branch happens here.

        //ComputeNewLow IS THE SAME AS saying: "Ok, your number is lower. Let me compute a lower index."
        //ComputeNewHigh IS THE SAME AS saying: "Ok, your number is higher. Let me compute a higher index."

        //Define what ComputeNew is.

        //1st step: Is your number >= 511?
        //From 1st step,
        //If the user input is greater than 511 Then run ComputeNewHigh.
        //If the user input is less than 511 Then run ComputeNewLow.

        //static string PromptForUserInput(string prompt)
        //{
        //  Console.WriteLine("Is your number >= 511");
        //State the 1st STEP
        //  if (UserInput >= [511])
        //{
        //     ComputeNewHigh2nd

        //else (ComputeNewLow2nd)



        //Method 2: Continued..
        //Create a method to call for the STEPS 1st to 10th


        //////////////////////Guide from github user landoncass NumberGuesser Program.cs

        ///We need to set the range of our numbers to be 1-1024.
        //lowNumber, highNumber need to be defined.
        //We also need a variable to represent newGuess and set it equal to (lowNumber+highNumber)/2.

        static int lowNumber = 1;
        static int highNumber = 1024;
        static int newGuess = (lowNumber + highNumber) / 2;
        static string userInput = "";
        static int guessCounter = 0;
        static int gameCount = 0;

        //Now lets create a method to display initial greeting and stat game
        static void ShowGreeting()
        {
            Console.WriteLine("Welcome to #the world's smartest number guessing computer!!!");
        }
        //brag when correct (the end of the game)
        static void BragWhenCorrect()
        {
            Console.WriteLine("I told you baby! It's pure magic!");
        }

        //Here lets define how to compute a new low if guess is too low
        static void ComputeNewLowIfTooLow()
        {
            lowNumber = newGuess;
            newGuess = (highNumber + lowNumber) / 2;
        }

        //Here define the compute new high if too high
        static void ComputeNewHighIfTooHigh()
        {
            highNumber = newGuess;
            newGuess = (highNumber + lowNumber) / 2;
        }

        //lets now make a prompt for a string to tell the user "hey is this your number..."
        static string PromptForString()
        {
            Console.WriteLine($"Is your number {newGuess}? Answer higher, lower, or correct. ");
            userInput = Console.ReadLine();
            return userInput;
        }

        //Here we begin to define where the game can be played again if user says yes, or no
        static void PlayAgain()
        {
            ShowGreeting();
            Console.WriteLine("Think of a number greater than 1 but less than 10,000. Memorize it. It is your number. Then to begin the game first tell me another number that is way larger than your number. ");

            highNumber = Int32.Parse(Console.ReadLine());
            newGuess = (lowNumber + highNumber) / 2;
            guessCounter = 0;

            PromptForString();

            while (userInput != "correct")
            {
                //PromptForString();
                if (userInput == "higher")
                {
                    ComputeNewLowIfTooLow();
                    guessCounter = guessCounter + 1;
                    PromptForString();
                }
                else if (userInput == "lower")
                {
                    ComputeNewHighIfTooHigh();
                    guessCounter = guessCounter + 1;
                    PromptForString();
                }
                else
                {
                    Console.WriteLine("Please enter a valid answer: higher, lower, or correct.");
                    PromptForString();
                }
            }
            BragWhenCorrect();
            guessCounter = guessCounter + 1;
        }

        ///Here is the main body of the game
        static void Main(string[] args)
        {
            //Define what the list of guesses is exactly:
            var guessesList = new List<int>();
            int sumGuesses = 0;
            Console.WriteLine("How about playing a number guessing game with me? Yes or no?");


            //Lets make a looping statement to run the game as long as user does not say NO.
            while (Console.ReadLine() != "no")
            {
                PlayAgain();
                guessesList.Add(guessCounter);
                gameCount = gameCount + 1;
                Console.WriteLine($"It took me {guessCounter} tries!");
                Console.WriteLine("Would you like to play again? yes or no?");
            }
            ///Write code to create an average number of guesses and the counter for it
            for (var guess = 0; guess < guessesList.Count; guess++)
            {
                sumGuesses = sumGuesses + guessesList[guess];
            }
            int averageGuesses = sumGuesses / guessesList.Count;
            Console.WriteLine($"I averaged {averageGuesses} guesses to get the correct answer boo-Yahh!");
        }
    }
}
