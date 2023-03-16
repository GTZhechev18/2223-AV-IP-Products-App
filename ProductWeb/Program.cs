using MinimalAuthAPI.Models;
using MinimalAuthAPI.Services;
using System.Data;
using System.Runtime.InteropServices;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IUserService, UserService>();
builder.Services.AddSingleton(<IMovieService, MovieService> );

var app = builder.Build();

app.UseSwagger();

app.MapGet("/", () => "Hello World");
app.MapPost("/login", (UserLogin user));
app.MapPost("/login",
    (Movie movie, IMovieService service) => Create(movie, service));

app.MapGet("/get",
    (int id,IMovieService service) => Get(id, service));

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

IResult Create(Movie movie,IMovieService service)
{
    var result = service.Create(movie);
    return Result.Ok(result);
}

IResult Get(int id, IMovieService service)
{
    var movies = service.List();
    return Results.Ok( movies );
}

app.Run();
