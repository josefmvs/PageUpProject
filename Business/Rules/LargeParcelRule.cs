using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PageUpProject.Business.Interfaces;
using PageUpProject.Models;


namespace PageUpProject.Business.Rules
{
    public class LargeParcelRule : BaseRule, IRule<Parcel>
    {
        //public override double CostFactor { get; set; } = 0.03;
        public override int WeightFactor { get; set; } = 2500;
        //public int Order()
        //{
        //    return 5;
        //}

        public double Cost(Parcel parcel, double costFactor)
        {
            return costFactor * (parcel.Height * parcel.Width * parcel.Depth);
        }

        public bool Condition(Parcel parcel)
        {
            return true;
        }



    }
}
