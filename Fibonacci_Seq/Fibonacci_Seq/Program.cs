using System;

namespace prep
{
    class example
    {
        int num = 0;
        int n1 = 0;
        int n2 = 1;
        int n3 = 0;
        string elem;
        public void fibo()
        {
            num = Convert.ToInt32(Console.ReadLine());

            //first two numbers in the sequence
            Console.Write(n1 + " " + n2 + " ");

            //rest of the numbers in the sequence
            for (int i = 2; i < num; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the number of element: ");
            example f = new example();
            f.fibo();

        }
    }

}