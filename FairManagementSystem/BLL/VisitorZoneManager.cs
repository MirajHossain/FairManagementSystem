using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FairManagementSystem.DAL.DAO;
using FairManagementSystem.DAL.DBGateway;

namespace FairManagementSystem.BLL
{
     public class VisitorZoneManager
    {
         VisitorZoneDbGateway aVisitorZoneDbGateway = new VisitorZoneDbGateway();
         public void Save(VisitorZone aVisitorZone)
         {
             aVisitorZoneDbGateway.Save(aVisitorZone);
             
         }


         public int SearchVisitorUnderZone(int zoneId)
         {
             return VisitorZoneDbGateway.SearchVisitorUnderZoneById(zoneId);
         }

         public List<VisitorZone> SearchByZoneId(int zoneId)
         {
             return aVisitorZoneDbGateway.SearchByZoneId(zoneId);
         }
    }
}