using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FairManagementSystem.DAL.DAO;
using FairManagementSystem.DAL.DBGateway;

namespace FairManagementSystem.BLL
{
    public class VisitorManager
    {
        VisitorDbGateway aVisitorDbGateway = new VisitorDbGateway();
        public int Save(Visitor aVisitor)
        {
           return aVisitorDbGateway.Save(aVisitor);
        }

        public List<Visitor> GetAllVisitor(Visitor aVisitor)
        {
           return aVisitorDbGateway.GetAllVisitor(aVisitor);
        }

        public List<Visitor> GetAllVisitor(int zoneId)
        {
            return aVisitorDbGateway.GetAllVisitor(zoneId);
        }
    }
}
