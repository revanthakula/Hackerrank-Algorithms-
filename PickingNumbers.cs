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

/*Link:https://www.hackerrank.com/challenges/picking-numbers/problem
Problem name:Picking Numbers*/

class Result
{
    public static int pickingNumbers(List<int> a)
    {
        a.Sort();
        var freq=0;
        var freq_sum=0;
        var prev_freq=0;
        var max_freq=0;
        var prev=a[0]-1;
        for(int i=a[0];i<=a[a.Count-1];i++)
        {
            for(int j=0+freq_sum;j<a.Count;j++)
            {
                if(i==a[j]) freq++;
                else break;
        
            }
            freq_sum=freq_sum+freq;
            if(Math.Abs(prev-i)<=1 && (prev_freq+freq)>max_freq)
            {
                max_freq=prev_freq+freq;
            }
            prev=i;
            prev_freq=freq;
            freq=0;
        }
        return max_freq;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = Result.pickingNumbers(a);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
