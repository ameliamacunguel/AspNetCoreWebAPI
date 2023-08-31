using AutoMapper;
using projecto.webAPI.Dtos;
using projecto.webAPI.Helpers;
using Microsoft.EntityFrameworkCore;
using projecto.webAPI.Data;

internal class Program
{
    
    
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var configuration = builder.Configuration;
        // Add services to the container.

         builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

         builder.Services.AddScoped<IRepository, Repository>();     

                 builder.Services.AddDbContext<ProjectoContext>(
            context => context.UseSqlite(configuration.GetConnectionString("Default"))
                
        ); 
          
    
       
        builder.Services.AddControllers()
                        .AddNewtonsoftJson(
                            opt => opt.SerializerSettings.ReferenceLoopHandling =
                                Newtonsoft.Json.ReferenceLoopHandling.Ignore);


        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

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