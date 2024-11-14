
using HeladeriaMondongo.DTOs;
using HeladeriaMondongo.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HeladeriaMondongo.Controllers.V1.Users;
[ApiController]
[Route("api/v1/users")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("users")]
public class UserPutController(IUserRepository _userRepository) : UserController(_userRepository)
{

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateCustomer(int id, UserDTO updateUser)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var user = await _userRepository.GetById(id);
        if (user == null)
            return NotFound();

        await _userRepository.Update(id, updateUser);

        // Obtiene los datos actualizados después de guardar
        var updatedUser = await _userRepository.GetById(id);
        return Ok(updatedUser);
    }


}
