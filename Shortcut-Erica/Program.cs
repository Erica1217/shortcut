using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shortcut_Erica
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string[] inputCut = new string[2];
            int n, d;
            int[][] data= new int[10010][];
            input = Console.ReadLine();
            inputCut = input.Split(' ');
            n = int.Parse(inputCut[0]);
            d = int.Parse(inputCut[1]);

            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();
                string[] strArr = str.Split(' ');
                int[] tmp = new int[] { int.Parse(strArr[0]), int.Parse(strArr[1]), int.Parse(strArr[2]) };
                for(int j=0; j<3; j++)
                {
                    Console.WriteLine(int.Parse(strArr[j]) + " ");
                    data[i] = tmp;
                }
           
            }

            Console.Write(Shortcut.shortcut(n,d,data).ToString());
            Console.ReadKey();
        }
    }
}
