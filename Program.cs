using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isWin = false;
            int[,] field = new int[3, 3]
            {
                {1,0,1},
                {0,1,0},
                {0,1,0}
            };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(field[i,j]);
                }
                Console.WriteLine();
            }

            // xxx
            // yyy
            // xyxyxy
            // yxyxyx

            //xxx


            int x = 0;
            //xxx
            for (int i=0; i<3; i++)
            {
                for(int j=0; j<3; j++)
                {
                    int value = field[i, j];
                    if (field[i, j] == 1)
                    {
                        x++;
                    }
                    else x = 0;
                    if (x == 3) isWin = true;
                }
                x = 0;
            }
            //yyy
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int value = field[j, i];
                    if (field[j, i] == 1)
                    {
                        x++;
                    }
                    else x = 0;
                    if (x == 3) isWin = true;
                }
                x = 0;
            }
            //xyxyxy
            if(field[0,0] == 1)
            {
                for(int i = 0; i<3; i++)
                {
                    int value = field[i, i];
                    if (field[i, i] == 1)
                    {
                        x++;
                    }
                    else x = 0;
                    if (x == 3) isWin = true;
                }
            }
            Console.WriteLine(field[0, 2]);
            if (field[0, 2] == 1)
            {
                for (int i = 2; i >= 0; i--)
                {
                    int j = 2 - i;
                    int value = field[j, i];
                    if (field[j, i] == 1)
                    {
                        x++;
                    }
                    else x = 0;
                    if (x == 3) isWin = true;
                }
            }

            Console.WriteLine(isWin);
            Console.ReadKey();
        }
    }
}
