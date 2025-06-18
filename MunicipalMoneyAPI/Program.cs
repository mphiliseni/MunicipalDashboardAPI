using MunicipalMoneyApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Register HttpClient for MunicipalDataService with base address
builder.Services.AddScoped<IMunicipalDataService, MunicipalDataService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
