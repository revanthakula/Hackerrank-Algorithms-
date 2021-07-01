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

/*Link:https://www.hackerrank.com/challenges/climbing-the-leaderboard/problem
Problem Name: Climbing the ladder*/

class Result
{
    public static void climbingLeaderboard(List<int> ranked, List<int> player)
    {
        List<int> Rank_mark=new List<int>();
        var prev=0;
        var rank=0;
        for(int i=0;i<ranked.Count;i++)
        {
            if(prev!=ranked[i])
            {
                Rank_mark.Add(ranked[i]);
                rank++;
            }
            prev=ranked[i];
        }
        var flag=0;
        for(int j=0;j<player.Count;j++)
        {
            for(int k=rank-1;k>=0;k--)
            {
                if(player[j]<Rank_mark[k])
                {
                    System.Console.WriteLine(k+2);
                    rank=k+1;
                    break;
                }
                if(player[j]==Rank_mark[k])
                {
                    System.Console.WriteLine(k+1);
                    flag=k;
                    break;
                }
                if(player[j]>Rank_mark[0])
                {
                    System.Console.WriteLine(1);
                    rank=1;
                    break;
                }
            }
        }
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int rankedCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> ranked = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(rankedTemp => Convert.ToInt32(rankedTemp)).ToList();

        int playerCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> player = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(playerTemp => Convert.ToInt32(playerTemp)).ToList();

        Result.climbingLeaderboard(ranked, player);
    }
}
