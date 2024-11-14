using Bogus;
using Microsoft.EntityFrameworkCore;
using HeladeriaMondongo.Models;

namespace HeladeriaMondongo.Seeders;

public class UserSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        var users = GenerateUsers(10); // Genera 10 usuarios no administradores
        var admin = GenerateAdmin(); // Genera el usuario administrador específico

        var allUsers = users.ToList(); // Convierte a lista para agregar el administrador
        allUsers.Add(admin);

        modelBuilder.Entity<User>().HasData(allUsers); // Añade todos los usuarios al seeder
    }

    private static IEnumerable<User> GenerateUsers(int count)
    {
        var faker = new Faker<User>()
            .RuleFor(u => u.Id, f => f.IndexFaker + 1) // ID autoincrementado
            .RuleFor(u => u.Name, f => f.Name.FirstName())
            .RuleFor(u => u.LastName, f => f.Name.LastName())
            .RuleFor(u => u.Email, f => f.Internet.Email())
            .RuleFor(u => u.Password, f => f.Internet.Password(8, true)) // Contraseña única y segura generada con Bogus
            .RuleFor(u => u.IsAdmin, f => false); // Usuarios regulares (no administradores)

        return faker.Generate(count);
    }

    private static User GenerateAdmin()
    {
        return new User
        {
            Id = 100, // Asigna un ID único que no se repita con los generados automáticamente
            Name = "Admin",
            LastName = "User",
            Email = "admin@example.com",
            Password = "AdminPassword123", // Encriptar en producción
            IsAdmin = true
        };
    }
}




