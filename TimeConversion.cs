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
    public static string timeConversion(string s)
    {
        var hours=s.Substring(0,2);
        var minsec=s.Substring(2,6);
        var aorp=s.Substring(8,1);
        if(aorp=="A" && hours=="12")
        {
            hours="00";
        }
        else if(aorp=="P")
        {
            var integer=int.Parse(hours);
            if(integer<12)
            {
                hours=Convert.ToString(12+integer);
            }
        }
        return (hours+minsec);
    
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
