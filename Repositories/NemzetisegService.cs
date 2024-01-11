using AdatbazisAPI.Models;
using AdatbazisAPI.Models.Dtos;
using Microsoft.EntityFrameworkCore;

namespace AdatbazisAPI.Repositories
{
    public class NemzetisegService : INemzetisegekInterface

    {
        private readonly KonyvekDbContext dbContext;
        public NemzetisegService(KonyvekDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Nemzetiseg?> DeleteById(Guid Id)
        {
            var nemz = await dbContext!.nemzetiseg.Where(y => y.Id == Id).FirstOrDefaultAsync();
            dbContext.nemzetiseg.Remove(nemz);
            await dbContext.SaveChangesAsync();
            return nemz;
        }

        public async Task<IEnumerable<Nemzetiseg?>> Get()
        {
            return await dbContext!.nemzetiseg.ToListAsync();
        }

        public Task<Nemzetiseg?> GetById(Guid Id)
        {
            return dbContext!.nemzetiseg.FirstOrDefaultAsync(p => p.Id == Id);
        }

        public async Task<Nemzetiseg?> Post(CreateNemzetiseg createNemz)
        {
            var nemz = new Nemzetiseg
            {
                Id = Guid.NewGuid(),
                SzerzoNemzetisege = createNemz.SzerzoNemzetisege,
            };
            await dbContext.nemzetiseg.AddAsync(nemz);
            await dbContext.SaveChangesAsync();
            return nemz;
        }

        public async Task<Nemzetiseg> Put(Guid Id, UpdateNemzetiseg updatenemz)
        {
            var nemz = await dbContext!.nemzetiseg.Where(y => y.Id == Id).FirstOrDefaultAsync();
            dbContext.Entry(nemz).CurrentValues.SetValues(updatenemz);
            await dbContext.SaveChangesAsync();
            return nemz;
        }
    }
}

