namespace ScrutorLib.Services;

public interface IRepository<TPoco>
{
    Task<TPoco> AddData(TPoco entity);
    Task<TPoco> UpdateData(TPoco entity);
    Task<TPoco> GetDataById(Guid guid);
    Task<IEnumerable<TPoco>> GetData();
}