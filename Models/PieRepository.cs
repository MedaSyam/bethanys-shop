using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanyPieShop_2.Models
{
    public class PieRepository : IPieRepository
    {
        private AppDbContext _appDbContext;

        public PieRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Pie> AllPies
            {
            get {
                return _appDbContext.pies.Include(c => c.Category);         
                 }
            }
        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return _appDbContext.pies.Include(c => c.Category).Where(p => p.IsPieOfTheWeek);
            }
        }

        public Pie GetPieById(int pieId)
        {
            return _appDbContext.pies.FirstOrDefault(p => p.PieId == pieId);
        }
    }
}
