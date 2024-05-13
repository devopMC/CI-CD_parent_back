using METABack.Entities;
using METABack.Interfaces;
using METABack.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Net.Sockets;
using System.Net;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.Extensions.FileProviders;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore;
using Microsoft.Extensions.Hosting;
var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddCors(options =>
//{
//    options.AddPolicy("CorsPolicy",
//       builder => builder.AllowAnyOrigin()
//            .AllowAnyMethod()
//            .SetIsOriginAllowed(_ => true)
//            .AllowAnyHeader()
//            .AllowCredentials()
//            );
//});

//builder.Services.AddCors(o => o.AddPolicy("CorsPolicy", builder =>
//{
//    builder.AllowAnyMethod()
//        .AllowAnyHeader()
//        .SetIsOriginAllowed(_ => true)
//        .AllowCredentials();
//}));

builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
       builder => builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());
});

builder.Services.Configure<FormOptions>(o =>
{
    o.ValueLengthLimit = int.MaxValue;
    o.MultipartBodyLengthLimit = int.MaxValue;
    o.MemoryBufferThreshold = int.MaxValue;
});

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<DatabaseContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("dbConnection")));
builder.Services.AddTransient<IEtablissements, EtablissementRepository>();
builder.Services.AddTransient<INomenclatureSignalisation, NomenclatureSignalisationRepository>();
builder.Services.AddTransient<ISignalisationFichier, SignalisationFichierRepository>();
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
app.UseStaticFiles();
app.UseCors("CorsPolicy");
app.UseStaticFiles(new StaticFileOptions()
{
    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @"Resources")),
    RequestPath = new PathString("/Resources")
});
app.UseAuthorization();
//app.MapControllers();//

//app.Run();//
app.MapControllers();

string localIP = LocalIPAddress();

app.Urls.Add("http://" + localIP + ":5073");
app.Urls.Add("https://" + localIP + ":7073");

app.Run();

static string LocalIPAddress()
{
    using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
    {
        socket.Connect("8.8.8.8", 65530);
        IPEndPoint? endPoint = socket.LocalEndPoint as IPEndPoint;
        if (endPoint != null)
        {
            return endPoint.Address.ToString();
        }
        else
        {
            return "127.0.0.1";
        }
    }
}

