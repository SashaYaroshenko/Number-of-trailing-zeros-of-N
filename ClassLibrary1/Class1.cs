using System;
using System.Text.RegularExpressions;

public static class Kata
{
    public static int TrailingZeros(int n)
    {
        string pattern = @"[^0]\z|[^0][0]+\z";
        Regex regex = new Regex(pattern);
        int fact = 1;
        for(int i=2; i<=n; i++)
        {
            fact *= i;
            fact = int.Parse(regex.Match(fact.ToString()).ToString());
        }
        return fact.ToString().Length-1;
    }
}