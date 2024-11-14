
using HeladeriaMondongo.DTOs;
using HeladeriaMondongo.Models;

namespace HeladeriaMondongo.Repositories;

public interface IUserRepository
{

     Task<IEnumerable<User>> GetAll();
    Task<User?> GetById(int id);
    Task<IEnumerable<User>> GetByKeyword(string keyword);
    Task<User> Create(UserDTO UserDTO);
    Task Update(int id, UserDTO UserDTO);
    Task Delete(int id);
    Task<bool> CheckExistence(int id);

}
