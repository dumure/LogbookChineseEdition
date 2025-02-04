using HttpVersion = System.Net.HttpVersion;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRouting(opts => { opts.LowercaseUrls = true; });
builder.Services.ConfigureHttpClientDefaults(b =>
{
    b.ConfigureHttpClient(client => { client.DefaultRequestVersion = HttpVersion.Version20; });
});
builder.Services.AddCors();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.UseCors(configure => { configure.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin(); });
app.UseHttpsRedirection();

app.Run();