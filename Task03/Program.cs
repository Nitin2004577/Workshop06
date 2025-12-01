public class Program
{
    public void ProcessNumbers(int[] numbers, Func<int, bool> condition)
    {
        // Loop through all numbers in the array
        foreach (int number in numbers)
        {
            // If the condition returns true, print the number
            if (condition(number))
            {
                Console.WriteLine(number);
            }
        }
    }

    public static void Main()
    {
        // Array of numbers to test
        int[] arrNum = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 23 };

        Program program = new Program();

        // Print only even numbers (condition: n % 2 == 0)
        Console.WriteLine("Even numbers:");
        program.ProcessNumbers(arrNum, n => n % 2 == 0);

        // Print only numbers greater than 10 (condition: n > 10)
        Console.WriteLine("\nNumbers greater than 10:");
        program.ProcessNumbers(arrNum, n => n > 10);
    }
}