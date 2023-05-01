using ACT.Repository;
using ACT.Repository.Interfaces;
using ACT.Services;
using ACT.Services.Interfaces;

namespace ACT
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddSingleton<IData, Data>();

            // Add services to the container.
            builder.Services.AddTransient<IRepositoryConsolidatedDay, RepositoryConsolidatedDay>();
            builder.Services.AddTransient<IRepositoryLaunch, RepositoryLaunch>();

            builder.Services.AddScoped<IConsolidatedDayService, ConsolidatedDayService>();
            builder.Services.AddScoped<ILaunchService, LaunchService>();

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}