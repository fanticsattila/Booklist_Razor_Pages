using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booklist_Razor_Pages.Model
{
    public interface IDbInitializer
    {
        void Initialize();
    }
    public class DbInitializer : IDbInitializer
    {
        private ApplicationDbContext _context;

        public DbInitializer(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Initialize()
        {
            if (_context.Database.GetPendingMigrations().Count() > 0)
                _context.Database.Migrate();
        }
    }
}
