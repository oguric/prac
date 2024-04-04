// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        // Примеры вызова всех функций
        int sum = AddNumbers(5, 7);
        Console.WriteLine($"Сумма чисел: {sum}");

        double radius = 5;
        double area = CalculateCircleArea(radius);
        Console.WriteLine($"Площадь окружности: {area}");

        string str = "Пример строки";
        int length = GetStringLength(str);
        Console.WriteLine($"Длина строки: {length}");

        int[] numbers = { 5, 10, 3, 8, 15 };
        int maxNumber = FindMax(numbers);
        Console.WriteLine($"Наибольшее значение в массиве: {maxNumber}");

        int factorialNumber = 5;
        long factorial = CalculateFactorial(factorialNumber);
        Console.WriteLine($"Факториал числа {factorialNumber}: {factorial}");

        string palindromeString = "топот";
        bool isPalindrome = IsPalindrome(palindromeString);
        Console.WriteLine($"Строка {palindromeString} является палиндромом: {isPalindrome}");

        int[] array1 = { 1, 2, 3 };
        int[] array2 = { 4, 5, 6 };
        int[] mergedArray = MergeArrays(array1, array2);
        Console.WriteLine("Слияние массивов:");
        foreach (var item in mergedArray)
        {
            Console.Write(item + " ");
        }

        int primeNumber = 17;
        bool isPrime = IsPrime(primeNumber);
        Console.WriteLine($"\nЧисло {primeNumber} простое: {isPrime}");

        string originalString = "Hello, World!";
        string reversedString = ReverseString(originalString);
        Console.WriteLine($"Исходная строка: {originalString}");
        Console.WriteLine($"Строка в обратном порядке: {reversedString}");

        int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int arraySum = CalculateArraySum(array);
        Console.WriteLine($"Сумма всех элементов массива: {arraySum}");
    }

    static int AddNumbers(int num1, int num2)
    {
        return num1 + num2;
    }

    static double CalculateCircleArea(double radius)
    {
        return Math.PI * radius * radius;
    }

    static int GetStringLength(string str)
    {
        return str.Length;
    }

    static int FindMax(int[] arr)
    {
        if (arr == null || arr.Length == 0)
        {
            throw new ArgumentException("Массив не может быть пустым");
        }

        int max = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }

        return max;
    }

    static long CalculateFactorial(int n)
    {
        if (n < 0)
        {
            throw new ArgumentException("Факториал не определен для отрицательных чисел");
        }
        if (n == 0 || n == 1)
        {
            return 1;
        }

        long result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }

        return result;
    }

    static bool IsPalindrome(string str)
    {
        str = str.ToLower().Replace(" ", "");

        for (int i = 0; i < str.Length / 2; i++)
        {
            if (str[i] != str[str.Length - i - 1])
            {
                return false;
            }
        }

        return true;
    }

    static int[] MergeArrays(int[] arr1, int[] arr2)
    {
        int[] mergedArray = new int[arr1.Length + arr2.Length];

        Array.Copy(arr1, mergedArray, arr1.Length);
        Array.Copy(arr2, 0, mergedArray, arr1.Length, arr2.Length);

        return mergedArray;
    }

    static bool IsPrime(int n)
    {
        if (n <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    static int CalculateArraySum(int[,] arr)
    {
        int sum = 0;

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                sum += arr[i, j];
            }
        }

        return sum;
    }
}

