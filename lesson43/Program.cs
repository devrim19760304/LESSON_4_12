// in the previous lesson we have seen if we enter a string or char instead of a integer
// our program crashes. We do not want it. Any application or program SHOULD HANDEL ERROR not crash
// you cannot expect from user to enter always data types. 

//in this tutorial we will try to fix this problem

// and we will calculate a circle circumference (perimeter) and area of circle. 

using System;
namespace lesson43
{
    internal class Program 
    {
        static void Main(string[] args)
        {

            //as last time let us say our small operation will multiply given number by 10 and returns the result

            Console.WriteLine("Enter a number and i will multiply it by 10");

            //for now let us get input as text to make easier

            // we add also ? "question mark after type declaration to eliminate warning"

            string? userInputText=Console.ReadLine();

            //now we use TryParse Method
            //this method returns a boolean value. 
            // (datatype.TryParse, out int newOutput) returns false or true

            if (int.TryParse(userInputText,out int userInputNumber )) 
            {
                //let us also us a vertabim string 
                string dataText=$@"
                ------------------
                You have entered a correct data type
                The Number you have entered is {userInputNumber}
                and its datatype indeed {userInputNumber.GetType()}
                I can proceed operation
                and  10x{userInputNumber}={userInputNumber*10}
                ";
                Console.WriteLine(dataText);
                
            }
            else 
            {
                //if this is not a number or user inputs a string, char instead of number let computer handel this error

                Console.WriteLine($"it is not a number Please provide a number");
                 
                

            }

            //and now also we get 2 double numbers from console and add them 
            // get first double number 
            Console.WriteLine("Enter r diameter value : ");
            string? rText=Console.ReadLine();

            Console.WriteLine("Enter PI number ");
            string? piText=Console.ReadLine();

            // now we will use if and "and" condition assure two given numbers are really double

            if (double.TryParse(rText, out double r ) && double.TryParse(piText, out double pi)) 
            {
                Console.WriteLine("both inputs are valid i can proceed");
                double areaOfCircle=pi*r*r;
                double circumCircle=2*pi*r;
                Console.WriteLine($"Area: {areaOfCircle}\nCircumference:{circumCircle}\n");
                Console.WriteLine(new string('-',50));
            }
            else 
            {
                Console.WriteLine("Invalid Data. Please enter a double values");
            }




        }
    }
}
