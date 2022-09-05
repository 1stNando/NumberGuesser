# NumberGuesser

## To push to github

If you selected `Y` during `dotnet new` you can add your changes and push to github with:

1. `git add .`
1. `git commit -m "Here I describe my changes"`
1. `git push`

Otherwise do the following _ONCE_ before using the steps above.

1. `git init`
1. `git add .`
1. `git commit -m "Initial Commit"`
1. `sdg hubCreate`
1. `git push -u origin HEAD`

## PROTIP:

When you are complete with the project and have turned it in to your instructor, update README.md with details about the assignment.

{

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
/////////////////////////////////////////////////////
STEPS:
//2nd step:
If user input is lower, then run:
//ComputeNewLow: Is your number >= 255?

If user input is higher, then run:
//ComputeNewHigh: Is your number >= 767?

//3rd step:
Repeat statement from 2nd step
//ComputeNewLow: Is your number >= 127?

Repeat statement from 2nd step
//ComputeNewHigh: Is your number >= 895?

//4th step:
//ComputeNewLow: Is your number >= 63?

//ComputeNewHigh: Is your number >= 959?

//5th step:
//ComputeNewLow: Is your number >= 32?

//ComputeNewHigh: Is your number >= 991?

//6th step:
//ComputeNewLow: Is your number >= 16?

//ComputeNewHigh: Is your number >= 1007?

//7th step:
//ComputeNewLow: Is your number >= 8?

//ComputeNewHigh: Is your number >= 1015?

//8th step:
//ComputeNewLow: Is your number >= 4?

//ComputeNewHigh: Is your number >= 1019?

//9th step:
//ComputeNewLow: Is your number >= 2?

//ComputeNewHigh: Is your number >= 1021?

//10th step:
//ComputeNewLow: Is your number >= 1?

//ComputeNewHigh: Is your number >= 1022?
////////////////////////////////////////////

//METHOD 3:
//If UserInput == [indexOfStep#], terminate program and congratulate user!
