
using AutoRepairShop.AutoMapper;
using AutoRepairShop.DTO;
using AutoRepairShop.Repository;
using AutoRepairShop.Repository.EF;
using AutoRepairShop.Repository.Interfaces;
using AutoRepairShop.Services;
using AutoRepairShop.Services.Interfaces;
using AutoRepairShop.Utils;
using AutoRepairShop.Validation;
using FluentValidation;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

namespace AutoRepairShop
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
            builder.Services.AddSwaggerGen(c =>
            {
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = @"JWT Authorization header using the Bearer scheme. \r\n\r\n 
                      Enter 'Bearer' [space] and then your token in the text input below.
                      \r\n\r\nExample: 'Bearer 12345abcdef'",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });
            });

            builder.Services.AddSingleton<IAcceptanceDocumentRepository, AcceptanceDocumentRepository>();
            builder.Services.AddSingleton<ICarRepository, CarRepository>();
            builder.Services.AddSingleton<ICustomerRepository, CustomerRepository>();
            builder.Services.AddSingleton<IDocumentLineRepository, DocumentLineRepository>();
            builder.Services.AddSingleton<IEmployeeRepository, EmployeeRepository>();
            builder.Services.AddSingleton<IServiceRepository, ServiceRepository>();
            builder.Services.AddSingleton<IShiftRepository, ShiftRepository>();
            builder.Services.AddSingleton<IUserRepository, UserRepository>();
            builder.Services.AddSingleton<IAcceptanceDocumentService, AcceptanceDocumentService>();
            builder.Services.AddSingleton<ICarService, CarService>();
            builder.Services.AddSingleton<ICustomerService, CustomerService>();
            builder.Services.AddSingleton<IDocumentLineService, DocumentLineService>();
            builder.Services.AddSingleton<IEmployeeService, EmployeeService>();
            builder.Services.AddSingleton<IServiceService, ServiceService>();
            builder.Services.AddSingleton<IShiftService, ShiftService>();
            builder.Services.AddSingleton<IAuthService, AuthService>();
            builder.Services.AddSingleton<IUserService, UserService>();

            builder.Services.AddAutoMapper(typeof(MappingProfile));
            builder.Services.AddSingleton<IValidator<AcceptanceDocumentDTO>, AcceptanceDocumentDTOValidator>();

            string connectionString = builder.Configuration.GetConnectionString("MSSQL");
            AutoRepairShopContext.ConnectionString = connectionString;

            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                    .AddJwtBearer(options =>
                    {
                        options.RequireHttpsMetadata = false;
                        options.TokenValidationParameters = new TokenValidationParameters
                        {
                            // укзывает, будет ли валидироваться издатель при валидации токена
                            ValidateIssuer = true,
                            // строка, представляющая издателя
                            ValidIssuer = AuthOptions.ISSUER,

                            // будет ли валидироваться потребитель токена
                            ValidateAudience = true,
                            // установка потребителя токена
                            ValidAudience = AuthOptions.AUDIENCE,
                            // будет ли валидироваться время существования
                            ValidateLifetime = true,

                            // установка ключа безопасности
                            IssuerSigningKey = AuthOptions.GetSymmetricSecurityKey(),
                            // валидация ключа безопасности
                            ValidateIssuerSigningKey = true,
                        };
                    });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthentication();

            app.UseAuthorization();

            app.MapControllers()/*.RequireAuthorization()*/;

            app.Run();
        }
    }
}
