//Stephen Burgess
//Matrices (2D Arrays) - Add Matrices

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates a random number generator called rand.
            Random rand = new Random();



            //Populated
            int[,] MatrixA = new int[3, 3];
            int[,] MatrixB = new int[3, 3];

            for (int i = 0; i < MatrixA.GetLength(0); i++)//Row
            {
                for (int j = 0; j < MatrixA.GetLength(1); j++)//Column
                {
                    //gets the coordinates from the counters in the external and internal loops.
                    MatrixA[i, j] = rand.Next(-10, 10);
                }
                
            }
            for (int i = 0; i < MatrixB.GetLength(0); i++)//Row
            {
                for (int j = 0; j < MatrixB.GetLength(1); j++)//Column
                {
                    //gets the coordinates from the counters in the external and internal loops.
                    MatrixB[i, j] = rand.Next(-10, 10);
                }
                
            }

            //Displays the arrays Matrix A and Matrix B
            Console.WriteLine("Matrix A's Array\n");
            Display(MatrixA);
            Console.WriteLine("Matrix B's Array\n");
            Display(MatrixB);

            //Adds the arrays Matrix A and Matrix B Together to create the array Matrix C.
            Console.WriteLine("Matrix A + Matrix B = Matrix C");
            Console.WriteLine("\nMatrix C's Array\n");
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    Console.Write(MatrixA[i, j] + MatrixB[i, j] + "  ");
                }

                Console.WriteLine();
                Console.ReadLine();
                
                
                
            }
        }

        //Display Method
        public static void Display(int[,] arr)
        {
            //Uses the for loop to get the array length
            for (int i = 0; i < arr.GetLength(0); i++)//Row
            {
                for (int j = 0; j < arr.GetLength(1); j++)//Column
                {
                    //gets the coordinates from the counters in the external and internal loops.
                    Console.Write(arr[i, j] + "  ");
                }
                Console.WriteLine();
                Console.ReadLine();
               
                
            }

        }
        
        
    }
    
   
}
