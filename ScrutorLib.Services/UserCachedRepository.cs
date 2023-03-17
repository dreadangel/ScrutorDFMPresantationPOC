using ScrutorLib.Services.Domain;
using Utils;

namespace ScrutorLib.Services;

[AppEnvironment(Utils.Environment.DEVELOPMENT)]
public class UserCachedRepository : IRepository<User>
{

    public async Task<User> AddData(User entity)
    {
        await Task.Delay(1);
        return new User(Guid.NewGuid(), "cashed dev", 0);
    }

    public async Task<User> UpdateData(User entity)
    {
        await Task.Delay(1);
        return new User(Guid.NewGuid(), "cashed dev", 0);
    }

    public async Task<User> GetDataById(Guid guid)
    {
        await Task.Delay(1);
        return new User(Guid.NewGuid(), "cashed dev", 0);
    }

    public async Task<IEnumerable<User>> GetData()
    {
        await Task.Delay(1);
        return new List<User> {new User(Guid.NewGuid(), "cashed dev", 0)};
    }
}