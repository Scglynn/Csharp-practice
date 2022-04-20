//using System.CodeDom.Compiler;
//using System.Collections.Generic;
//using System.Collections;
//using System.ComponentModel;
//using System.Diagnostics.CodeAnalysis;
//using System.Globalization;
//using System.IO;
//using System.Linq;
//using System.Reflection;
//using System.Runtime.Serialization;
//using System.Text.RegularExpressions;
//using System.Text;
//using System;

//class Result
//{

//    /*
//     * Complete the 'plusMinus' function below.
//     *
//     * The function accepts INTEGER_ARRAY arr as parameter.
//     */

//    public static void plusMinus(List<int> arr)
//    {
//        decimal positives = 0;
//        decimal negatives = 0;
//        decimal zeros = 0;
//        int n = arr.Count;

//        for (int i = 0; i < n; i++)
//        {
//            if (arr[i] > 0)
//            {
//                positives++;
//            }
//            if (arr[i] < 0)
//            {
//                negatives++;
//            }
//            if (arr[i] == 0)
//            {
//                zeros++;
//            }
//        }
//        Console.WriteLine((positives / n).ToString("F6"));
//        Console.WriteLine((negatives / n).ToString("F6"));
//        Console.WriteLine((zeros / n).ToString("F6"));
//    }

//}

//class Solution
//{
//    public static void Main(string[] args)
//    {
//        int n = Convert.ToInt32(Console.ReadLine().Trim());

//        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

//        Result.plusMinus(arr);
//    }
//}

using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        int min_sum = 0;
        int max_sum = 0;
        int sum = 0;
        arr.Sort();
        List<int> list = new List<int>();
        for (int i = 0; i < arr.Count; i++)
        {
            sum += arr[i];
            if (sum < min_sum)
            {
                min_sum = sum;
            }
            if (sum > max_sum)
            {
                max_sum = sum;
            }
        }
        list.Add(min_sum);
        list.Add(max_sum);

        for (int i = 0; i < list.Count; i++)
        {
            Console.Write(list[i] + " ");
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}

