using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework02
{
    internal class Program
    {
        // 素数因子
        public static List<int> GetPrimes(int number)
        {
            List<int> primes;
            int i = 2;
            if (number <= 1)
            {
                return null;
            }

            primes = new List<int>();
            while(i <= number)
            {
                if (number % i == 0)
                {
                    primes.Add(i);
                    number /= i;
                }
                else
                {
                    i++;
                }
            }

            return primes;
        }
        
        // 求数组max, min, average, sum
        public static void GetMaxMinAvgSum(int[] numbers, out int? max, out int? min, out double? avg, out int? sum)
        {
            if (numbers is null)
            {
                max = null;
                min = null;
                avg = null;
                sum = null;
            }
            else
            {
                max = numbers.Max();
                min = numbers.Min();
                avg = numbers.Average();
                sum = numbers.Sum();
            }
        }
        
        // 埃氏筛法
        public static List<int> GetPrimes2To100()
        {
            int[] numbers = new int[101];
            List<int> primes = new List<int>();
            int i = 2;
            while (i <= 100)
            {
                for (int j = i + 1; j <= 100; j++)
                {
                    if (j % i == 0 && numbers[j] == 0)
                    {
                        numbers[j] = 1;
                    }
                }

                for (int j = i + 1; j <= 100; j++)
                {
                    if (numbers[j] == 0)
                    {
                        i = j;
                        break;
                    }

                    if (j == 100)
                    {
                        i = 101;
                    }
                }
            }

            for (i = 2; i <= 100; i++)
            {
                if (numbers[i] == 0)
                {
                    primes.Add(i);
                }
            }

            return primes;
        }
        
        // 托普利茨矩阵，这里把只有行或列的矩阵看做true
        public static bool IsToeplitzMatrix(int[,] matrix)
        {
            int m = matrix.GetLength(0);
            int n = matrix.GetLength(1);
            for (int i = 0; i < m - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (matrix[i, j] != matrix[i + 1, j + 1])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
        
        public static void Main(string[] args)
        {
            
        }
    }
}