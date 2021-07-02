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

/*Problem Name: PDF viewer
Link:https://www.hackerrank.com/challenges/designer-pdf-viewer/problem
*/

class Result
{
    public static void designerPdfViewer(List<int> h, string word)
    {
        var max=0;
        foreach(var c in word)
        {
            if(max<h[(int)c-97])
            {
                max=h[(int)c-97];
            }
        }
        System.Console.WriteLine(max*word.Length);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        List<int> h = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(hTemp => Convert.ToInt32(hTemp)).ToList();

        string word = Console.ReadLine();

        Result.designerPdfViewer(h, word);
    }
}
