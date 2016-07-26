using Entities.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.BaseEntities
{
    public abstract class Vehicle : BaseVehicleTrans
    {
        public VehicleStatusEnum VehicleStatus { get; set; }
        public Model Model { get; set; }
        public Make Make { get; set; }
        public int MakeId { get; set; }
        [StringLength(24, ErrorMessage = "The Vin must be 24 characters long")]
        public string Vin { get; set; }
        [RegularExpression(@"^\d{4}", ErrorMessage = "Year must be only four digits")]
        public string Year { get; set; }
        public virtual void Transfer(
            Location transferTo,
            Location transferFrom)
        {
            if (this.VehicleStatus != VehicleStatusEnum.StandBy)
            {
                throw new System.Exception("Vehicle MUST be in status of StandBy in order to be transfered");
            }
        }
    }
}