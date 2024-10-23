using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Multi
    {
        public int Row { get; }
        public int Col { get; }
        public int[,] matrix;           // Declaration of a 2 Dimensional array. 

        public Multi(int r, int c)
        {
            Row = r;
            Col = c;
            matrix = new int[r,c];  
        }

        public void loadData()
        {
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Col; j++)
                {
                    Console.Write($"[+] Enter element {(i+1, j+1)}: ");
                    matrix[i,j] = int.Parse(Console.ReadLine());
                }
            }
        }
        
        public void showMatrix()
        {
            for (int i=0; i< this.Row; i++)
            {
                for (int j=0; j< this.Col; j++)
                {
                    Console.Write($"{matrix[i,j]} ");
                }
                Console.Write("\n");
            }
        }
        public int rowSum(int r)
        {
            int sumVal = 0; 
            for (int i=0; i< Col; i++)
            {
                sumVal += matrix[r - 1, i];
            }
            return sumVal; 
        }

    }
}