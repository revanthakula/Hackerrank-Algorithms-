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
    public static void migratoryBirds(List<int> arr)
    {
        arr.Sort();
        int[] freq={0,0,0,0,0};
        var max=0;
        var type=0;
        for(int i=1;i<=5;i++)
        {   
            for(int j=0+freq[i-1];j<arr.Count;j++)
            {
                if(arr[j]==i)
                {
                    freq[i-1]++;
                }
            }
            if(freq[i-1]>max)
            {
                type=i;
                max=freq[i-1];
            }    
        }
        System.Console.WriteLine(type);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.migratoryBirds(arr);
    }
}
