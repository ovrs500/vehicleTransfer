using System;
using Entities.BaseEntities;

namespace Entities.Entities
{
    public class Semi : Vehicle
    {
        public override void Transfer(
            Location transferTo,
            Location transferFrom)
        {
            base.Transfer(transferTo, transferFrom);

            if (transferTo is DistributionCenter == false)
            {
                throw new Exception("Destination location MUST be a distribution center");
            }

            if (transferFrom is DistributionCenter == false)
            {
                throw new Exception("Origin location MUST be a distribution center");
            }

            var toLocation = (DistributionCenter)transferTo;
            var fromLocation = (DistributionCenter)transferFrom;

            toLocation.Vehicles.Add(this);
            fromLocation.Vehicles.Remove(this);
        }
    }
}