using Logging.Infrastructure;
using Logging.Application;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();


/////////
//ocnfigure the azue app service logging provider.
builder.Logging.AddAzureWebAppDiagnostics();


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

app.Logger.LogInformation("Logging Applicatoin Started");
app.Logger.LogWarning("Please check your name one more time seems that not good");
app.Logger.LogError("Your input is givning the issue . thats why we are getting error");

app.Run();


//sucessfull message
//warning message
//error messags
