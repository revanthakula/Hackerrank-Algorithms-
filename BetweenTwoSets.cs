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

class Result
{
    public static int getTotalX(List<int> a, List<int> b)
    {
        var f=0;
        var g=0;
        var count=0;
        for(int i=a[0];i<=b[0];i++)
        {
            for(int j=0;j<a.Count;j++)
            {
                if(i%a[j]==0)
                {
                    f++;
                }
                else break;
            }
            if(f==a.Count)
            {
                for(int k=0;k<b.Count;k++)
                {
                    if(b[k]%i==0)
                    {
                        g++;
                    }
                    else break;
                }    
            }
            if(g==b.Count) count++;
            f=0;
            g=0;                            
        }
        return count;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

        int total = Result.getTotalX(arr, brr);

        textWriter.WriteLine(total);

        textWriter.Flush();
        textWriter.Close();
    }
}
