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
                list.Add(list[0]);
                list.RemoveAt(0);
            }
            
            return list.ToArray();
        }
    }
}