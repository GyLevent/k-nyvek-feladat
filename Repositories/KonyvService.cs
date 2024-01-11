using AdatbazisAPI.Models;
using AdatbazisAPI.Models.Dtos;
using Microsoft.EntityFrameworkCore;

namespace AdatbazisAPI.Repositories
{
    public class KonyvService : IKonyvekInterface

    {
        private readonly KonyvekDbContext dbContext;
        public KonyvService(KonyvekDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Konyv?> DeleteById(Guid Id)
        {
            var konyv = await dbContext!.konyvek.Where(y => y.Id == Id).FirstOrDefaultAsync();
            dbContext.konyvek.Remove(konyv);
            await dbContext.SaveChangesAsync();
            return konyv;
        }

        public async Task<IEnumerable<Konyv?>> Get()
        {
            return await dbContext!.konyvek.ToListAsync();
        }

        public Task<Konyv?> GetById(Guid Id)
        {
            return dbContext!.konyvek.FirstOrDefaultAsync(p => p.Id == Id);
        }

        public async Task<Konyv?> Post(CreateKonyv createkonyv)
        {
            var konyv = new Konyv
            {
                Id = Guid.NewGuid(),
                Cím = createkonyv.Cím,
                Mufaj = createkonyv.Mufaj,
                kiadaseve = createkonyv.Kiadaseve,
            };
            await dbContext.konyvek.AddAsync(konyv);
            await dbContext.SaveChangesAsync();
            return konyv;
        }

        public async Task<Konyv> Put(Guid Id, UpdateKonyv updateKonyv)
        {
            var konyv = await dbContext!.konyvek.Where(y => y.Id == Id).FirstOrDefaultAsync();
            dbContext.Entry(konyv).CurrentValues.SetValues(updateKonyv);
            await dbContext.SaveChangesAsync();
            return konyv;
        }
    }
}
