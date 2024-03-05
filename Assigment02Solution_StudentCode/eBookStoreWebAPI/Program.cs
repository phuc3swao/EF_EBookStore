using BusinessObject.Models;
using DataAccess.BusinessLogic;
using DataAccess.Repository;
using Microsoft.AspNetCore.OData;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;

namespace eBookStoreWebAPI
{
    public class Program
    {
        public static IEdmModel GetEdmModel()
        {
            ODataConventionModelBuilder modelBuider= new ODataConventionModelBuilder();
            modelBuider.EntitySet<Book>("Books");
            return modelBuider.GetEdmModel();
        }
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddScoped<IPublisherRepository, PublisherRepository>();
            builder.Services.AddScoped<IBookRepository, BookRepository>();
            builder.Services.AddScoped<IAuthorRepository, AuthorRepository>();
            builder.Services.AddScoped<AuthBussiness>();

            builder.Services.AddControllers().AddOData(options => options
        .Select()
        .Filter()
        .Expand()
        .SetMaxTop(100)
        .Count()
        .OrderBy().AddRouteComponents("odata", GetEdmModel()));
            ;
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
}