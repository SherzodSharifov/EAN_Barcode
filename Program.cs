/******************************
 * This is a C# code that generates 
 * EAN-13 type barcode and it can be
 * used for books which will be stored
 * at library.
 * 
 * Author Sherzod Sharifov
 *****************************/

using System;
using System.IO;

namespace Barcode
{
    class Program
    {
        static void Main(String[] args)
        {
            int numOfBar = 0;
           
            //Get user input
            Console.WriteLine("Hello, welcome to EAN-13 barcode generator app \nPlease enter number of barcodes that you need: ");
            numOfBar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Below are the barcodes which was requested:\n");

            string barcode = "5901234123457";
            int lastDigit = Convert.ToInt32(getLastDigit(barcode));


            //Calculate number of barcodes
            for (int i = 1; i < numOfBar + 1; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static string getLastDigit(string lastDigit)
        {

            return null;
        }
    }
}