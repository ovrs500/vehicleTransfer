using Entities.BaseEntities;
using System.Collections.Generic;

namespace Entities.Entities
{
    public class Branch : Location
    {
        public Branch()
        {
            Vehicles = new List<Vehicle>();
        }

        public IList<Vehicle> Vehicles { get; set; }
    }
}