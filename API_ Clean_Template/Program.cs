using API__Clean_Template.InfraStructure;

namespace API__Clean_Template
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Automatically loads appsettings.json and appsettings.{Environment}.json
            var environment = builder.Environment.EnvironmentName;
            // Add services to the container.
            builder.Services.AddControllers( );
            builder.Services.AddEndpointsApiExplorer( );
            builder.Services.AddSwaggerGen( );
            //builder.Services.AddScoped<FluentValidation.IValidator<TestMOdel>, ModelValidations>();

            builder.Services.AddInfrastructure(builder.Configuration);

            // Configure CORS policy
            builder.Services.AddCors(options => {
                options.AddPolicy("AllowAll",
                    builder => builder.AllowAnyOrigin( )
                                      .AllowAnyMethod( )
                                      .AllowAnyHeader( ));
            });

            var app = builder.Build( );

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment( ) ||
                app.Environment.IsStaging( ))
            {
                app.UseSwagger( );
                app.UseSwaggerUI( );
            }

            app.UseHttpsRedirection( );

            app.UseAuthorization( );

            app.UseCors("AllowAll");

            app.MapControllers( );

            app.Run( );
        }
    }
}
