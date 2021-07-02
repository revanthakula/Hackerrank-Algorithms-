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

/*
Problem Name:Beautiful Days at the Movies
Link:https://www.hackerrank.com/challenges/beautiful-days-at-the-movies/problem
*/

class Result
{
    public static void beautifulDays(int i, int j, int k)
    {
        var count=0;
        for(int x=i;x<=j;x++)
        {
            var rev_str=new string(x.ToString().Reverse().ToArray());
            var rev_num=int.Parse(rev_str);
            if(Math.Abs(x-rev_num)%k==0) count++;   
        }
        System.Console.WriteLine(count);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int i = Convert.ToInt32(firstMultipleInput[0]);

        int j = Convert.ToInt32(firstMultipleInput[1]);

        int k = Convert.ToInt32(firstMultipleInput[2]);

        Result.beautifulDays(i, j, k);
    }
}
