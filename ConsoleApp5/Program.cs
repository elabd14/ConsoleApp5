using System;
using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

namespace ConsoleApp5
{
    internal class Program
    {
        #region q1 
        #region call by value 
        /*  public static void SWAPbyVALUE(int m, int z)
          {
              int number = m;
              m = z;
              z = number;

          }*/
        #endregion
        #region call by refrance 
        /*  public static void SWAP(ref int m, ref int z)
           {
               int number = m;
               m = z;
               z = number;
           }*/

        #endregion
        #endregion
        #region function for ques 2 

        /* public static void sum_byref(ref int[] arr)
         {
             int sum = 0;
             arr = new int[] { 8, 6, 4 };
             for (int i = 0; i < arr.Length; i++)
             {
                 sum += arr[i];
             }

             Console.WriteLine(sum);
         }*//*


         public static void sum_ary(int[] arr)
         {
             int sum = 0;
             for (int i = 1; i < arr.Length; i++)
             {
                 sum += arr[i];
             }

             Console.WriteLine(sum);
         } */
        #endregion
        #region q3
        public static void ope_number(int num1, int num2, out int sum, out int sub)
        {

            sum = num1 + num2;
            sub = num1 - num2;

            Console.WriteLine(sum);
            Console.WriteLine(sub);



        }
        #endregion
        #region Q4
        public static int SumOfDigits(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }

        #endregion
        #region 5Q
        public static bool IsPrime(int number)
        {

            if (number <= 1)
            {
                return false;
            }


            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;

        }
        #endregion
        #region Q6
        public static void MinMaxArray(int[] arr, out int min, out int max)
        {

            min = arr[0];
            max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                else if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
        }
        #endregion
        #region q7
        public static int Factorial(int number)
        {
            int m = 1;

            for (int i = 1; i <= number; i++)
            {

                m *= i;

            }
            return m;
        }
        #endregion
        #region q 8 
        public static void changechar(string m, char c, int idex)
        {
            m = m.Replace(m[idex], c);
            Console.WriteLine(m);

        }

        #endregion
        static void Main()
        {
            #region q1
            #region part1
            /* int x = 10;
        int y = 20;
        SWAPbyVALUE(x, y);
        Console.WriteLine(x);
        Console.WriteLine(y);
        // x,y didn't change 
        */
            #endregion

            #region pART 2 
            /* int x = 10;
        int y = 20;
        SWAP(ref x, ref y);
        Console.WriteLine(x);
        Console.WriteLine(y);
        // change between x,y  */
            #endregion
            #endregion
            #region question 2 
            /*
    int[] arr = {5,6,7 };
    *//* sum_ary(arr); *//*
                             sum_byref(ref arr);*/
            #endregion
            #region 3q
            /* Console.WriteLine("Enter 2 numbers separated by spaces:");
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                int sum =0 ; int sub  = 0;
                ope_number(n1 ,n2, out sum, out sub); */
            #endregion
            #region 4Q
            /*
                Console.WriteLine("enter the number ");
                int number=int.Parse(Console.ReadLine());
                int sumOfDigits = SumOfDigits(number);
                Console.WriteLine(sumOfDigits);*/
            #endregion
            #region 5Q
            /* Console.Write("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());

                bool isPrime = IsPrime(number);

                if (isPrime)
                {
                    Console.WriteLine($"{number} is a prime number.");
                }
                else
                {
                    Console.WriteLine($"{number} is not a prime number.");*/
            #endregion
            #region Q6
            /*            {

                            int[] array = { 3, 7, 2, 8, 1, 4, 5 };

                            int minValue, maxValue;
                            MinMaxArray(array, out minValue, out maxValue);

                            Console.WriteLine("Array: " + string.Join(", ", array));
                            Console.WriteLine("Minimum value: " + minValue);
                            Console.WriteLine("Maximum value: " + maxValue);

                       }*/
            #endregion
            #region 7q
            /*Console.WriteLine("ENTER THER NUMBER");     
                int number=int.Parse(Console.ReadLine());
                Factorial(number);*/
            #endregion
            #region q8
            string s = Console.ReadLine();
            changechar(s, 'a', 0);

            #endregion
        }
    }
}
  



















