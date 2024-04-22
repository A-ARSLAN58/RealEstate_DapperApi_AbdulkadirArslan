using RealEstate_DapperApi_AbdulkadirArslan.Hubs;
using RealEstate_DapperApi_AbdulkadirArslan.Models.DapperContext;
using RealEstate_DapperApi_AbdulkadirArslan.Repositories.BottomGridRepositories;
using RealEstate_DapperApi_AbdulkadirArslan.Repositories.BottomGridRepository;
using RealEstate_DapperApi_AbdulkadirArslan.Repositories.CategoryRepository;
using RealEstate_DapperApi_AbdulkadirArslan.Repositories.ContactRepositories;
using RealEstate_DapperApi_AbdulkadirArslan.Repositories.EmployeeRepositories;
using RealEstate_DapperApi_AbdulkadirArslan.Repositories.PopularLocationRepositories;
using RealEstate_DapperApi_AbdulkadirArslan.Repositories.ProductRepository;
using RealEstate_DapperApi_AbdulkadirArslan.Repositories.ServiceRepository;
using RealEstate_DapperApi_AbdulkadirArslan.Repositories.StatisticsRepositories;
using RealEstate_DapperApi_AbdulkadirArslan.Repositories.TestimonialRepositories;
using RealEstate_DapperApi_AbdulkadirArslan.Repositories.ToDoListRepositories;
using RealEstate_DapperApi_AbdulkadirArslan.Repositories.WhoWeAreDetailRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddTransient<Context>();
builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();
builder.Services.AddTransient<IWhoWeAreDetailRepository, WhoWeAreDetailRepository>();
builder.Services.AddTransient<IServiceRepository, ServiceRepository>();
builder.Services.AddTransient<IBottomGridRepository, BottomGridRepository>();
builder.Services.AddTransient<IProductRepository, ProductRepository>();
builder.Services.AddTransient<IPopularLocationRepository, PopularLocationRepository>();
builder.Services.AddTransient<ITestimonialRepository, TestimonialRepository>();
builder.Services.AddTransient<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddTransient<IStatisticsRepository, StatisticsRepository>();
builder.Services.AddTransient<IContactRepository, ContactRepository>();
builder.Services.AddTransient<IToDoListRepository, ToDoListRepository>();


builder.Services.AddCors(opt =>
{
    opt.AddPolicy("CorsPolicy", builder =>
    {
        builder.AllowAnyHeader()
        .AllowAnyMethod()
        .SetIsOriginAllowed((host) => true)
        .AllowCredentials();
    });
});

builder.Services.AddSignalR();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.MapHub<SignalRHub>("/signalrhub");

app.Run();
