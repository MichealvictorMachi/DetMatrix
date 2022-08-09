using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixDeterminant
{
    internal class DetMatrix
    {
        static void Main(string[] args)
        {
                                
            Determinant determinantFourD = new Determinant();
            Console.WriteLine("What is the size of the array for determinant?");
            determinantFourD.ArrayLength = Convert.ToInt32(Console.ReadLine());
            int arrayLen = determinantFourD.ArrayLength;

            int[,] fourDimArray = determinantFourD.ArrayValues(arrayLen);
            Console.WriteLine("The determinant is {0}", determinantFourD.Calculation(fourDimArray));

        }
    }
}
