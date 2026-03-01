using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        string input1 = Console.ReadLine();

        Console.WriteLine("Enter the second number:");
        string input2 = Console.ReadLine();

        try
        {
            int num1 = Convert.ToInt32(input1);
            int num2 = Convert.ToInt32(input2);

            int result = num1 / num2;

            Console.WriteLine("Result: " + result);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter valid numeric values.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: You cannot divide by zero.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: The number entered is too large.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected error: " + ex.Message);
        }

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}