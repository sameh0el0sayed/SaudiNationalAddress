using SaudiNationalAddress;
using SaudiNationalAddress.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// Enable API Controllers
builder.Services.AddControllers();

// HttpClient for National Address API
builder.Services.AddHttpClient();

// Register National Address Service
builder.Services.AddScoped<NationalAddressService>();

// Google Maps Configuration
builder.Services.Configure<GoogleMapsOptions>(
    builder.Configuration.GetSection("GoogleMaps"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Map API Controllers
app.MapControllers();

// Map Razor Pages
app.MapRazorPages();

app.Run();