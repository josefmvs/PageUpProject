using PageUpProject.Business.Interfaces;
using PageUpProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageUpProject.Business.Rules
{
    public class RejectParcelRule : BaseRule, IRule<Parcel>
    {
        //public override double CostFactor { get; set; } = 0;
        public override int WeightFactor { get; set; } = 50;
        //public int Order()
        //{
        //    return 1;
        //}

        public double Cost(Parcel parcel, double costFactor)
        {
            return 0;
        }

        public bool Condition(Parcel parcel)
        {
            return parcel.Weight > WeightFactor;
        }


    }

}
