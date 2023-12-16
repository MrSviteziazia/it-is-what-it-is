class Prog
{
    static void Main()
    {
        double[] numbers = { 1.14, 2.71, 3.55, 4.618, 5.2, 6.7 };
        double max = numbers[0];
        double min = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }

            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }
        double difference = max - min;

        Console.WriteLine($"Макс элемент: {max}");
        Console.WriteLine($"Мин элемент: {min}");
        Console.WriteLine($"Разница между макс и мин элементами: {difference}");

        Console.ReadLine();
    }
}