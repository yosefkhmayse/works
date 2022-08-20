using System;

namespace ConsoleApp36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*=====================================================================================
               עבור מערך דו מימדי נתון, יש לייצר מערך חדש שהוא ריבוע קסם של המערך הנתון
               כלומר
               השורה הראשונה כוללת סכום של כל טור
               הטור הראשון הוא סכום השורות
               תא 0,0 הוא סכום האלכסון 
               =====================================================================================*/
            Console.Write("Enter the array size : ");
            Random random = new Random();
            int arraysize = int.Parse(Console.ReadLine());
            int newarraysize = arraysize + 1;
            int[,] array = new int[arraysize, arraysize];
            int[,] newmagicarray = new int[newarraysize, newarraysize];
            Console.WriteLine($"Array size: {arraysize} * {arraysize} = {arraysize * arraysize} ");
            /*put numbers on old array*/
            for (int row = 0; row < arraysize; row++)
            {
                for (int col = 0; col < arraysize; col++)
                {
                    array[row, col] = random.Next(0,10);
                }
            }
            /*print old array*/
            Console.WriteLine("this is your Array  :");
            for (int row = 0; row < arraysize; row++)
            { 
                for (int col = 0; col < arraysize; col++)
                {

                    Console.Write($"{array[row, col]}   ");
                    
                }
                Console.WriteLine();
                Console.WriteLine("");
              
            }
            Console.WriteLine();
            Console.WriteLine($"the new array size is : {newarraysize} * {newarraysize} = {newarraysize*newarraysize}");
            /*digonal sum */
                int thediagonal = 0;
                for (int i = 0; i < arraysize; i++)
                    thediagonal += array[i, i];

                newmagicarray[0, 0] = thediagonal;
                // row sum 
                for (int row = arraysize - 1; row >= 0; row--)
                {
                    int rowsum = 0;
                    for (int col = arraysize - 1; col >= 0; col--)
                    {
                        int rowloc = array[row, col];

                    // Put numbers into magic array row loc

                    newmagicarray[row + 1, col + 1] = rowloc;

                        rowsum += rowloc;
                    }
                newmagicarray[row + 1, 0] = rowsum;
                }

                // col sum 
                for (int col = arraysize - 1; col >= 0; col--)
                {
                    int colsum = 0;
                    for (int row = arraysize - 1; row >= 0; row--)
                        colsum += array[row, col];
                // Put numbers into magic array col loc

                newmagicarray[0, col + 1] = colsum;
                }
                //new magic array print 
            Console.WriteLine("thi is a magic array : ");
            for (int row = 0; row < newarraysize; row++)
            {
                for (int col = 0; col < newarraysize; col++)
                {

                }
                Console.WriteLine("");

                for (int col = 0; col < newarraysize; col++)
                {
                    Console.Write($"{newmagicarray[row, col]}   ");
                }
                Console.WriteLine(" ");
            }

            for (int i = 0; i < newarraysize; i++)

                Console.WriteLine("");
            Console.WriteLine("");
        }
    }
        }
    
        

        
