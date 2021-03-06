using LancheMVC_Data.Contexto;
using LancheMVC_Domain;
using LancheMVC_Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LancheMVC_Data.Repository
{
    public class Repository<t> : IRepository<t> where t : Entity
    {
        protected readonly AppDbContext _Ctx;

        public Repository(AppDbContext ctx)
        {
            _Ctx = ctx;
        }
        public async Task<IEnumerable<t>> ReTornaTodos()
        {
            return await _Ctx.Set<t>().ToListAsync();
        }
        public async Task<t> PegaPorId(int? id)
        {
            return await _Ctx.Set<t>().FindAsync(id);


        }

       
    }
}
