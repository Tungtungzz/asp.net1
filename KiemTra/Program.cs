using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Connect db
string connectionString = "Data Source=LAPTOP-488HLOG4\\SQLEXPRESS;Initial Catalog=Demo;Integrated Security=True;Trust Server Certificate=True";
builder.Services.AddDbContext<KiemTra.Entities.DataContext>(
    options => options.UseSqlServer(connectionString)
);
// End

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Chọn Action và controller nào là trang chủ
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
