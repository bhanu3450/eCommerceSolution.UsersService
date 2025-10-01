using eCommerce.Infrastructure;
using eCommerce.Core;

var builder = WebApplication.CreateBuilder(args);

// Add Infra services
builder.Services.AddInfrastructure();
builder.Services.AddCore();

// add controllers to the service collection
builder.Services.AddControllers();

var app = builder.Build();

// Routing
app.UseRouting();

//Auth
app.UseAuthorization();
app.UseAuthentication();

//Controller Routes
app.MapControllers();

app.Run();
