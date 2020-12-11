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

            int[,,,] fourDimensionalArray = new int[1,1,4,4]
            { 
              {
                { 
                  { 13, 24, 34, 45 },
                  { 51, 64, 71, 82 },
                  { 19, 10, 11, 12 },
                  { 23, 44, 14, 29 } 
                }                
              }
            };
            DateTime startTime = DateTime.Now;
            Console.WriteLine("Please input your name");
            string name = Convert.ToString(Console.ReadLine()); 

            int matrixDeterminant = (fourDimensionalArray[0,0,0,0] * ((fourDimensionalArray[0, 0, 1, 1] * ((fourDimensionalArray[0,0,2,2] * fourDimensionalArray[0,0,3,3]) - (fourDimensionalArray[0,0,2,3] * fourDimensionalArray[0,0,3,2])))) - fourDimensionalArray[0,0,1,2] * ((fourDimensionalArray[0,0,2,1] * fourDimensionalArray[0,0,3,3]) - (fourDimensionalArray[0,0,2,3] * (fourDimensionalArray[0,0,3,1]))) + (fourDimensionalArray[0,0,1,3] * (fourDimensionalArray[0,0,2,1] * fourDimensionalArray[0,0,3,2]) - (fourDimensionalArray[0,0,2,2] * fourDimensionalArray[0,0,3,1])))

                -

              (fourDimensionalArray[0,0,0,1] * ((fourDimensionalArray[0,0,1,0] * ((fourDimensionalArray[0,0,2,2] * fourDimensionalArray[0,0,3,3]) - (fourDimensionalArray[0,0,2,3] * fourDimensionalArray[0,0,3,2])))) - fourDimensionalArray[0,0,1,2] * ((fourDimensionalArray[0,0,2,0] * fourDimensionalArray[0,0,3,3]) - (fourDimensionalArray[0,0,2,3] * (fourDimensionalArray[0,0,3,0]))) + (fourDimensionalArray[0,0,1,3] * (fourDimensionalArray[0,0,2,0] * fourDimensionalArray[0,0,3,2]) - (fourDimensionalArray[0,0,2,2] * fourDimensionalArray[0,0,3,0])))

                +

                (fourDimensionalArray[0,0,0,2] * ((fourDimensionalArray[0,0,1,0] * ((fourDimensionalArray[0,0,2,1] * fourDimensionalArray[0,0,3,3]) - (fourDimensionalArray[0,0,2,3] * fourDimensionalArray[0,0,3,1])))) - fourDimensionalArray[0,0,1,1] * ((fourDimensionalArray[0,0,2,0] * fourDimensionalArray[0,0,3,3]) - (fourDimensionalArray[0,0,2,3] * (fourDimensionalArray[0,0,3,0]))) + (fourDimensionalArray[0,0,1,3] * (fourDimensionalArray[0,0,2,0] * fourDimensionalArray[0,0,3,1]) - (fourDimensionalArray[0,0,2,1] * fourDimensionalArray[0,0,3,0])))

                -

                (fourDimensionalArray[0,0,0,3] * ((fourDimensionalArray[0,0,1,0] * ((fourDimensionalArray[0,0,2,1] * fourDimensionalArray[0,0,3,2]) - (fourDimensionalArray[0,0,2,2] * fourDimensionalArray[0,0,3,1])))) - fourDimensionalArray[0,0,1,1] * ((fourDimensionalArray[0,0,2,0] * fourDimensionalArray[0,0,3,2]) - (fourDimensionalArray[0,0,2,2] * (fourDimensionalArray[0,0,3,0]))) + (fourDimensionalArray[0,0,1,2] * (fourDimensionalArray[0,0,2,0] * fourDimensionalArray[0,0,3,1]) - (fourDimensionalArray[0,0,2,1] * fourDimensionalArray[0,0,3,0])));
            

            for (int i=0; i < fourDimensionalArray.Length; i++)
            {

                for (int j = 0; j < fourDimensionalArray.Length; j++)
                {

                    for (int k = 0; k < fourDimensionalArray.Length; k++)
                    {

                        int[] result = new int[fourDimensionalArray.Length];
                        for (int L = 0; L < fourDimensionalArray.Length; L++)
                        {
                            result[L] = (int)Math.Pow(L, 2);
                            
                        }

                    }

                }

            }

            if (startTime.Hour < 12)
            {
                Console.WriteLine($"Good morning {name}");
            }

            else if (startTime.Hour >= 12)
            {
                Console.WriteLine($"Good afternoon {name}");
            }

            else if (startTime.Hour >= 18)
            {
                Console.WriteLine($"Good evening {name}");
            }

            Console.WriteLine("Calculating the determinant of the inputted matrix");

            Console.WriteLine("Processing.........................................");

            Console.WriteLine($"The determinant of the matrix is {matrixDeterminant}");


            

            DateTime endTime = DateTime.Now;

            TimeSpan timeTaken = endTime - startTime;
            double resultTimeTaken = timeTaken.TotalSeconds;
            Console.WriteLine($"It took {resultTimeTaken} seconds to complete your task");
            Console.ReadLine();
        }
    }       
}
