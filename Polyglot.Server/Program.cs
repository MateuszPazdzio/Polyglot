using Microsoft.EntityFrameworkCore;
using Polyglot.Server.Infrastructure;
using Polyglot.Server.services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<PolyglotDbContext>(opt => opt.UseSqlServer(
    builder.Configuration.GetConnectionString("PolyglotDbConnection"))
);
builder.Services.AddScoped<IPolyglotRepository,PolyglotRepository>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowOrigin",
        builder => builder.AllowAnyOrigin() // Update with your Angular app URL
                          .AllowAnyMethod()
                          .AllowAnyHeader()
                          );
});

var app = builder.Build();

app.UseCors("AllowOrigin");

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

    var scope = app.Services.CreateScope();
    var db = scope.ServiceProvider.GetRequiredService<PolyglotDbContext>();

    //if (db.Database.CanConnect())
    //{
    //    //db.Database.EnsureDeleted();
    //    db.Database.EnsureCreated();
    //    var pendingMigrations = db.Database.GetPendingMigrations();
    //    if (pendingMigrations != null && pendingMigrations.Any() && pendingMigrations.Count()>0)
    //    {
    //        db.Database.Migrate();
    //    }
    //}
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
