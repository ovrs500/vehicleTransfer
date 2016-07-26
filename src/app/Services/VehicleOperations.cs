using System;
using Entities.BaseEntities;
using LogicInfrastructure.EntitySupport;
using Entities.FrameworkObjects;
using System.Collections.Generic;

namespace Services
{
    public class VehicleOperations : IVehicleOperations
    {
        public ReturnObject<Vehicle> TransferVehicle(
            Vehicle vehicleToTransfer,
            Location locationToTransferTo,
            Location locationToTransferFrom)
        {
            var retVal = new ReturnObject<Vehicle> { Messages = new List<OperationMessage>(), Results = new List<Vehicle>() };

            try
            {
                vehicleToTransfer.Transfer(locationToTransferTo, locationToTransferFrom);
                retVal.Results.Add(vehicleToTransfer);
                retVal.Messages.Add(new OperationMessage
                {
                    MessageLevel = OperationMessageLevelEnum.Success,
                    MessageText = "Vehicle was transfered successfully"
                });

                return retVal;
            }
            catch (Exception ex)
            {
                retVal.Messages.Add(new OperationMessage
                {
                    MessageLevel = OperationMessageLevelEnum.Error,
                    MessageText = "Error(s) were encountered while transfering the vehicle: " + ex.ToString()
                });

                return retVal;
            }
        }
    }
}