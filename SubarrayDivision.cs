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
    public static void birthday(List<int> s, int d, int m)
    {
        var flag=0;
        for(int i=0;i<s.Count-m+1;i++)
        {
            var sum=0;
            for(int j=0;j<m;j++)
            {
                sum=sum+s[i+j];
            }
            if(sum==d)
            {
                flag++;
            }            
        }
        System.Console.WriteLine(flag);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int d = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        Result.birthday(s, d, m);
    }
}
