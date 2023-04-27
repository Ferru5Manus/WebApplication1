using Microsoft.AspNetCore.Mvc;
using VkNet.Abstractions;

namespace WebApplication1.Controllers;

[Route("VkCallbacks")]
[ApiController]
public class CallbackController : ControllerBase
{
    /// <summary>
    /// Конфигурация приложения
    /// </summary>
    private readonly IConfiguration _configuration;
    private readonly IVkApi _vkApi;
    public CallbackController(IConfiguration configuration,IVkApi api)
    {
        _configuration = configuration;
        _vkApi = api;
    }

    [HttpPost]
    [Route("confirmation")]
    public Task Callback([FromBody] Updates updates)
    {
        Console.WriteLine("fired");
        // Тип события
        switch (updates.Type)
        {
            // Если это уведомление для подтверждения адреса
            case "confirmation":
                // Отправляем строку для подтверждения 
                HttpContext.Response.WriteAsJsonAsync("2644ba0e");
                
                return Task.CompletedTask;
        }

        return Task.CompletedTask;
    }
}
