using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VhCardBusiness.Abstract;
using VhCardEntity.Concrete;

namespace VhCardBusiness.Concrete
{
    public class VehiclesTypeManager : BaseManager<VehiclesType>, IVehiclesTypeService
    {
        public VehiclesTypeManager(VhCardCaseContext context) : base(context)
        {

        }
    }
}
