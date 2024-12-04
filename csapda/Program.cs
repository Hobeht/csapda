using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csapda
{
    class Program
    {

        static int Utak_szama(bool[,] matrix, int N, int M)
        {
            int[,] keszek = new int[N, M];
            keszek[0, 0] = 1;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (matrix[i, j])
                    {
                        if (j != 0 && i == 0)
                        {
                            keszek[0, j] = keszek[0, j - 1];
                        }
                        if (i != 0 && j == 0)
                        {
                            keszek[i, 0] = keszek[i - 1, 0];
                        }
                        if (i != 0 && j != 0)
                        {
                            keszek[i, j] = keszek[i - 1, j] + keszek[i, j - 1];

                        }
                    }
                }
            }
            return keszek[N - 1, M - 1];
        }
        static void Main(string[] args)
        {


            
            string[] sor = Console.ReadLine().Split(' ');
            int N = int.Parse(sor[0]);
            int M = int.Parse(sor[1]);

            bool[,] matrix = new bool[N, M];


            for (int i = 0; i < N; i++)
            {
                string[] tempsor = Console.ReadLine().Split(' ');
                for (int j = 0; j < M; j++)
                {
                    if (int.Parse(tempsor[j]) == 1)
                    {
                        matrix[i, j] = false;
                    }
                    else
                    {
                        matrix[i, j] = true;
                    }

                }
            }

            Console.WriteLine(Utak_szama(matrix, N, M) % 1000000);

            Console.ReadKey();
         
        }
    }
}
