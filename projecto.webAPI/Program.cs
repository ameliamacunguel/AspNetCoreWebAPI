using Microsoft.EntityFrameworkCore;
using projecto.webAPI.Data;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var configuration = builder.Configuration;
        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        
        builder.Services.AddDbContext<ProjectoContext>(
            context => context.UseSqlite(configuration.GetConnectionString("Default"))
        );
//(configuration.GetConnectionString("Default"))
    //     services.AddDbContext<BookStoreDbContext>(options =>
    // {
    //    options.UseSqlServer(configuration.GetConnectionString("Sqlcon"));
    // }
        

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}