var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
int workerThread, threads;

ThreadPool.GetAvailableThreads(out workerThread, out threads);

//var success = ThreadPool.SetMaxThreads(Environment.ProcessorCount+13, Environment.ProcessorCount+13);

var success = ThreadPool.SetMaxThreads(50, 50);

ThreadPool.GetAvailableThreads(out workerThread, out threads);


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();

app.UseAuthorization(); 

app.MapControllers();

app.Run();
