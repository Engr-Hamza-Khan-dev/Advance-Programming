var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

//This will run the default root which is /home 
//app.MapDefaultControllerRoute();

//We can also open our own route (like about page) instead of default home page
app.MapControllerRoute(
    name:"default",
    pattern: "{controller=About}/{action=Index}/{Id?}"
    );



//************** Middleware uses************
//app.Use(async (context,next) =>
//{
//    await context.Response.WriteAsync("my name is hamza \n");
//    await next();
//    await context.Response.WriteAsync("Good byee... \n");
//});

//app.Run(async (context) =>
//{
//    await context.Response.WriteAsync("I am a software engineer\n");
//});
//app.MapGet("/", () => "Hello World!");

app.Run();
