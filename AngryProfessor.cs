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
Problem name:Angry professor
Link:https://www.hackerrank.com/challenges/angry-professor/problem
*/
class Result
{
    public static void angryProfessor(int k, List<int> a)
    {
        var count=0;
        for(int i=0;i<a.Count;i++)
        {
            if(a[i]<=0) count++;
        }
        if(count>=k) System.Console.WriteLine("NO");
        else System.Console.WriteLine("YES");
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            Result.angryProfessor(k, a);
        }
    }
}
