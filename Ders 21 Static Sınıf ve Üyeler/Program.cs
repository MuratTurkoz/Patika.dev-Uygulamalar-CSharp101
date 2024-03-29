﻿using System;

namespace Ders_21_Static_Sınıf_ve_Üyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan Sayısı: {0}", Worker.WorkerCount);
            Worker worker = new Worker("Mrat", "XX", "Educa");
            Console.WriteLine("Çalışan Sayısı: {0}", Worker.WorkerCount);
            Worker worker2 = new Worker("Ali", "XX", "Educa");
            Console.WriteLine("Çalışan Sayısı: {0}", Worker.WorkerCount);
            Worker worker3 = new Worker("Veli", "XX", "Educa");
            Console.WriteLine("Çalışan Sayısı: {0}", Worker.WorkerCount);
            //Static sınıflar new lenmez
            Console.WriteLine("Toplama işlemi sonucu: {0}", Transactions.Collection(5, 6));
            Console.WriteLine("TÇıkarma işlemi sonucu: {0}", Transactions.Extraction(5, 6));

        }

    }
    class Worker
    {
        private string name;
        private string lastName;
        //Bir sınıfın static olamayan üyelerine nesneler aracılığıyla erişirken static olan metotlara ve özelliklere ise nesne oluşturmadan o sınıfın ismi aracılığıyla erişiriz.
        private static int workerCount;
        private string departman;

        public static int WorkerCount { get => workerCount; }
        public Worker(string name, string lastName, string departman)
        {
            this.name = name;
            this.lastName = lastName;
            this.departman = departman;
            workerCount++;
        }
        static Worker()
        {
            workerCount = 0;
        }
    }
    static class Transactions
    {
        public static long Collection(int number1, int number2)
        {
            return number1 + number2;
        }
        public static long Extraction(int number1, int number2)
        {
            return number1 - number2;
        }
    }
}
