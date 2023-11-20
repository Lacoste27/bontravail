using bontravailapi.Models;
using bontravailapi.Service.BonTravails;
using bontravailapi.Service.Role;
using bontravailapi.Service.Utilisateurs;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionstring = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services
        .AddControllers()
        .AddNewtonsoftJson(options =>
            options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<BonTravailContext>(options => 
        options.UseSqlServer(connectionstring)
                .UseLoggerFactory(LoggerFactory.Create(builder =>builder.AddConsole()))
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors()
    );

builder.Services.AddTransient<IBonTravailService, BonTravailService>();
builder.Services.AddTransient<IRolesService, RolesService>();
builder.Services.AddTransient<IUtilisateurService, UtilisateurService>();

var app = builder.Build();

if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
