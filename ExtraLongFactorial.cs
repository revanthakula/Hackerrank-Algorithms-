using System.CodeDom.Compiler;
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
using System.Numerics;
using System;
/*
Link:https://www.hackerrank.com/challenges/extra-long-factorials/problem
*/
class Result
{
    public static void extraLongFactorials(int n)
    {
        BigInteger factorial= new BigInteger(1);
        for(int i = 1; i <= n; i++)
        {
            factorial =factorial*i;
        }
        Console.WriteLine(factorial);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.extraLongFactorials(n);
    }
}
