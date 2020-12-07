using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultidimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,,] fourDimensionalArray = new int[3, 4, 2, 3]

            { 
                { { { 1, 2, 3 }, { 4, 5, 6 } } },
                { { { 1, 2, 3 }, { 4, 5, 6 } } },
                { { { 1, 2, 3 }, { 4, 5, 6 } } },
                { { { 1, 2, 3 }, { 4, 5, 6 } } },

                { { { 1, 2, 3 }, { 4, 5, 6 } } },
                { { { 1, 2, 3 }, { 4, 5, 6 } } },
                { { { 1, 2, 3 }, { 4, 5, 6 } } },
                { { { 1, 2, 3 }, { 4, 5, 6 } } },

                { { { 1, 2, 3 }, { 4, 5, 6 } } },
                { { { 1, 2, 3 }, { 4, 5, 6 } } },
                { { { 1, 2, 3 }, { 4, 5, 6 } } },
                { { { 1, 2, 3 }, { 4, 5, 6 } } }
            };

            for (int i = 0; i < fourDimensionalArray.GetLength(0); i++)
            {
                for (int j = 0; j < fourDimensionalArray.GetLength(1); j++)
                {
                    for (int k = 0; k < fourDimensionalArray.GetLength(2); k++)
                    {
                        for (int L = 0; L < fourDimensionalArray.GetLength(3); L++)
                        {
                            int m = fourDimensionalArray[i, j, k, L];
                            Console.WriteLine(m);
                        }
                    }
                }
            }
        }
    }
}
