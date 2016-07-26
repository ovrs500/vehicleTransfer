using Entities.BaseEntities;
using System.Collections.Generic;

namespace Entities.Entities
{
    public class DistributionCenter : Location
    {
        public DistributionCenter() {
            Vehicles = new List<Vehicle>();
            Branches = new List<Branch>();
        }

        public IList<Vehicle> Vehicles { get; set; }
        public IList<Branch> Branches { get; set; }
    }
}