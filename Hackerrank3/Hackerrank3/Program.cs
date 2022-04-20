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
//     * Complete the 'birthdayCakeCandles' function below.
//     *
//     * The function is expected to return an INTEGER.
//     * The function accepts INTEGER_ARRAY candles as parameter.
//     */

//    public static int birthdayCakeCandles(List<int> candles)
//    {
//        int max = 0;
//        int count = 0;
//        for (int i = 0; i < candles.Count; i++)
//        {
//            int num = candles[i];
//            if (num > max)
//            {
//                max = num;
//                count = 1;
//            }
//            else if (num == max)
//            {
//                count++;
//            }
//        }
//        return count;
//    }

//}

//class Solution
//{
//    public static void Main(string[] args)
//    {
//        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

//        List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

//        int result = Result.birthdayCakeCandles(candles);

//        textWriter.WriteLine(result);

//        textWriter.Flush();
//        textWriter.Close();
//    }
//}

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
//     * Complete the 'gradingStudents' function below.
//     *
//     * The function is expected to return an INTEGER_ARRAY.
//     * The function accepts INTEGER_ARRAY grades as parameter.
//     */

//    public static List<int> gradingStudents(List<int> grades)
//    {
//        for(int i = 0; i < grades.Count; i++)
//        {
//            int grade = grades[i];
//            if(grade >= 38)
//            {
//                var diff = 5 - (grade % 5);
//                if(diff < 3)
//                {
//                    grades[i] = grade + diff;
//                }
//            }
//        }
//        return grades;

//    }

//}

//class Solution
//{
//    public static void Main(string[] args)
//    {
//        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

//        List<int> grades = new List<int>();

//        for (int i = 0; i < gradesCount; i++)
//        {
//            int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
//            grades.Add(gradesItem);
//        }

//        List<int> result = Result.gradingStudents(grades);

//        textWriter.WriteLine(String.Join("\n", result));

//        textWriter.Flush();
//        textWriter.Close();
//    }
//}

