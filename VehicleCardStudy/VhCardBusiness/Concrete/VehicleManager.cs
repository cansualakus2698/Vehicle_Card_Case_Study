using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VhCardBusiness.Abstract;
using VhCardEntity.Concrete;

namespace VhCardBusiness.Concrete
{
    public class VehicleManager : BaseManager<Vehicle>, IVehicleService
    {
        public VehicleManager(VhCardCaseContext context) : base(context)
        {

        }
    }
}
