using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly AppDbContext _appDbContext;
        public PieRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Pie> GetAllPies()
        {
            return _appDbContext.Pies.Include(c => c.Category);
        }

        public Pie GetPieById(int pieId)
        {
            return _appDbContext.Pies.FirstOrDefault(p => p.PieId == pieId);
        }

        public IEnumerable<Pie> GetPiesOfTheWeek()
        {
            return _appDbContext.Pies.Include(c => c.Category).Where(p => p.IsPieOfTheWeek);
        }
    }
}
