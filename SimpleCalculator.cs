using System;

public class SimpleCalculator
{
    public void calculate()
    {
        try
        {
            // Prompt the user for two numbers
            Console.WriteLine("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Prompt the user for the desired operation
            Console.WriteLine("Select an operation: +, -, *, /");
            char operation = Console.ReadLine()[0];

            double result = 0;

            // Perform the selected operation using a switch case
            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine($"Result: {num1} + {num2} = {result}");
                    break;

                case '-':
                    result = num1 - num2;
                    Console.WriteLine($"Result: {num1} - {num2} = {result}");
                    break;

                case '*':
                    result = num1 * num2;
                    Console.WriteLine($"Result: {num1} * {num2} = {result}");
                    break;

                case '/':
                    if (num2 == 0)
                    {
                        // Handle division by zero error
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    else
                    {
                        result = num1 / num2;
                        Console.WriteLine($"Result: {num1} / {num2} = {result}");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid operation selected.");
                    break;
            }
        }
        catch (FormatException ex)
        {
            // Handle invalid number format input
            Console.WriteLine("Error: Invalid number format. Please enter numeric values.");
        }
        catch (Exception ex)
        {
            // Handle any other unforeseen errors
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
