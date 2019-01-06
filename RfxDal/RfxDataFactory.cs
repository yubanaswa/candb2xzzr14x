using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RfxDal.DTO;

namespace RfxDal
{

    public static class RfxDataFactory
    { 
        public static List<Trips> GetAllTrips()
        {
            var trips = new List<Trips>();
            using (var context = new candb_webEntities())
            {
                trips = context.Trips.Select(p => p).ToList();
            }

            return trips;
        }
    }
}
