
using HeladeriaMondongo.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HeladeriaMondongo.Controllers.V1.Users;
[ApiController]
[Route("api/v1/users")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("users")]
public class UserDeleteController(IUserRepository _userRepository) : UserController(_userRepository)
{
    [HttpDelete("{id}")]

    public async Task<IActionResult> Delete(int id)
    {
        var category = await _userRepository.CheckExistence(id);

        if (category == false)
        {
            return NotFound();
        }

        await _userRepository.Delete(id);

        return NotFound();
    }
}