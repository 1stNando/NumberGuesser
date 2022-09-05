using System;

namespace NumberGuesser
{
    class Program
    {
        //Create a list to represent the range of numbers based on what the user inputs.


        //Greeting
        static void DisplayGreeting()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("Welcome to the worlds smartest number guessing machine!");
            Console.WriteLine("-----------------");
            Console.WriteLine();
            Console.WriteLine();
        }
        static void Main(string[] args)
        {

            //Method to call for greeting
            DisplayGreeting();

            //Method 1: Start
            //Display Greeting with instructions to the user

            //Method 2: Get user response

            //1st step: Is your number >= 511?

            //If user response is greater than 511, then branch to greater index.
            //If user response is less than 511, then branch to lesser index.
            //Branch happens here.

            //ComputeNewLow IS THE SAME AS saying: "Ok, your number is lower. Let me compute a lower index."
            //ComputeNewHigh IS THE SAME AS saying: "Ok, your number is higher. Let me compute a higher index."

            //First define what it means to ComputeNew...
            //From 1st step,
            //If the user input is greater than 511 Then run ComputeNewHigh.
            //If the user input is less than 511 Then run ComputeNewLow.


            //Method 2: Continued..
            //Create a method to call for the STEPS 1st to 10th
            static string PromptForUserInput(string prompt)
            {
                Console.WriteLine("Is your number >= 511");
                //State the 1st STEP
                if (UserInput >= [511])
                {
                    ComputeNewHigh2nd
                }
                else (ComputeNewLow2nd)
            }




























        }








    }
}
