using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using System.Text;

namespace Distrubutred.Cache.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ValuesController : ControllerBase
{
    readonly IDistributedCache _distrubutedCache;

    public ValuesController(IDistributedCache distrubutedCache)
    {
        _distrubutedCache = distrubutedCache;
    }

    [HttpGet("set")]
    public async Task<bool> Set(string name, string surname)
    {
        await _distrubutedCache.SetStringAsync("isim", name, options: new()
        {
            //AbsoluteExpiration = DateTimeOffset.UtcNow,
            SlidingExpiration = TimeSpan.FromSeconds(5),
            AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(15),
        });
        await _distrubutedCache.SetAsync("soyisim",Encoding.UTF8.GetBytes(surname), options: new()
        {
            //AbsoluteExpiration = DateTimeOffset.Now,
            AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(15),
            SlidingExpiration = TimeSpan.FromSeconds(5)
        });
        return true;
    }
    [HttpGet("get")]
    public async Task<object> Get()
    {
        var name = await _distrubutedCache.GetStringAsync("name");
        var surnameBinary = await _distrubutedCache.GetAsync("surname");
        var surname = Encoding.UTF8.GetString(surnameBinary);
        return $"{name} {surname}";
    }
}
