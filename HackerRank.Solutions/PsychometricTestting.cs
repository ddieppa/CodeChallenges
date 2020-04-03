using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Solutions
{
    public class PsychometricTestting
    {
        public int[] JobOffers(int[] scores, int[] lowerLimits, int[] upperLimits)
        {
            int[] result = new int[lowerLimits.Length];

            for (int i = 0; i < lowerLimits.Length; i++)
            {
                for (int score = 0; score < scores.Length; score++)
                {
                    if (lowerLimits[i] <= scores[score] && scores[score] <= upperLimits[i])
                    {
                        result[i] += 1;
                    }
                }

            }

            return result;
        }
    }
}
