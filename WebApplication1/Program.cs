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
                api.Authorize(new ApiAuthParams{ AccessToken = "vk1.a.netVOAeA61uQimbwhyb9tFAB4ojuOZ6Xm9ddg2E5w64q3DB7KBr3Xp3ZGA_vnI7XQ5Jg0_O_iFEZeWqTg_OWQCQGNJZYKTqlyq8TLSU0PA6P7_e_NlpR9zpG42_YgiOb56ENGTWWa4mItkUEbZ4af3NuxjlCL1BU3TqA67NnZCG564S5ynBPKjosbYjqRe90jRQ-YtVets_YkvFk88iWsw" });
                return api;
            });
builder.Services.AddSwaggerGen();
builder.Services.AddMvc();

builder.Services.AddMvc().AddNewtonsoftJson();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.UseAuthorization();

app.MapControllers();

app.Run();