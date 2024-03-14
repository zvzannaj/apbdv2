static double GetAverage(int[] tab)
{
    double result = 0.0;
    for (int i = 0; i < tab.Length; i++)
    {
        result += tab[i];
    }

    return result / tab.Length;
}   
  