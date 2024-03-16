namespace ConsoleApp1;

public class Utilities
{

    public static double AverageNumber(int[] numbers)

    {
        return numbers.Sum() / numbers.Length;
    }

    public static int MaxElement(int[] numbers)
    {
        return numbers.Max();
    }
}