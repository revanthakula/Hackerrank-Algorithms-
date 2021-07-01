using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
/*Link:https://www.hackerrank.com/challenges/electronics-shop
Problem name:Electronics shop*/
class Solution {
    static int getMoneySpent(int[] keyboards, int[] drives, int b)
    {
        var prev=0;
        var sum=0; 
        for(int i=0;i<keyboards.Count();i++)
        {
            for(int j=0;j<drives.Count();j++)
            {
                sum=keyboards[i]+drives[j];
                if(sum<=b&&sum>prev)
                {   
                    prev=sum;
                }    
            }
        }
        if(prev==0) return -1;
        else return prev;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        string[] bnm = Console.ReadLine().Split(' ');
        int b = Convert.ToInt32(bnm[0]);
        int n = Convert.ToInt32(bnm[1]);
        int m = Convert.ToInt32(bnm[2]);
        int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp));
        int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp));
        int moneySpent = getMoneySpent(keyboards, drives, b);
        textWriter.WriteLine(moneySpent);
        textWriter.Flush();
        textWriter.Close();
    }
}
