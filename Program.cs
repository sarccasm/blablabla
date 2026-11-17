using OrderSystem.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<ITimeService, TimeService>();

var app = builder.Build();

// Log all requests before routing, including static assets and missing routes.
app.Use(async (context, next) =>
{
    context.Response.OnCompleted(() =>
    {
        app.Logger.LogInformation("{Method} {Path} => {StatusCode}",
            context.Request.Method, context.Request.Path, context.Response.StatusCode);
        return Task.CompletedTask;
    });
    await next(context);
});

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseHttpsRedirection();
}

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
