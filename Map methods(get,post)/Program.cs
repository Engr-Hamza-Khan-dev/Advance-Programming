var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.Map("/Home", () => "Hello This is map method!");
//app.MapGet("/Home", () => "Hello This is Get method - Get!");
//app.MapPost("/Home", () => "Hello This is Post method - Post!");
//app.MapPut("/Home", () => "Hello This is Put method - Put!");
//app.MapDelete("/Home", () => "Hello This is Delete method - Delete!");
//app.MapPatch("/Home", () => "Hello This is Patch method - Patch!");


app.UseRouting();
app.UseEndpoints(endpoint =>
{
    endpoint.MapGet("/Home", async (context) =>
    await context.Response.WriteAsync("This is Get method")
    );
    endpoint.MapPost("/Home", async (context) =>
    await context.Response.WriteAsync("This is post method")
    );
    endpoint.MapPut("/Home", async (context) =>
    await context.Response.WriteAsync("This is put method")
    );
    endpoint.MapDelete("/Home", async (context) =>
    await context.Response.WriteAsync("This is Delete method")
    );
});

//This is front page ( / )
app.Run(async (HttpContext context) => {
    context.Response.WriteAsync("Page not found");
    }
);

app.Run();