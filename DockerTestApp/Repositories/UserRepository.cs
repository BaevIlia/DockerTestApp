using DockerTestApp.Abstractions;
using DockerTestApp.Database;
using DockerTestApp.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace DockerTestApp.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly PostgreSQLContext _dbContext;
        public UserRepository(PostgreSQLContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<User>> GetAll() 
        {
            return await _dbContext.Users.ToListAsync();
        }
    }
}
