using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VhCardDataAccess.Abstract.Repositories;
using VhCardEntity.Concrete;

namespace VhCardDataAccess.Abstract
{
    public interface IVehiclesTypeDal : IRepositoryBase<VehiclesType>
    {
    }
}
