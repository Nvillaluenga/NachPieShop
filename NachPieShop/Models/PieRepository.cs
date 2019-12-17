using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NachPieShop.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly PieDbContext _pieDbContext;
        public PieRepository(PieDbContext pieDbContext)
        {
            _pieDbContext = pieDbContext;
        }
        public IEnumerable<Pie> AllPies 
        { 
            get
            {
                return _pieDbContext.Pies.Include(pie => pie.Category);
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek 
        {
            get
            {
                return _pieDbContext.Pies.Where(pie => pie.IsPieOfTheWeek).Include(pie => pie.Category);
            }    
        }

        public Pie GetPieById(int pieId)
        {
            return _pieDbContext.Pies.Find(pieId);
        }
    }
}
