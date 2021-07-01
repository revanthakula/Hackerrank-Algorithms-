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
/*Problem: Day of the Programmer
 Link:https://www.hackerrank.com/challenges/day-of-the-programmer/problem*/
class Result
{
    public static void dayOfProgrammer(int year)
    {
        if(year>1918)
        {
            if(year%400==0||(year%4==0&&year%100!=0))
            {
                System.Console.WriteLine("12.09."+year.ToString());
            }
            else System.Console.WriteLine("13.09."+year.ToString());
        }
        if(year<1918)
        {
            if(year%4==0)
            {
                System.Console.WriteLine("12.09."+year.ToString());
            }
            else System.Console.WriteLine("13.09."+year.ToString());
        }
        if(year==1918) System.Console.WriteLine("26.09."+year.ToString());
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int year = Convert.ToInt32(Console.ReadLine().Trim());

        Result.dayOfProgrammer(year);

    }
}
