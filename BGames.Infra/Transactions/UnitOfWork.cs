using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGames.Infra.Transactions
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BGamesContext _context;

        public UnitOfWork(BGamesContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
