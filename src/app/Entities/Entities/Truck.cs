using Entities.BaseEntities;
using System;

namespace Entities.Entities
{
    public class Truck : Vehicle
    {
        public override void Transfer(
            Location transferTo,
            Location transferFrom)
        {
            base.Transfer(transferTo, transferFrom);

            if (transferTo is Branch == false)
            {
                throw new Exception("Destination location MUST be a branch");
            }

            if (transferFrom is Branch == false)
            {
                throw new Exception("Origin location MUST be a branch");
            }

            var toLocation = (Branch)transferTo;
            var fromLocation = (Branch)transferFrom;

            toLocation.Vehicles.Add(this);
            fromLocation.Vehicles.Remove(this);
        }
    }
}