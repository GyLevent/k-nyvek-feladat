using AdatbazisAPI.Models;
using AdatbazisAPI.Models.Dtos;
using Microsoft.EntityFrameworkCore;

namespace AdatbazisAPI.Repositories
{
    public class SzerzoService : ISzerzoInterface

    {
        private readonly KonyvekDbContext dbContext;
        public SzerzoService(KonyvekDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Szerzo?> DeleteById(Guid Id)
        {
            var szerzo = await dbContext!.szerzok.Where(y => y.Id == Id).FirstOrDefaultAsync();
            dbContext.szerzok.Remove(szerzo);
            await dbContext.SaveChangesAsync();
            return szerzo;
        }

        public async Task<IEnumerable<Szerzo?>> Get()
        {
            return await dbContext!.szerzok.ToListAsync();
        }

        public Task<Szerzo?> GetById(Guid Id)
        {
            return dbContext!.szerzok.FirstOrDefaultAsync(p => p.Id == Id);
        }

        public async Task<Szerzo?> Post(CreateSzerzo createSzerzo)
        {
            var szer = new Szerzo
            {
                Id = Guid.NewGuid(),
                Nev = createSzerzo.Nev,
                Nem = createSzerzo.Nem,
            };
            await dbContext.szerzok.AddAsync(szer);
            await dbContext.SaveChangesAsync();
            return szer;
        }

        public async Task<Szerzo> Put(Guid Id, UpdateSzerzo updateSzerzo)
        {
            var szer = await dbContext!.szerzok.Where(y => y.Id == Id).FirstOrDefaultAsync();
            dbContext.Entry(szer).CurrentValues.SetValues(updateSzerzo);
            await dbContext.SaveChangesAsync();
            return szer;
        }
    }
}
