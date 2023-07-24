using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace AwaitTask.TestClasses
{
    public class Kitchen : IKitchen
    {

        public Action YumurtalariKir()
        {
            Task.Delay(500).Wait();

            return () =>
            {
                Console.WriteLine("Yumurtalar Kırıldı...");
            };
        }
        public Action TuzEkle()
        {
            Task.Delay(300).Wait();

            return () =>
            {
                Console.WriteLine("Tuz Eklendi...");
            };
        }
        public Action YumurtalariCirp()
        {
            Task.Delay(500).Wait();

            return () =>
            {
                Console.WriteLine("Yumurtalar Cırpıldı...");
            };
        }
        public Action OcagiAc()
        {
            Task.Delay(150).Wait();
            
            return () =>
            {
                Console.WriteLine("Ocak Acildi...");
            };
        }

        public Action TavayiIsit()
        {
            Task.Delay(650).Wait();

            return () =>
            {
                Console.WriteLine("Tava Isindi...");
            };
        }
        public Action YagiDok()
        {
            Task.Delay(300).Wait();

            return () =>
            {
                Console.WriteLine("Yag Dokuldu...");
            };
        }
        public Action YumurtalariDok()
        {
            Task.Delay(650).Wait();

            return () =>
            {
                Console.WriteLine("Yumurtalar Dokuldu...");
            };
        }

        public Action Pisir()
        {
            Task.Delay(1000).Wait();

            return () =>
            {
                Console.WriteLine("Yumurtalar Pisti...");
            };
        }

        public Action ServisEt()
        {
            Task.Delay(750).Wait();

            return () =>
            {
                Console.WriteLine("Yumurtalar Servis Edildi.......");
            };
        }

       public void YumurtaYap()
        {
            //Action action;

            var sw = Stopwatch.StartNew();
            
            YumurtalariKir().Invoke();
            TuzEkle().Invoke();
            YumurtalariCirp().Invoke();
            OcagiAc().Invoke();
            YagiDok().Invoke();
            TavayiIsit().Invoke();
            YumurtalariDok().Invoke();
            Pisir().Invoke();
            ServisEt().Invoke();

            sw.Stop();
            Console.WriteLine($"Total Time: {sw.ElapsedMilliseconds}");
        }

       
    }
}