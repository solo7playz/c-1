using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace с_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[5];
            double[,] B = new double[3, 4];
            Console.WriteLine("print array");
            fillArr(ref A);
            Console.WriteLine("print double array");
            fill2Arr(ref B);
            Console.WriteLine("first arr");
            printArr(ref A);
            Console.WriteLine("second arr");
            print2Arr(ref B);
            findMax(ref A, ref B);
            Random rnd = new Random();
            int[,] arr = new int[5, 5];
            fillNew2Arr(ref arr, rnd);
            Console.WriteLine("third arr");
            printInt2Arr(ref arr);
            int[] tmp = minMaxOfNew2Arr(ref arr);
            sumOfNew2Arr(ref arr, ref tmp);
            Random rnd1 = new Random();
            Console.Write("print quantity of matrix: ");
            int quantity = int.Parse(Console.ReadLine());
            int[,,] arr1 = fillArrs(ref quantity, rnd1);
            print3Art(ref arr1);
            sumOfArrs(ref quantity, ref arr1);
        }
       static void fillArr(ref int[] arr)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("print element of array - ");
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
       static void fill2Arr(ref double [,] arr)
        {
            for(int i = 0;i < 3; i++)
            {
                for(int j = 0;j < 4; j++)
                {
                    Console.Write("print element of array - ");
                    arr[i,j] = double.Parse(Console.ReadLine());
                }
            }
        }
        static void printArr(ref int[] arr)
        {
            for(int i = 0; i < 5; i++) 
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        static void print2Arr(ref double[,] arr)
        {
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void printInt2Arr(ref int[,] arr)
        {
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void findMax(ref int[] arr, ref double[,] arr1)
        {
            int tmp = 0;
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    for(int c = 0; c < 4; c++)
                    {
                        if (arr[i] == arr1[j, c] && arr[i] > tmp)
                        {
                            tmp = arr[i];
                        }
                    }
                }
            }
            Console.WriteLine("max num - " + tmp);
        }
        static void fillNew2Arr(ref int[,] arr, Random rnd)
        {
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    arr[i,j] = rnd.Next(-100, 101);
                }
            }
        }
        static int[] minMaxOfNew2Arr(ref int[,] arr)
        {
            int min = arr[0, 0];
            int max = arr[0, 0];
            int[] tmp = new int[2];
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    if (arr[i,j] < min) { min = i; }
                    if (arr[i,j] > max) { max = j; }
                }
            }
            tmp[0] = min;
            tmp[1] = max;
            return tmp;
        }
        static void sumOfNew2Arr(ref int[,] arr, ref int[] tmp)
        {
            int sum = 0;
            for(int i = tmp[0]; i < 5; i++)
            {
                for (int j = tmp[1]; j < 5; j++)
                {
                    sum += arr[i,j];
                }
            }
            Console.WriteLine("sum - " + sum);
        }
        static int[,,] fillArrs(ref int quantity, Random rnd1)
        {
            Console.Write("print len and wei of matrixs: ");
            int len = int.Parse(Console.ReadLine());
            int wei = int.Parse(Console.ReadLine());
            int[,,] arr = new int[quantity, len, wei];
            Console.Write("print diapaxon of random: ");
            int y = int.Parse(Console.ReadLine())+1;
            int x = int.Parse(Console.ReadLine());
            for (int c = 0; c < quantity; c++) {
                for (int i = 0; i < len; i++)
                {
                    for (int j = 0; j < wei; j++)
                    {
                        arr[c,i,j] = rnd1.Next(x, y);
                    }
                }
            }
            return arr;
        }
        static int[,,] sumOfArrs(ref int quantity, ref int[,,] arr)
        {
            for(int i = 0; i < quantity;i++)
            {
                for(int j = 0; j <  arr.GetLength(0); j++)
                {
                    for (int c = 0; c < arr.GetLength(0); c++)
                    {
                        for (int k = 0; k < arr.GetLength(0); k++)
                        {
                            arr[i, j, c] += arr[i + k, j, c];
                        }
                    }
                }
            }
            return arr;
        }
        static void print3Art(ref int[,,] arr)
        {
            for(int i = 0; i < 1; i++)
            {
                for(int j = 0; j < arr.GetLength(0); j++)
                {
                    for(int c = 0; c < arr.GetLength(0); c++)
                    {
                        Console.Write(arr[i, j, c] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
