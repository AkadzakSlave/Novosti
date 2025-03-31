using Microsoft.AspNetCore.Components;
using Models.Services;
using Novosti.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddSingleton<CookieService>();//ПЕЧЕНЬЕ МАРКЕТ
builder.Services.AddSingleton<CartService>();//КОРЗИНА
builder.Services.AddSingleton<MoneyService>();//БАЛАНС
builder.Services.AddSingleton<AuthProvider>();//AUTH
builder.Services.AddSingleton<PermissionProvider>();//PERMISSION
builder.Services.AddSingleton<UsersStorage>();
builder.Services.AddSingleton<RateService>();//ОТЗЫВЫ
builder.Services.AddSingleton<DateTimeService>();
builder.Services.AddSingleton<Test>();//ИНТЕРФЕЙС, РЕАЛИЗАЦИЯ
builder.Services.AddScoped<Test>();
builder.Services.AddTransient<Test, Test>();
    //наследуется от BackgroundService
builder.Services.AddHostedService<Test>();//Фоновый сервис
    //Доступ к зависимостям осуществляется с помощью атрибута @inject в ASP.NET
//в остальных случаях через конструкторы класса



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();

public class Test : BackgroundService
{
    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        return Task.CompletedTask; // Функционал
    }
}