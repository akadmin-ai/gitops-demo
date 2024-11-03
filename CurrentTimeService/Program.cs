var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

// GET UTC
app.MapGet("time/utc", () => Results.Ok(DateTime.UtcNow));


// GET PST
app.MapGet("time/pst", () =>
{
    var pstTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
    var pstTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, pstTimeZone);
    return Results.Ok(pstTime);
});

await app.RunAsync();
