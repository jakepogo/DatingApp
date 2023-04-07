using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]// api/users will use the UsersController
    public class BaseApiController : ControllerBase
    {
        
    }
}