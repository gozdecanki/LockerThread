using System;
using System.Threading;

namespace LockerThread
{
    class Program
    {
        private static readonly Object locker = new Object();
        public static SemaphoreSlim SemaphoreSlim = new SemaphoreSlim(6);
        static void Main(string[] args)
        {

            Console.WriteLine("Threading");

            new Thread(BirTanesinSen).Start(1);
            new Thread(BirTanesinSen).Start(2);
            new Thread(BirTanesinSen).Start(3);
            new Thread(BirTanesinSen).Start(4);
            new Thread(BirTanesinSen).Start(5);

            Console.WriteLine("Main thread: Bekliyorum");
            Console.ReadLine();
        }


      


        public static void BirTanesinSen(object id)
        {
            Console.WriteLine("THREAD: " + id);

            lock (locker)
            {
                Console.WriteLine(id + " BirTanesinSen Started!");


                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(id + " Tur: " + i);
                    Thread.Sleep(1000);
                }


                Console.WriteLine(id + " BirTanesinSen end!");

            }


        }

    }
}
