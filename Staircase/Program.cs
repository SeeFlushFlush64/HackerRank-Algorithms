﻿using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'staircase' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void staircase(int n)
    {
        //Manual Solution
        // for (int i = 1; i <= n; i++)
        // {
        //     for (int j = n - i; j > 0; j--)
        //     {
        //         Console.Write(" ");
        //     }
        //     for (int k = 1; k <= i; k++)
        //     {
        //         Console.Write("#");
        //     }
        //     if (i != n)
        //     {
        //         Console.WriteLine();
        //     }
        // }

        //StringBuilder solution

        for (int i = 1; i <= n; i++)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(' ', n - i);
            sb.Append('#', i);
            Console.WriteLine(sb);
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.staircase(n);
    }
}
