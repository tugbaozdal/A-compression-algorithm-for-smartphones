using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = {
                { 1,2 ,3 ,4 ,5 ,6 ,7 ,8 },
                {10,16,13,14,18,17,15,19},
                {21,23,25,28,20,30,32,33},
                {40,42,41,43,44,48,47,49},
                {50,51,53,52,55,54,56,58},
                {61,62,64,63,68,67,60,65},
                {72,70,73,78,77,76,71,75},
                {88,86,87,82,85,81,80,83},
            };
            int[,] compressed = new int[8,8];


            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        compressed[0, 0] = array[0, 0];
                        continue;
                    }
                    else if (i == 0 && j != 0)
                    {
                        compressed[i, j] = array[i, j] - array[i, j - 1];
                    }
                    else if (i != 0 && j == 0)
                    {
                        compressed[i, j] = array[i, j];
                    }
                    else
                        compressed[i, j] = array[i, j] - array[i, j - 1];
              
                }
               
            }

            for(int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(" "+compressed[i, j]+" ");
                }
                Console.WriteLine();
                Console.WriteLine("****************************");
            }
            Console.ReadLine();

        }
    }
}
