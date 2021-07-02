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
Problem name:Strange Advertising
Link:https://www.hackerrank.com/challenges/strange-advertising/problem
*/

class Result
{
    public static void viralAdvertising(int n)
    {
        var shared=5;
        var liked=2;
        var total=2;
        for(int i=2;i<=n;i++)
        {
            shared=liked*3;
            liked=shared/2;
            total=total+liked;
        }
        System.Console.WriteLine(total);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.viralAdvertising(n);
    }
}
