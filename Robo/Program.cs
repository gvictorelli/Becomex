using Robo.Interfaces;
using Robo.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICotoveloEsquerdoService, CotoveloEsquerdoService>();
builder.Services.AddScoped<ICotoveloDireitoService, CotoveloDireitoService>();
builder.Services.AddScoped<IPulsoDireitoService, PulsoDireitoService>();
builder.Services.AddScoped<IPulsoEsquerdoService, PulsoEsquerdoService>();
builder.Services.AddScoped<ICabecaInclinacaoService, CabecaInclinacaoService>();
builder.Services.AddScoped<ICabecaRotacaoService, CabecaRotacaoService>();


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
