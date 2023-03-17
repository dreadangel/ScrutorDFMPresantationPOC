using ScrutorLib.Services.Domain;

namespace ScrutorLib.Services;

public class OrderRepository : IRepository<Order>
{
    public async Task<Order> AddData(Order entity)
    {
        await Task.Delay(1);
        return new Order(Guid.NewGuid(), Guid.NewGuid(), 0, string.Empty);
    }

    public async Task<Order> UpdateData(Order entity)
    {
        await Task.Delay(1);
        return new Order(Guid.NewGuid(), Guid.NewGuid(), 0, string.Empty);
    }

    public async Task<Order> GetDataById(Guid guid)
    {
        await Task.Delay(1);
        return new Order(Guid.NewGuid(), Guid.NewGuid(), 0, string.Empty);
    }

    public async Task<IEnumerable<Order>> GetData()
    {
        await Task.Delay(1);
        return new List<Order> {new Order(Guid.NewGuid(), Guid.NewGuid(), 0, string.Empty)};
    }
}