using PageUpProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageUpProject.Data
{
    public static class DbInitializer
    {

        //private readonly AppDbContext _dbContext;
        public static void Seed(AppDbContext dbContext)
        {

            if (!dbContext.Rules.Any())
            {
                dbContext.AddRange(
                    new Rule
                    {
                        Key = "Heavy",
                        Order = 2,
                        CostFactor = 15
                    },
                    new Rule
                    {
                        Key = "Large",
                        Order = 5,
                        CostFactor = 0.03
                    },
                    new Rule
                    {
                        Key = "Medium",
                        Order = 4,
                        CostFactor = 0.04
                    },
                    new Rule
                    {
                        Key = "Reject",
                        Order = 1,
                        CostFactor = 0
                    },
                    new Rule
                    {
                        Key = "Small",
                        Order = 3,
                        CostFactor = 0.05
                    }
                );
            }


            dbContext.SaveChanges();
        }

       
    
    }  
}
