using System;
using System.Security.Authentication;

namespace Homework04
{
    internal class Program
    {
        public static void Problem1()
        {
            GenericList<int> list = new GenericList<int>();
            Random rd = new Random();
            for (int i = 0; i < 10; i++)
            { 
                list.Add(rd.Next(0, 10));
            }
            GenericList<int>.ForEach(list, m=>Console.WriteLine(m));
            int sum = 0, max = 0, min = Int32.MaxValue;
            GenericList<int>.ForEach(list, m => { sum += m;});
            GenericList<int>.ForEach(list, m=>{ max = m > max ? m : max;});
            GenericList<int>.ForEach(list, m => { min = m < min ? m : min;});
            Console.WriteLine("sum = {0}", sum);
            Console.WriteLine("min = {0}", min);
            Console.WriteLine("max = {0}", max);
        }
        
        public static void Problem2()
        {
            Clock c = new Clock(1, 29, 0);
            c.Tick += Show;
            c.Alarm += Show;
            try
            {
                c.Start();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void Show(object sender, TAEvenArgs args)
        {
            Console.WriteLine("time = {0}:{1}:{2}      " + args.Message, args.Hour, args.Minute, args.Second);
        }
        
        public static void Main(string[] args)
        {
           Problem2();
        }
    }
}