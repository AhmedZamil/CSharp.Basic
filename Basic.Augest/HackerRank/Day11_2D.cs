﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Augest.HackerRank
{
    public static class Day11_2D
    {
        public static void solution() 
        {
            //Jagged array used

            int[][] arr = new int[6][];

            for ( int i=0;i<6;i++)
            {
                string[] tempArr = Console.ReadLine().Split(' ');
                int[] lineArr = Array.ConvertAll(tempArr, x=> Int32.Parse(x));
                arr[i]=lineArr;
            }
            int result = -999;
            int rowCount = arr.Length;
            int columnCount = arr[0].Length;

            for ( int c = 0; c < columnCount -2;c++)
            {
                for (int r=0; r < rowCount -2;r++)
                {
                    int firstLine = arr[r][c] + arr[r][c + 1] + arr[r][c + 2];
                    int secondLine = arr[r + 1][c + 1];
                    int thirdLine = arr[r + 2][c]+ arr[r + 2][c+1]+ arr[r + 2][c + 2];

                    int totalLineHourGlass = firstLine + secondLine + thirdLine;

                    result = Math.Max(result,totalLineHourGlass);
                }
            
            }
        
            Console.WriteLine(result);
        
        }
    }

}
