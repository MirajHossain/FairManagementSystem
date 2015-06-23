using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairManagementSystem.DAL.DAO
{
  public class VisitorZone
    {
      public int VisitorZoneId { get; set; } 
        public int VistorId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public int ZoneId { get; set; }
        public string ZoneName { get; set; }
    }
}
