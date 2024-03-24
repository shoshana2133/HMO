using BLL.function;
using BLL.Interfaces;
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

//����� ����� ����
builder.Services.AddCors(opotion => opotion.AddPolicy("AllowAll",//����� �� ������
    p => p.AllowAnyOrigin()//����� �� ����
    .AllowAnyMethod()//�� ����� - �������
    .AllowAnyHeader()));//��� ����� �������

builder.Services.AddAutoMapper(typeof(Program));
//����� ����� ������� �� ������ ���� ��� ���� ��� ����
//����� ���� ����:
//��� ������ �DBContext:
builder.Services.AddDbContext<HmoDbContext>(x => x.UseSqlServer("Server=.\\SQLEXPRESS;Database=HMO_DB;Trusted_Connection=True;"));

//����� ������ �� ������ ������� 
builder.Services.AddScoped(typeof(Imembers), typeof(MemberDB));


builder.Services.AddScoped(typeof(ImemberBLL), typeof(MemberBLL));

var app = builder.Build();

//����� ������ ���� 
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
