//we will create an easy BMI calculator 
// user input weight (kg) height (cm) 
// first method will return bmi index
//second method will get this bim index and validate 
// formula for BMI index for kg and cm
// BMI = (weight / (height * height)) * 10000

// BMI Classification:
// BMI < 18.5         : Underweight
// BMI 18.5 - 24.9    : Normal weight
// BMI 25.0 - 29.9    : Overweight
// BMI 30.0 - 34.9    : Obesity Class I
// BMI 35.0 - 39.9    : Obesity Class II
// BMI >= 40.0        : Obesity Class III (Severe)


// additional: handle wrong data input 

using System;

namespace lesson41
{
    internal class Program
    {
        // Global variable to keep the program running
        public static bool program = true;

        static void Main(string[] args)
        {
            while (program)
            {
                ShowMenu(); // Display the menu
                string? choice = Console.ReadLine()?.Trim();

                switch (choice)
                {
                    case "1":
                        AddNewClient(); // Option to add a new client
                        break;
                    case "2":
                        Console.WriteLine("Exiting the program. Goodbye!");
                        program = false; // Exit the program
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please choose 1 or 2.");
                        break;
                }
            }
        }
        //end of main program 

        // Method to display the menu
        public static void ShowMenu()
        {
            string menu = @$"
--------------------------------------------------
BMI CALCULATOR - MAIN MENU
--------------------------------------------------
1 - Add New Client
2 - Exit Program
--------------------------------------------------
Please enter your choice: ";
            Console.Write(menu);
        }

        // Method to add a new client
        public static void AddNewClient()
        {
            Console.Clear();

            string clientPrompt = @$"
--------------------------------------------------
ADD NEW CLIENT
--------------------------------------------------";
            Console.WriteLine(clientPrompt);

            try
            {
                Console.Write("Enter client's name: ");
                string? name = Console.ReadLine();

                Console.Write("Enter weight (kg): ");
                if (!double.TryParse(Console.ReadLine(), out double weight))
                {
                    Console.WriteLine("\nInvalid weight input! Please enter a valid number.");
                    return;
                }

                Console.Write("Enter height (cm): ");
                if (!double.TryParse(Console.ReadLine(), out double height))
                {
                    Console.WriteLine("\nInvalid height input! Please enter a valid number.");
                    return;
                }

                // Calculate BMI and validate
                double bmi = BmiValue(weight, height);
                string classification = BmiValidation(bmi);

                string result = @$"
                --------------------------------------------------
                {name}'s BMI Report
                --------------------------------------------------
                Weight: {weight} kg
                Height: {height} cm
                BMI: {bmi}
                Classification: {classification}
                --------------------------------------------------";
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nAn unexpected error occurred: {ex.Message}");
            }

            // Prompt to continue or exit
            Console.Write("\nWould you like to add another client? (yes/no): ");
            string? response = Console.ReadLine()?.Trim().ToLower();
            if (response != "yes")
            {
                program = false;
            }
        }

        // Method to calculate BMI
        public static double BmiValue(double weight, double height)
        {
            double bmi = (weight / (height * height)) * 10000;
            return Math.Round(bmi, 2);
        }

        // Method to classify BMI
        public static string BmiValidation(double bmi)
        {
            return bmi switch
            {
                < 18.5 => "Underweight",
                >= 18.5 and <= 24.9 => "Normal weight",
                >= 25.0 and <= 29.9 => "Overweight",
                >= 30.0 and <= 34.9 => "Obesity Class I",
                >= 35.0 and <= 39.9 => "Obesity Class II",
                >= 40.0 => "Obesity Class III (Severe)",
                _ => "Invalid BMI"
            };
        }
    }
}
