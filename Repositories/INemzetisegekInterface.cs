using AdatbazisAPI.Models.Dtos;

namespace AdatbazisAPI.Repositories
{
    public interface INemzetisegekInterface
    {
        Task<IEnumerable<Nemzetiseg>> Get();
        Task<Nemzetiseg?> GetById(Guid Id);
        Task<Nemzetiseg> Post(CreateNemzetiseg CreateNemzetiseg);
        Task<Nemzetiseg> Put(Guid Id, UpdateNemzetiseg updateNemzetiseg);
        Task<Nemzetiseg> DeleteById(Guid Id);
    }
}
