using BLL.function;
using BLL.Interfaces;
using DAL.function;
using DAL.Interfaces;
using DAL.Models;
using DAL.Models.function;
using DAL.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddControllers().AddJsonOptions(o => o.JsonSerializerOptions.PropertyNamingPolicy = null);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//הגדרת הרשאת גישה
builder.Services.AddCors(opotion => opotion.AddPolicy("AllowAll",
    p => p.AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader()));

builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddDbContext<HmoDbContext>(x => x.UseSqlServer("Server=.\\SQLEXPRESS;Database=HMO_DB;Trusted_Connection=True;"));

//הזרקת תלויות של ממשקים ומחלקות 
builder.Services.AddScoped(typeof(Imembers), typeof(MemberDB));
builder.Services.AddScoped(typeof(IvaccintedMbrDB), typeof(VaccintedMbrDB));
builder.Services.AddScoped(typeof(IVaccinationDB), typeof(VaccinationDB));
builder.Services.AddScoped(typeof(ICoronaPatientDB), typeof(CoronaPatientDB));


builder.Services.AddScoped(typeof(ImemberBLL), typeof(MemberBLL));
builder.Services.AddScoped(typeof(IVaccMbrBll), typeof(VaccinatedMbrBll));
builder.Services.AddScoped(typeof(IVaccinationBll), typeof(VaccinationBll));
builder.Services.AddScoped(typeof(ICoronaPatientBLL), typeof(CoronaPatientBll));

var app = builder.Build();
app.UseCors("AllowAll");




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
