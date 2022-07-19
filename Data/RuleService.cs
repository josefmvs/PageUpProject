using PageUpProject.Business.Interfaces;
using PageUpProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageUpProject.Data
{
    public class RuleService : IDataRepository<Rule>
    {
        private readonly AppDbContext _dbContext;
        public RuleService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Rule> GetAll()
        {
            return _dbContext.Rules.ToList();
        }

    }
}
