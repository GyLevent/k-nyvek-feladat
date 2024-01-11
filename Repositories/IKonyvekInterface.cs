using AdatbazisAPI.Models.Dtos;

namespace AdatbazisAPI.Repositories
{
    public interface IKonyvekInterface
    {
        Task<IEnumerable<Konyv>> Get();
        Task<Konyv?> GetById(Guid Id);
        Task<Konyv> Post(CreateKonyv CreateKonyv);
        Task<Konyv> Put(Guid Id, UpdateKonyv UpdateKonyv);
        Task<Konyv> DeleteById(Guid Id);
    }
}
