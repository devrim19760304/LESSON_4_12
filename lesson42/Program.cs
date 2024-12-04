//in this tutorial we will see error handling first we enter a number from console and convert to integer. 

using System.Numerics;

namespace lesson42
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            //let us get a integer number from console
            Console.WriteLine("enter a whole number ");
            //so we know console input is only string we need to convert it from string to integer
            string? firstNumberText=Console.ReadLine();
            //then we can convert string to integer number
            //convert method is okay but what if the user enter a string or char instead of integer

            int firstNumber=Convert.ToInt32(firstNumberText);

            Console.WriteLine($"You have entered number {firstNumber}");


            //in this case our program crashes. 
            //we do not want our program crash. We want to handle ERROR . we will see it in next tutorial 

            //---------------------------------------------------------------------------------------

            //let us do same thing with char 
            Console.WriteLine("you want to quit program (y/n ?)");

            //convert input from string to char 
            // as first step we get input as string
            //we also convert input to lower case in case user use Y or y. 
            string? quitProgramText = (Console.ReadLine() ?? "").ToLower();

            //as second step we convert it to char   
            // i trim the first letter of the string in to get first char of the whole string    

            char quitProgram=Convert.ToChar(quitProgramText[0]);
            Console.WriteLine($"you have entered  {quitProgram} and data type is {quitProgram.GetType()}");


            
        }
    }
}