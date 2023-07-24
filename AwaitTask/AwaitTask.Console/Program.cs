// See https://aka.ms/new-console-template for more information


using AwaitTask.TestClasses;

AsyncKitchen asyncKitchen = new AsyncKitchen();
Kitchen kitchen = new Kitchen();

await asyncKitchen.YumurtaYap();
//Console.WriteLine("------------");
//kitchen.YumurtaYap();
