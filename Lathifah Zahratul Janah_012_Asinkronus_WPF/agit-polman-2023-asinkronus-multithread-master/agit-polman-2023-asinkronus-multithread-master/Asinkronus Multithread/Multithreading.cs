using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asinkronus_Multithread
{
    internal class Multithreading
    {
        public static void FirstMethod()
        {
            Console.WriteLine("First Method on Thread with Id: " + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(10000);
            Console.WriteLine("First Method Continuation on Thread with Id: " + Thread.CurrentThread.ManagedThreadId);
        }

        public static void SecondMethod()
        {
            Console.WriteLine("Second Method on Thread with Id: " + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(9000);
            Console.WriteLine("Second Method Continuation on Thread with Id: " + Thread.CurrentThread.ManagedThreadId);
        }

        public static void ThirdMethod()
        {
            Console.WriteLine("Third Method on Thread with Id: " + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(8000);
            Console.WriteLine("Third Method Continuation on Thread with Id: " + Thread.CurrentThread.ManagedThreadId);
        }
        public static void FourMethod()
        {
            Console.WriteLine("Nama : Zahra with Id: " + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(7000);
        }
        public static void FiveMethod()
        {
            Console.WriteLine("Prodi : Manajemen Informatika with Id: " + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(6000);
        }
        public static void ExecuteMultithreading()
        {
            Thread t1 = new Thread(new ThreadStart(FirstMethod));
            Thread t2 = new Thread(new ThreadStart(SecondMethod));
            Thread t3 = new Thread(new ThreadStart(ThirdMethod));
            Thread t4 = new Thread(new ThreadStart(FourMethod));
            Thread t5 = new Thread(new ThreadStart(FiveMethod));

            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t5.Start();
        }
    }
}
