using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwaitTask.TestClasses
{
    public class AsyncKitchen
    {
        public async Task YumurtalariKir()
        {
            
            
            await Task.Delay(500);
            
            Console.WriteLine("Yumurtalar Kırıldı...");
           
        }
        public async Task TuzEkle()
        {
            await Task.Delay(300);

            
            
            Console.WriteLine("Tuz Eklendi...");
           
        }
        public async Task YumurtalariCirp()
        {
            await Task.Delay(500);

            
            Console.WriteLine("Yumurtalar Cırpıldı...");
            
        }
        public async Task OcagiAc()
        {
            await Task.Delay(100);
  
            Console.WriteLine("Ocak Acildi...");
            
        }

        public async Task TavayiIsit()
        {
            await Task.Delay(200);

            Console.WriteLine("Tava Isindi...");
           
        }
        public async Task YagiDok()
        {
            await Task.Delay(700);

            
                Console.WriteLine("Yag Dokuldu...");
            
        }
        public async Task YumurtalariDok()
        {
            await Task.Delay(650);
            
            Console.WriteLine("Yumurtalar Dokuldu...");
           
        }

        public async Task Pisir()
        {
            await Task.Delay(1000);

            Console.WriteLine("Yumurtalar Pisti...");
            
        }

        public async Task ServisEt()
        {
            Task.Delay(750).Wait();
            
            Console.WriteLine("Yumurtalar Servis Edildi.......");
            
        }

        public async Task YumurtaYap()
        {
            //Action action;

            var sw = Stopwatch.StartNew();



            var yumurtalariHazirla = await YumurtalariKir()
                .ContinueWith(async _ =>
            {
                await YumurtalariCirp();
                await TuzEkle();
            });

            var ocagıHazirla = await OcagiAc()
                .ContinueWith(async _ =>
                {
                    await YagiDok();
                    await TavayiIsit();
                });




            await Task.WhenAll(yumurtalariHazirla, ocagıHazirla);

            var yumurtalariPisir = await YumurtalariDok().ContinueWith(async _ =>
            {

                await Pisir();
                await ServisEt();
            });

            sw.Stop();
            Console.WriteLine($"Total Time: {sw.ElapsedMilliseconds}");
            



            //await YumurtalariKir();
            //await TuzEkle();
            //await YumurtalariCirp();
            //await OcagiAc();
            //await YagiDok();
            //await TavayiIsit();
            //await Pisir();
            //await ServisEt();
            //Task.Delay(4000).Wait();

            //sw.Stop();
            //Console.WriteLine($"Total Time: {sw.ElapsedMilliseconds}");
        }

    }
}
