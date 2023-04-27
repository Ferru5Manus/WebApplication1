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
    public IActionResult Callback([FromBody] Updates updates)
    {
        // Тип события
        Console.WriteLine(updates.Type);

        return Ok("ok");
    }
}
