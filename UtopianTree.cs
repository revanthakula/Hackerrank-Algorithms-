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
Problem name:utopian-tree
Link:https://www.hackerrank.com/challenges/utopian-tree/problem
*/

class Result
{
    public static void utopianTree(int n)
    {
        var height=1;
        for(int i=1;i<=n;i++)
        {
            if(i%2==0) height=height+1;
            else height=2*height;
        }
        System.Console.WriteLine(height);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            Result.utopianTree(n);
        }
    }
}
