
using HeladeriaMondongo.Data;
using HeladeriaMondongo.DTOs;
using Microsoft.EntityFrameworkCore;
using HeladeriaMondongo.Models;
using HeladeriaMondongo.Repositories;

namespace HeladeriaMondongo.Services;
public class UserServices : IUserRepository
{
    private readonly ApplicationDbContext _context;

    public UserServices(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<User> Create(UserDTO UserDTO)
    {
        var User = new User(UserDTO.Name, UserDTO.LastName ,UserDTO.Email, UserDTO.Password, UserDTO.IsAdmin);
        _context.Users.Add(User);
        await _context.SaveChangesAsync();
        return User;
    }

    public async Task Delete(int id)
    {
        var User = await GetById(id);
        if (User != null)
        {
            _context.Users.Remove(User);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<User>> GetAll()
    {
        return await _context.Users.ToListAsync();
    }

    public async Task<User?> GetById(int id)
    {
        return await _context.Users.FindAsync(id);
    }

    public async Task<IEnumerable<User>> GetByKeyword(string keyword)
    {
        if (string.IsNullOrWhiteSpace(keyword))
        {
            return await GetAll();
        }

        return await _context.Users
    .Where(pc => pc.Name.Contains(keyword) || pc.Email.Contains(keyword))
    .ToListAsync();

    }

    public async Task Update(int id, UserDTO UserDTO)
    {
        var User = await GetById(id);
        if (User == null) return;

        User.Name = UserDTO.Name.ToLower().Trim();
        User.LastName = UserDTO.LastName.ToLower().Trim();
        User.Email = UserDTO.Email.ToLower().Trim();
        User.Password = UserDTO.Password;
        await _context.SaveChangesAsync();
    }
    public async Task<bool> CheckExistence(int id)
    {
        try
        {
            return await _context.Users.AnyAsync(u => u.Id == id);
        }
        catch (Exception exi)
        {
            throw new Exception("ocurrio un error a la hora de busacar la categoria", exi);
        }
    }
}