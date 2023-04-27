using VkNet;
using VkNet.Abstractions;
using VkNet.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSingleton<IVkApi>(sp => {
                var api = new VkApi();
                api.Authorize(new ApiAuthParams{ AccessToken = "vk1.a.YP-Qgq8dfjDt0rnInduZtF8lvi0LGWqBpn83CeXKz-ME8IaVmNJSlLCjFFCNO_n8SoCa2YdXFjDjIKI3w4fx7EbWBpFo7KKK6b8aZbhRgsxAZmht3RGDt3nevdT4XmPIaZPtGUErdw3yhUzWU-KyeWe9rI7vKqjFSJ_iRXxHP40esV-9BrsspUJDYNZhYpPp9ttEKjIHVwFf4uh2UoYT2w" });
                return api;
            });
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();