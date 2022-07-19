using PageUpProject.Business.Interfaces;
using PageUpProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageUpProject.Business.Rules
{
    public class MediumParcelRule : BaseRule, IRule<Parcel>
    {
        //public override double CostFactor { get; set; } = 0.04;
        public override int WeightFactor { get; set; } = 2500;
        //public int Order()
        //{
        //    return 4;
        //}

        public double Cost(Parcel parcel, double costFactor)
        {
            return costFactor * (parcel.Height * parcel.Width * parcel.Depth);
        }

        public bool Condition(Parcel parcel)
        {
            return (parcel.Height * parcel.Width * parcel.Depth) < WeightFactor ;
        }


    }
}
