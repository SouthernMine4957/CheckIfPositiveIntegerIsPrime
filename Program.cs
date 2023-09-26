using System;

class Program
{
    static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false; // 0 and 1 are not prime numbers
        }

        if (number <= 3)
        {
            return true; // 2 and 3 are prime numbers
        }

        if (number % 2 == 0 || number % 3 == 0)
        {
            return false; // Numbers divisible by 2 or 3 are not prime
        }

        // Check for prime using 6k +/- 1 rule
        for (int i = 5; i * i <= number; i += 6)
        {
            if (number % i == 0 || number % (i + 2) == 0)
            {
                return false; // If divisible by any number in the form of 6k +/- 1, it's not prime
            }
        }

        return true; // If not divisible by any smaller prime, it's prime
    }

    static void Main()
    {
        Console.WriteLine("Enter a positive integer:");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (IsPrime(number))
            {
                Console.WriteLine($"{number} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a prime number.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid positive integer.");
        }
    }
}
