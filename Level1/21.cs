// #21 : 직사각형 별찍기

using System;
using System.Collections.Generic;
using System.Text;

public class Example
{
    public static void Main()
    {
        Console.Clear();

        String[] s = Console.ReadLine().Split(' ');

        int a = Int32.Parse(s[0]);
        int b = Int32.Parse(s[1]);

        StringBuilder sbRow = new StringBuilder();

        for (int i = 0; i < a; i++)
        {
            sbRow.Append("*");
        }

        for (int i = 0; i < b; i++)
        {
            Console.WriteLine(sbRow.ToString());
        }
    }
}