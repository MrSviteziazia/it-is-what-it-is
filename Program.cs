class Prog
{
    static void Main()
    {
        int[] numbers = { 1, 25, 3, 45, 5, 6, 74, 8, 9, 10 };

        int CountN = CountEvenNumbers(numbers);

        Console.WriteLine($"Количество чётных чисел в массиве: {CountN}");

        Console.ReadLine();
    }

    static int CountEvenNumbers(int[] arr)
    {
        int count = 0;
        foreach (int num in arr)
        {
            if (num % 2 == 0)
            {
                count++;
            }
        }

        return count;
    }
}