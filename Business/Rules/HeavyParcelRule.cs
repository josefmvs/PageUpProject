using PageUpProject.Business.Interfaces;
using PageUpProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageUpProject.Business.Rules
{
    public class HeavyParcelRule : BaseRule, IRule<Parcel>

    {
        //public override double CostFactor { get; set; } = 15;
        public override int WeightFactor { get; set; } = 10;
        //public int Order()
        //{
        //    return 2;
        //}

        public double Cost(Parcel parcel, double costFactor)
        {
            return costFactor * parcel.Weight;
        }

        public bool Condition(Parcel parcel)
        {
            return parcel.Weight > WeightFactor ;
        }


    }

}
