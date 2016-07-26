using System;

namespace Entities.BaseEntities
{
    public abstract class BaseVehicleTrans
    {        
        protected int Id { get; set; }
        protected DateTime DateModified { get; set; }
        protected DateTime DateCreated { get; set; }
    }
}