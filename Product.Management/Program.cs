using Microsoft.EntityFrameworkCore;
using Product.Management.Context;
using Product.Management.Interface;
using Product.Management.Service;

namespace Product.Management
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            
            builder.Services.AddDbContext<DbContext__>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("CQRS_Product_Management_Connection"));
            });

            builder.Services.AddTransient<IProductManagementRepo, ProductManagementRepo>();
            builder.Services.AddTransient<IGetProductRepo, GetProductRepo>();
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
}