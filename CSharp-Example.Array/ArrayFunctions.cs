using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Example.Array
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

        /// <summary>
        /// Start to read an array from end to begin
        /// </summary>
        public void Hat()
        {
            int[] sample = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine(sample[0]);
            Console.WriteLine(sample[1]);
            Console.WriteLine(sample[^1]);
            Console.WriteLine(sample[^2]);
        }

        public void Range()
        {
            int[] sample = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var rangeOfArray = sample[1..4];

            foreach (var item in rangeOfArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
