var builder = WebApplication.CreateBuilder(args);

// 의존성 주입 설정
builder.Services.AddControllersWithViews();

var app = builder.Build();

// 미들웨어 설정 및 라우팅 설정
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.Run();