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
Link:https://www.hackerrank.com/challenges/append-and-delete/problem
*/

class Result
{
    public static void appendAndDelete(string s, string t, int k)
    {
        var str="";
        var count=0;
        var i=0;
        var flag=0;
        if(s==t)
        {
            if(k>=2*(s.Length))
            {
                flag=1;
                System.Console.WriteLine("Yes");
            }
            else
            {
                flag=1;
                System.Console.WriteLine("No");
            }
        }
        int m=Math.Min(s.Length, t.Length);
        for(i=0;i<m;i++)
        {
            if(s[i]==t[i]) count++;
            else break;
        }
        var left_s=(s.Length)-count;
        var left_t=(t.Length)-count;
        if(flag==0)
        {
        
            if(k>=left_s+left_t)
            {
                System.Console.WriteLine("Yes");
            }
            else System.Console.WriteLine("No");
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string s = Console.ReadLine();

        string t = Console.ReadLine();

        int k = Convert.ToInt32(Console.ReadLine().Trim());

        Result.appendAndDelete(s, t, k);
    }
}
