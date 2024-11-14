
using HeladeriaMondongo.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HeladeriaMondongo.Controllers.V1.Users;
[ApiController]
[Route("api/v1/[controller]")]
public class UserController (IUserRepository _userRepository) : ControllerBase
{

     protected readonly IUserRepository _userRepository = _userRepository;

}
