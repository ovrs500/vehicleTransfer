using System;

namespace Entities.BaseEntities
{
    public abstract class Location : BaseVehicleTrans
    {
        public string Description { get; set; }
        public string Name { get; set; }
    }
}