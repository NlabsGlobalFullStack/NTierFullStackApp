using Business.Interfaces;
using Business.Mapping;
using Business.Services;
using DataAccess.Context;
using DataAccess.Interfaces;
using DataAccess.Repositories;
using Entities.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Cors Service Dependency Incejtion
builder.Services.AddCors(corsService =>
{
    corsService.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyHeader();
        policy.AllowAnyMethod();
        policy.AllowCredentials();
        policy.SetIsOriginAllowed(policy => true);
    });
});

//Jwt Dependency Injection
builder.Services.AddAuthentication().AddJwtBearer(options =>
{
    options.TokenValidationParameters = new()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateIssuerSigningKey = true,
        ValidateLifetime = true,
        ValidIssuer = "Cuma K�SE",
        ValidAudience = "Cuma K�SE",
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("benim �ifre anahtar�m benim �ifre anahtar�m benim �ifre anahtar�m benim �ifre anahtar�m benim �ifre anahtar�m"))
    };
});
builder.Services.AddAuthorization();

//DbContext
string? connectionString = builder.Configuration.GetConnectionString("SqlServer");
builder.Services.AddDbContext<AppDbContext>(opt =>
{
    opt.UseSqlServer(connectionString);
    //opt.LogTo(Console.WriteLine, LogLevel.Information); // Development mod'da sorgulr� g�rmemizi saglar console de
});

builder.Services.AddIdentity<AppUser, IdentityRole<Guid>>(options =>
{
    options.Password.RequiredLength = 1;
    options.Password.RequireDigit = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireLowercase = false;
})
    .AddEntityFrameworkStores<AppDbContext>();

//Dependency Injection
//AuthService Injection
//builder.Services.AddScoped<AuthService>();

//Repositories Injection
builder.Services.AddScoped<IAuthorRepository, AuthorRepository>();
//Services Injection
builder.Services.AddScoped<IAuthorService, AuthorService>();

//Jwt Injection
builder.Services.AddScoped<IJwtProvider, JwtProvider>();

//Automapper Injection
builder.Services.AddAutoMapper(typeof(MappingProfile).Assembly);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//Swagger Authentication Injection
builder.Services.AddSwaggerGen(setup =>
{
    var jwtSecuritySheme = new OpenApiSecurityScheme
    {
        BearerFormat = "JWT",
        Name = "JWT Authentication",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.Http,
        Scheme = JwtBearerDefaults.AuthenticationScheme,
        Description = "Put **_ONLY_** yourt JWT Bearer token on textbox below!",

        Reference = new OpenApiReference
        {
            Id = JwtBearerDefaults.AuthenticationScheme,
            Type = ReferenceType.SecurityScheme
        }
    };

    setup.AddSecurityDefinition(jwtSecuritySheme.Reference.Id, jwtSecuritySheme);

    setup.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    { jwtSecuritySheme, Array.Empty<string>() }
                });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//Cors Start
app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
