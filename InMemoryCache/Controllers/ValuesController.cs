using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace InMemoryCache.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        IMemoryCache _memoryCache;

        public ValuesController(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        [HttpGet("set/{name}")]
        public void Set(string name)
        {
            _memoryCache.Set("name", name);
            
        }
        [HttpGet]
        public string Get()
        {
            if(_memoryCache.TryGetValue<string>("name", out string name))
            {
                return name;
            }
            return string.Empty;
        }

        [HttpGet("setdate")]
        public void SetDate()
        {
            _memoryCache.Set("date", DateTime.Now, options: new()
            {
                AbsoluteExpiration = DateTime.Now.AddSeconds(30), // Mutlak ömrü
                SlidingExpiration = TimeSpan.FromSeconds(5)
            });
        }
        [HttpGet("getdate")]
        public DateTime GetDate()
        {
             return _memoryCache.Get<DateTime>("date");
        }
    }
}
