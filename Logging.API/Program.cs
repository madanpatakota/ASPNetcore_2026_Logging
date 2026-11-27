using Logging.Infrastructure;
using Logging.Application;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();


/////////


builder.Services.AddControllers();


// regsiter swagger api reslated services
builder.Services.AddEndpointsApiExplorer();

//add register the swagger service
builder.Services.AddSwaggerGen();



// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapin
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

//JosnDocumentation of the apis 
app.UseSwagger();

//enagble UI
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
