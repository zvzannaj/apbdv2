static double GetAverage(int[] numbers)
{
    double result = 0.0;
    for (int i = 0; i < numbers.Length; i++)
    {
        result += numbers[i];
    }

    return result / numbers.Length;
}
