using REST.Adapter.Internals;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddEndpoints<Program>(builder.Configuration);


var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();
app.UseEndpoints<Program>();


app.Run();
