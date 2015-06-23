using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FairManagementSystem.DAL.DAO;

namespace FairManagementSystem.DAL.DBGateway
{
    public class VisitorZoneDbGateway
    {

        private static string connStr = ConfigurationManager.ConnectionStrings["ConnectionToFairManagementDB"].ToString();
        private static SqlConnection aSqlConnection;
        private static SqlCommand aSqlCommand;
        public VisitorZoneDbGateway()
        {
            aSqlConnection = new SqlConnection(connStr);
        }
        public void Save(VisitorZone aVisitorZone)
        {

            string query = "INSERT INTO tbl_VisitorZone VALUES('" + aVisitorZone.ZoneId + "','" + aVisitorZone.VistorId +
                           "')";
            aSqlCommand = new SqlCommand(query, aSqlConnection);

        }

        public static int SearchVisitorUnderZoneById(int zoneId)
        {

            string query = "SELECT COUNT(visitorId) AS NoOfVisitor FROM VisitZone WHERE zoneId = '" + zoneId + "'";

            aSqlCommand = new SqlCommand(query, aSqlConnection);

            aSqlConnection.Open();

            Int32 count = (Int32)aSqlCommand.ExecuteScalar();
           
            aSqlConnection.Close();
            
            return count;

        }


        public List<VisitorZone> SearchByZoneId(int zoneId)
        {
            string query = "SELECT *FROM VisitZone WHERE zoneId = '" + zoneId + "'";

            aSqlCommand = new SqlCommand(query, aSqlConnection);

            aSqlConnection.Open();

            SqlDataReader aSqlDataReader = aSqlCommand.ExecuteReader();
            List<VisitorZone> visitorZones = new List<VisitorZone>();
            while (aSqlDataReader.Read())
            {
                VisitorZone aVisitorZone = new VisitorZone();
                aVisitorZone.Name = aSqlDataReader["VisitorName"].ToString();
                aVisitorZone.Email = aSqlDataReader["VisitorEmail"].ToString();
                aVisitorZone.ContactNumber = aSqlDataReader["VisitorContactNumber"].ToString();
                visitorZones.Add(aVisitorZone);
            }
            aSqlDataReader.Close();
            aSqlConnection.Close();
            return visitorZones;
        }
    }
}