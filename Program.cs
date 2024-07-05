using Microsoft.EntityFrameworkCore;
using dotenv.net;


DotEnv.Load();
var builder = WebApplication.CreateBuilder(args);
var connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING");
var serverVersion = new MySqlServerVersion(new Version(8, 0, 36));



builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppContext>(options => options.UseMySql(connectionString, serverVersion));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseExceptionHandler("/error/500");
app.UseStatusCodePagesWithReExecute("/error/{0}");

app.Run();
