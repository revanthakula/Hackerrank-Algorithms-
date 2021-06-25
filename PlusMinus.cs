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
    public static void plusMinus(List<int> arr,int n)
    {
        var z=0,
        var p=0;
        var m=0;
        for(int i=0;i<arr.Count;i++)
        {
            if(arr[i]==0) z++;
            if(arr[i]>0) p++;
            if(arr[i]<0) m++;
        }
        System.Console.WriteLine((double) p/n);
        System.Console.WriteLine((double) m/n);
        System.Console.WriteLine((double) z/n);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr,n);
    }
}
