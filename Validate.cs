using System;

namespace AreaPerimeter_calculator_program
{
    //A class to Validate inputs
    internal class Validate
    {
        //A public method to validate the user inputs
        public int ValidateInput()
        {
            //Declares two variables to be used in the method
            int UserInput = 0;
            bool IsValid = false;
            //Validation to check that the input from the user is an integer and above 0
            while (IsValid == false)
            {
                try
                {
                    UserInput = Int32.Parse(Console.ReadLine());
                    if (UserInput <= 0)
                    {
                        Console.WriteLine("Please enter a number greater than 0!");
                    }
                    else
                    {
                        //Exits out of the validation while loop if the criteria for a valid input is met
                        IsValid = true;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a number!");
                }
            }
            return UserInput;
        }
    }
}