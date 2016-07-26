using Entities.BaseEntities;
using Entities.FrameworkObjects;
using System.Collections.Generic;

namespace LogicInfrastructure.EntitySupport
{
    public class ReturnObject<TEntity>
        where TEntity : BaseVehicleTrans
    {
        public int TotalResutlsCount { get; set; }
        public IList<TEntity> Results { get; set; }
        public IList<OperationMessage> Messages { get; set; }
    }
}