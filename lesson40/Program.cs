using System;

namespace lesson40
 {

    internal class Program 
    {
        static void Main(string[] args)
        {
            /*
            double firstNumber=12;
            double secondNumber=34;

            double result=firstNumber+secondNumber;
            Console.WriteLine(result);
            */

            for (int i=0;i<10;i++)
            {
                
                for (int j=0;j<10;j++)
                {
                    Console.WriteLine(TotalSum(i,j));
                    
                    
                }
                
            }

        } //end of main method 

        //my methods will come here
        public static double TotalSum(double number1, double number2)
        {

            
            double result=number1+number2;
            return result;
        }
    }
 }