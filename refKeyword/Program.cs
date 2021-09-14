using System;

namespace refKeyword
{
    class swap
    {
        public void Swapping(ref int a,ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            swap obj = new swap();
            Console.WriteLine("Enter Two Numbers");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            obj.Swapping(ref x, ref y);
            Console.WriteLine("x:{0}, y:{1}", x, y);
               
        }
    }
}
