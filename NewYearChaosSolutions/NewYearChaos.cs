using System.Linq;

namespace NewYearChaosSolutions
{
    public class NewYearChaos
    {
        public int MinimumBribes(int[] q)
        {
            var orderedQueue = q.ToList();
            var totalBribes = 0;
            orderedQueue.Sort();
            for (int i = 0; i < q.Length; i++)
            {
                var currentBribes = q[i] - orderedQueue[i];
                if (currentBribes <= 0) continue;
                if (currentBribes <= 2)
                    totalBribes += currentBribes;
                else
                {
                    totalBribes = -1; //Too Chaotic
                    break;
                }
            }
            return totalBribes;

        }
    }
}