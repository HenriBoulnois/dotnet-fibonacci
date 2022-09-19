using Leonardo;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/Fibonacci", 
     () => Fib.RunAsync(new []{"44", "43"}));

app.Run();
