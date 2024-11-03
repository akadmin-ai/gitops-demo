var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

// GET UTC
app.MapGet("time/utc", () => Results.Ok(DateTime.UtcNow));

// GET Local Time
app.MapGet("time/local", () => Results.Ok(DateTime.Now));

await app.RunAsync();
