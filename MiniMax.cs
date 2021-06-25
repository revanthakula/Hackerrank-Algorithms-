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
    public static void miniMaxSum(List<long> arr)
    {   var sum=arr.Sum();
        var min=sum-arr[0];
        var max=sum-arr[0];
        for(var i=0;i<arr.Count;i++)
        {
            if(sum-arr[i]>max) max=sum-arr[i];
            if(sum-arr[i]<min) min=sum-arr[i];
        }
        System.Console.WriteLine(min+" "+max);
    }
}

class Solution
{
    public static void Main(string[] args)
    {

        List<long> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
