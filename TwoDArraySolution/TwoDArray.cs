using System;
using System.Text;

namespace TwoDArraySolution
{
    public class TwoDArray
    {
        public int HourGlassSumSolution1(int[][] arr) {
            int result=int.MinValue;
            for(int i = 0; i < 4; i++ ){
                for(int j = 0; j < 4; j++)
                {
                    StringBuilder text = new StringBuilder();
                    text.AppendLine($"{arr[i][j]} {arr[i][j+1]} {arr[i][j+2]}");
                    text.AppendLine($" {arr[i + 1][j + 1]} ");
                    text.AppendLine($"{arr[i+2][j]} {arr[i+2][j+1]} {arr[i+2][j+2]}");
                    
                    int tmp1 = arr[i][j]+arr[i][j+1]+arr[i][j+2];
                    tmp1 += arr[i+1][j+1];
                    tmp1 += arr[i+2][j]+arr[i+2][j+1]+arr[i+2][j+2];
                    if(result< tmp1) 
                        result = tmp1;
                }
            
            }
            return result;
        }

    }
}