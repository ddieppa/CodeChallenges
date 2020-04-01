using System;

namespace HackerRank.Solutions
{
    public class NewYearChaos
    {
        public string MinimunBribes(int[] q)
        {
            var bribes = 0;
            var isTooChaotic = false;
            for (int i = 0; i < q.Length; i++)
            {
                if (q[i] - (i+1) > 2)
                {
                    isTooChaotic = true;
                    break;
                }
                for (int j = Math.Max(0, q[i] - 2); j < i; j++)
                    if (q[j] > q[i])
                        bribes++;
            }
            
            return isTooChaotic ? "Too chaotic" : bribes.ToString();
        }
    }
}
