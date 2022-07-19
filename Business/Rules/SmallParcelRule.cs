using PageUpProject.Business.Interfaces;
using PageUpProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageUpProject.Business.Rules
{
    public class SmallParcelRule : BaseRule, IRule<Parcel>
    {
        //public override double CostFactor { get; set; } = 0.05;
        public override int WeightFactor { get; set; } = 1500;
        //public int Order()
        //{
        //    return 3;
        //}

        public double Cost(Parcel parcel, double costFactor)
        {
            return costFactor * (parcel.Height * parcel.Width * parcel.Depth);
        }

        public bool Condition(Parcel parcel)
        {
            return (parcel.Height * parcel.Width * parcel.Depth) < WeightFactor;
        }


    }
}
