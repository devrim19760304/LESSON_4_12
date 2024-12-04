// In this lesson, we will create a method to calculate 
// the area and perimeter of a circle. 
// 
// Formulas:
// Area = π * radius * radius (show π as pi and get it 3.1415)
// Perimeter = 2 * π * radius
//
// Instructions:
// - Use the TryParse method to handle user input:
//   <type>.TryParse(<type> input, out <type> output)
// - TryParse returns a boolean value.
// - Use an if statement with "and" conditions to ensure both requirements are satisfied.

// add a while loop until user exit with key input "x" for example 

using System;
namespace lesson44
{
    internal class Program 
    {
        static void Main(string[] args)
        {

            // main method 

            // here we assume user input so it must be string not number 

            //CircleCalculations("7","3.14");

            //add here user input for radius and hard-coded pi number



        } // end of our main method 

        //we add methods here 
        // create a static method

        public static void CircleCalculations(string rText,string piText) 
        {
            if (double.TryParse(rText,out double r) && double.TryParse(piText,out double pi) )
            {
                double area=pi*r*r;
                double perimeter=2*pi*r;

                // create a vertabim string 
                string circleData=@$"
                --------------------
                diamater: {r}
                pi      : {pi}

                Area      : {area}
                Perimeter : {perimeter}

                --------------------
                
                ";

                Console.WriteLine(circleData);

            }

        }
    }
}