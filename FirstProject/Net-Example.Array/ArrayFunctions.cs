using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_Example.Array
{
    public class ArrayFunctions
    {
        public void OneDimension()
        {
            int[] number = new int[1];
        }

        public void TwoDimensions()
        {
            int[,] numbers = new int[1, 1];
        }

        /// <summary>
        /// First brucket is for Row
        /// Second Brucket is for column
        /// </summary>
        public void JaggedArry()
        {
            int[][] jagged = new int[3][];

            jagged[0] = new int[] { 1, 3, 4 };
            jagged[1] = new int[] { 7, 9 };
            jagged[2] = new int[] { 8 };

            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.WriteLine($"value of {i} and {j} is : {jagged[i][j]}");
                }
            }

        }
    }
}
