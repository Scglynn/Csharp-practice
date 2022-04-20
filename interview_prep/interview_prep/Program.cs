using System;

//class Program
//{
//    static String location;
//    static DateTime time;

//    static void Main()
//    {
//        Console.WriteLine(location == null ? "location is null" : location);
//        Console.WriteLine(time == null ? "time is null" : time.ToString());
//    }
//}

namespace del
{
    delegate void Printer();
    static void Main()
    {
        List<Printer> printers = new List<Printer>();
        int i = 0;
        for (; i < 10; i++)
        {
            printers.Add(delegate { Console.WriteLine(i); });
        }

        foreach (var printer in printers)
        {
            printer();
        }
    }
}