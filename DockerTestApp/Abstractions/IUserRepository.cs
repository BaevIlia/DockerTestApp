using DockerTestApp.Database.Models;

namespace DockerTestApp.Abstractions
{
    public interface IUserRepository
    {
        public Task<List<User>> GetAll();
    }
}
