using System.Net;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseWebSockets();

app.Map(pattern:"/", requestDelegate:async context =>
{
    if (!context.WebSockets.IsWebSocketRequest)
        context.Response.StatusCode = (int)HttpStatusCode.BadRequest;

    using var webSocket = await context.WebSockets.AcceptWebSocketAsync();

    var data - Encoding.ASCII.GetBytes(s:$".NET Rocks -> {DateTime.Now}");
});

await app.RunAsync();