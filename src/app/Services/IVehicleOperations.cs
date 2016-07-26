using Entities.BaseEntities;
using LogicInfrastructure.EntitySupport;

namespace Services
{
    public interface IVehicleOperations
    {
        /// <summary>
        /// opeatr
        /// </summary>
        /// <param name="vehicleToTransfer"></param>
        /// <param name="locationToTransferTo"></param>
        /// <param name="locationToTransferFrom"></param>
        /// <returns></returns>
        ReturnObject<Vehicle> TransferVehicle(
            Vehicle vehicleToTransfer,
            Location locationToTransferTo,
            Location locationToTransferFrom);
    }
}