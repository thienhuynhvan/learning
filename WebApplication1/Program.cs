// using Microsoft.AspNetCore.Rewrite;
//
// var builder = WebApplication.CreateBuilder(args);
// var app = builder.Build();
// // tro den about khi go history
//
// app.Use(async (context, next) =>
// {
//     await next(); 
//     Console.WriteLine($"{context.Request.Method} {context.Request.Path} {context.Response.StatusCode}");
// });
//
// app.UseRewriter(new RewriteOptions().AddRedirect("history", "about"));
// app.MapGet("/", () => "Hello World!");
// app.MapGet("/about", () => "chao ban nhe!");
//
// app.Run();

//basic
// using WebApplication1;
//
// var builder = WebApplication.CreateBuilder(args);
//     
// builder.Services.AddSingleton<IPersonService,PersonService>();
// var app = builder.Build();
//
// app.MapGet("/", 
//     (IPersonService personService) => 
//     {
//         return $"Hello, {personService.GetPersonName()}!";
//     }
// );
//     
// app.Run();


//using inteface
using WebApplication1;

var builder = WebApplication.CreateBuilder(args);
    
builder.Services.AddSingleton<IPersonService,PersonService>();
var app = builder.Build();

app.MapGet("/", 
    (IPersonService personService) => 
    {
        return $"Hello, {personService.GetPersonName()}!";
    }
);

app.Run();

