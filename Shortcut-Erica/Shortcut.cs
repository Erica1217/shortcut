using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shortcut_Erica
{
    public class Shortcut
    {
        public static int shortcut(int N, int D, int[][] array)
        {
            int[] data = new int[10010];
            for(int i=0; i<=D; i++)
            {
                data[i] = i;
                Console.WriteLine(data[i] + "");
            }

            // array배열을 0번째 인덱스를 기준으로 정렬
            twoDimensionalArraySort(0,N, array);

            for (int i = 0; i < N; i++)
            {
                int start = array[i][0];
                int end = array[i][1];
                int distance = array[i][2];

                if(data[end] > distance)
                {
                    for (int j = end; j <= D ; j++)
                    {
                        data[j] = distance + (j - end);
                    }
                }
            }
            return data[D];
        }

        //2차원 배열을 array[][0]을 기준으로 정렬
        static int[][] twoDimensionalArraySort(int standardIndex, int n, int[][] array)
        {
            for( int i=0; i<n ; i++ )
            {
                for(int j=0; j<n-1-i; j++)
                {
                    if( array[i][standardIndex] > array[j][standardIndex] )
                    {
                        int[] tmp = array[i];
                        array[i] = array[j];
                        array[j] = tmp;
                    }
                }
            }
            return array;
        }

    }

}
