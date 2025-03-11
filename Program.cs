var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReactApp", policy =>
    {
        policy.WithOrigins("http://localhost:3000") // Permitir origem do React
              .AllowAnyHeader()                     // Permitir qualquer cabeçalho
              .AllowAnyMethod();                    // Permitir GET, POST, PUT, DELETE, etc.
    });
});

builder.WebHost.UseUrls("http://*:80");

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "Todo API v1");
    });
}

app.UseHttpsRedirection();
app.UseCors("AllowReactApp"); // Aplicar a política de CORS antes das rotas
app.UseAuthorization();
app.MapControllers();

app.Run();