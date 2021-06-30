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
    public static void breakingRecords(List<int> scores)
    {
        var max_count=0;
        var min_count=0;
        var max=scores[0];
        var min=scores[0];
        for(int i=1;i<scores.Count;i++)
        {
            if(scores[i]>max)
            {
                max=scores[i];
                max_count++;
            }
            else if(scores[i]<min)
            {
                min=scores[i];
                min_count++;
            }
        }
        System.Console.WriteLine(max_count+" "+min_count);        
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

        Result.breakingRecords(scores);
    }
}
