using Entities.BaseEntities;

namespace Entities.Entities
{
    public class Model : BaseVehicleTrans
    {
        public Make Make { get; set; }
        public string MakeId { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
    }
}