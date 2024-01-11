using AdatbazisAPI.Models.Dtos;

namespace AdatbazisAPI.Repositories
{
    public interface ISzerzoInterface
    {
        Task<IEnumerable<Szerzo>> Get();
        Task<Szerzo?> GetById(Guid Id);
        Task<Szerzo> Post(CreateSzerzo CreateSzerzo);
        Task<Szerzo> Put(Guid Id, UpdateSzerzo updateSzerzo);
        Task<Szerzo> DeleteById(Guid Id);

    }
}
