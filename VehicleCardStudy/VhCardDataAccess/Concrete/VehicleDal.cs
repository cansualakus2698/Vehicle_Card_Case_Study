using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VhCardDataAccess.Abstract;
using VhCardDataAccess.Concrete.RepositoryBase;
using VhCardEntity.Concrete;

namespace VhCardDataAccess.Concrete
{
    public class VehicleDal : RepositoryBase<Vehicle>, IVehicleDal
    {
        public VehicleDal(VhCardCaseContext context) : base(context)
        {

        }
    }
}
