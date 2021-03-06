﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Chalnges.October2020.Week1.Problem1___RecentCounter
{
    /// <summary>
    /// Solves "Number of Recent Calls".
    /// October 1 2020.
    /// Accepted by LeetCode.
    /// Runtime: 288 ms, faster than 97.93% of C# online submissions (LeetCode submission details).
    /// </summary>
    public static class RecentCounter
    {
        public static List<int> RecentRequestTimes;
        public static int currentIndex;

        static RecentCounter()
        {
            currentIndex = 0;
            RecentRequestTimes = new List<int>();
        }

        public static int Ping(int t)
        {
            RecentRequestTimes.Add(t);

            while (currentIndex < RecentRequestTimes.Count &&
                   t - RecentRequestTimes[currentIndex] > 3000)
            {
                currentIndex++;
            }

            return RecentRequestTimes.Count - currentIndex;
        }
    }
}
