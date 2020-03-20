using System;
using System.Linq;

namespace LeftRotationSolution
{
    public class LeftRotation
    {
        public int[] RotateLeft(int[] a, int d)
        {
            var list = a.ToList();

            for (int i = 1; i <= d; i++)
            {
                var tmp = list[0];
                list.RemoveAt(0);
                list.Add(tmp);
            }
            
            return list.ToArray();
        }
    }
}