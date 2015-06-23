using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FairManagementSystem.DAL.DAO;
using FairManagementSystem.DAL.DBGateway;

namespace FairManagementSystem.BLL
{
    public class ZoneManager
    {
        ZoneDbGateway aZoneDbGateway = new ZoneDbGateway();
        public void Save(Zone aZone)
        {
           
            aZoneDbGateway.Save(aZone);
        }
        public List<Zone> GetZone()
        {
            return aZoneDbGateway.GetZone();
        }



       
    }
}
