namespace ConsoleApp1;

public static class Utility
{
    public static double CalculateAverage(int[] number)
    {
        return number.Sum() / number.Length;
    }
}