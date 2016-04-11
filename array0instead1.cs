using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[,] d = new int[N, N];
            for (int i = 0; i <N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    
                    if (d[0, j] == 0)
                        d[i, j] = 1;
                    else if (d[j, 0] == 0)
                        d[j, 0] = 1;
                    else if (d[j, N - 1] == 0)
                        d[j, N - 1] = 1;
                    
                        
                    


                }

                d[N - 1, i] = 1;
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(d[i,j]);
                }
                Console.WriteLine(  );
            }



        }
    }
}
