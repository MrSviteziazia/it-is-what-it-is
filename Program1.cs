 class Number
{
    public static void PrintNumbers(int[] arr)
    {
        int num = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (90 > arr[i])
            {
                if (arr[i] > 20)
                {
                    num++;
                }
                Console.WriteLine(arr[i] + " ");
            }
        }
        Console.WriteLine();
        Console.WriteLine(num);
    }
}
class Prog
{
    static void Main()
    {
        int[] numbers = { 15, 25, 35, 45, 55, 65, 75, 85, 95 };
        Number.PrintNumbers(numbers);
        Console.ReadLine();
    }
}