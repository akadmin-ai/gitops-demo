var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

// GET UTC
app.MapGet("time/utc", () => Results.Ok(DateTime.UtcNow));

// GET EST

//app.MapGet("time/est", () =>
//{
//   var estTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
// var estTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, estTimeZone);
//return Results.Ok(estTime);
// });


await app.RunAsync();
