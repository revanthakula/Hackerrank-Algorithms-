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
using System;
/*Problem Name: Sales By Match
Link:https://www.hackerrank.com/challenges/sock-merchant/problem*/
class Result
{
    public static int sockMerchant(int n, List<int> ar)
    {
        ar.Sort();
        var a=ar[n-1];
        var pairs=0;
        var count=0;
        var freq=0;
        for(int i=1;i<=a;i++)
        {
            for(int j=0+freq;j<n;j++)
            {
                if(i==ar[j])
                {
                    count++;
                }
            }
            pairs=pairs+(count/2);
            freq=count;
            count=0;
        }
        return pairs;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        int result = Result.sockMerchant(n, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
