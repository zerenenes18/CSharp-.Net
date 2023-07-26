// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using WebAppTest.Console;

Console.WriteLine("Hello, World!");




	do
	{
        AddLog("App is running...");

        Console.Write("Request Type (async: 0 , sync: 1 ): ");
        int requestType = int.Parse(Console.ReadLine());

        Console.Write("How many request: ");
        int requestCount = int.Parse(Console.ReadLine());
        var webApiClient = new WebApiClient();

        var sw = Stopwatch.StartNew();

        var tasks = requestType == 0 ? GetAsyncTasks(requestCount) : GetSyncTasks(requestCount);

        await Task.WhenAll(tasks);
        sw.Stop();
        AddLog($"Total Time:{sw.ElapsedMilliseconds}MS ");

    } while (Console.ReadKey().Key == ConsoleKey.R );



static  IEnumerable<Task> GetAsyncTasks(int howMany)
{
    var tasks = new List<Task>();

    WebApiClient webApiClient = new WebApiClient();


    for (int i = 0; i < howMany; i++)
    {
        tasks.Add(webApiClient.CallAsync());
    }
    return tasks;
}

static IEnumerable<Task> GetSyncTasks(int howMany)
{
    var tasks = new List<Task>();

    WebApiClient webApiClient = new WebApiClient();


    for (int i = 0; i < howMany; i++)
    {
        tasks.Add(webApiClient.CallSync());
    }
    return tasks;
}

static void AddLog(string logStr)
{
    logStr = $"[{DateTime.Now:dd.MM.yyyy HH:mm:ss}] - {logStr}";

    Console.WriteLine(logStr);

}