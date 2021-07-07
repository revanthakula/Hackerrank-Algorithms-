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

/*Link:https://www.hackerrank.com/challenges/permutation-equation/problem
*/
class Result
{
    public static List<int> permutationEquation(List<int> p)
    {
        var<int> result = new List<int>();
          for (var i=0; i < p.Count; i++)
            {
                var f = i+1;
                for (var j=0; j<p.Count; j++)
                {
                    if (f==p[p[j] - 1])
                    {
                        result.Add(j+1);
                    }
                }
            }
            return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> p = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(pTemp => Convert.ToInt32(pTemp)).ToList();

        List<int> result = Result.permutationEquation(p);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
