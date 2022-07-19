using Microsoft.Extensions.Configuration;
using PageUpProject.Business.Interfaces;
using PageUpProject.Business.Rules;
using PageUpProject.Models;
using PageUpProject.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PageUpProject.Business
{
    public class ParcelService : IParcelService
    {

        //private readonly IRuleFactory _heavyParcelRuleFactory;
        public IDataRepository<Rule> _ruleRepository;
        private readonly IConfiguration Configuration;

        public ParcelService(IDataRepository<Rule> ruleRepository, IConfiguration configuration)
        {
           
            _ruleRepository = ruleRepository;
            Configuration = configuration;
        }

        public ParcelService()
        {
        }

        public AddParcelResponse ComputeCost(Parcel parcel)
        {
            AddParcelResponse response = new AddParcelResponse();
            List<Rule> rules = _ruleRepository.GetAll().OrderBy( a => a.Order).ToList();

            double cost = 0;
            string key = "";
            bool isConditionSatistied = false;

            foreach (Rule rule in rules)
            {
                var ruleObjName = string.Concat(Configuration["RulesNameSpace"], ".", rule.Key, "ParcelRule");
                var ruleType = Type.GetType(ruleObjName);
                IRule<Parcel> ruleInstance = Activator.CreateInstance(ruleType) as IRule<Parcel>;
                isConditionSatistied = ruleInstance.Condition(parcel);
                if (isConditionSatistied)
                {
                    response.Cost = ruleInstance.Cost(parcel, rule.CostFactor);
                    response.Category = rule.Key;
                    break;
                }
            };

            return response;
        }
    }
}
