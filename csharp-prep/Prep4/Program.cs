using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = GetUserNumbers();

        int sum = ComputeSum(numbers);
        Console.WriteLine($"The sum is: {sum} ");

        float average = ComputeAverage(sum, numbers.Count);
        Console.WriteLine($"The average is: {average} ");

        int max = FindMax(numbers);
        Console.WriteLine($"The max is: {max} ");

    }

    static List<int> GetUserNumbers()
    {
        List<int> numbers = new List<int>();
        int userNumber = -1;

        while (userNumber !=0)
        {
            Console.Write("Enter a number (0 to quit): ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber !=0)
            {
                numbers.Add(userNumber);
            }
        }

        return numbers;
    }
    
    static int ComputeSum(List<int> numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum;
    }

    static float ComputeAverage(int sum, int count)
    {
        return ((float)sum) / count;
    }

    static int FindMax(List<int> numbers)
    {
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        return max;
    }
}