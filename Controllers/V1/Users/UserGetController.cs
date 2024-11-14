
using HeladeriaMondongo.Repositories;
using HeladeriaMondongo.Models;
using Microsoft.AspNetCore.Mvc;

namespace HeladeriaMondongo.Controllers.V1.Users;
[ApiController]
[Route("api/v1/users")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("users")]

public class UserGetController(IUserRepository _userRepository) : UserController(_userRepository)
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<User>>> GetAll()

    {
        var user = await _userRepository.GetAll();

        return Ok(user);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<User>> GetById(int id)
    {
        var user = await _userRepository.GetById(id);

        if (user == null)
        {
            return NotFound();
        }
        return Ok(user);
    }

    [HttpGet("search/{keyword}")]
    public async Task<ActionResult<IEnumerable<User>>> SearchByKeyword(string keyword)
    {
        if (string.IsNullOrWhiteSpace(keyword))
        {
            return BadRequest("La palabra clave no puede estar vacia");
        }

        var user = await _userRepository.GetByKeyword(keyword);

        if (!user.Any())
        {
            return NotFound("no se encontraron Categorias con concidencias");
        }

        return Ok(user);
    }
}
