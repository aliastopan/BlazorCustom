using Microsoft.FluentUI.AspNetCore.Components;
using BlazorCustom.Components;
using BlazorCustom.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddFluentUIComponents();

builder.Services.AddHttpContextAccessor();

var app = builder.Build();

app.UseMiddleware<ExceptionHandlingMiddleware>();
app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();
    // .AddHubOptions(options =>
    // {
    //     options.ClientTimeoutInterval = TimeSpan.FromSeconds(60);
    //     options.HandshakeTimeout = TimeSpan.FromSeconds(30);
    // });

app.Run();
