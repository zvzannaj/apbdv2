static double GetAverage(int[] number)
{
    double result = 0.0;
    for (int i = 0; i < number.Length; i++)
    {
        result += number[i];
    }

    return result / number.Length;
}   
  