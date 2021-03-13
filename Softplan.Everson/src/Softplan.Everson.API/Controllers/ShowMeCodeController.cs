using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Softplan.Everson.API.Controllers
{
    [Route("projeto")]
    public sealed class ShowMeCodeController : ControllerBase
    {
        private readonly IConfiguration configuration;

        public ShowMeCodeController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        [HttpGet]
        [Route("showmethecode")]
        public string ShowMeTheCode()
        {
            var value = configuration.GetSection("GitUrlProject").Value;
            return value;
        }
    }
}
