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
   public class VisitorDbGateway
    {
       string connStr = ConfigurationManager.ConnectionStrings["ConnectionToFairManagementDB"].ToString();
       SqlConnection aSqlConnection;
       private SqlCommand aSqlCommand;
       public VisitorDbGateway()
       {
           aSqlConnection = new SqlConnection(connStr);
       }

       public int Save(Visitor aVisitor)
       {
          
           string query = "INSERT INTO tbl_visitor VALUES('" + aVisitor.Name + "','" + aVisitor.Email + "','" + aVisitor.ContactNumber + "')";

           aSqlCommand = new SqlCommand(query, aSqlConnection);

           aSqlConnection.Open();

           int affectedRows = aSqlCommand.ExecuteNonQuery();

           aSqlConnection.Close();

           return affectedRows;
       }

       public List<Visitor> GetAllVisitor(Visitor aVisitor)
       {

           string query = "SELECT * FROM tbl_visitor";

           aSqlCommand = new SqlCommand(query, aSqlConnection);

           aSqlConnection.Open();

           SqlDataReader reader = aSqlCommand.ExecuteReader();

           List<Visitor> visitors = new List<Visitor>();

           while (reader.Read())
           {
               aVisitor = new Visitor();
               aVisitor.VisitorId = int.Parse(reader["visitorId"].ToString());
               aVisitor.Name = reader["name"].ToString();
               aVisitor.Email = reader["email"].ToString();
               aVisitor.ContactNumber = reader["number"].ToString();
               visitors.Add(aVisitor);

               
           }
           reader.Close();
           aSqlConnection.Close();
           return visitors;
       }

       public List<Visitor> GetAllVisitor(int zoneId)
       {
           string query = "SELECT * FROM VisitZone WHERE zoneId = '" + zoneId + "'";

           aSqlCommand = new SqlCommand(query, aSqlConnection);

           aSqlConnection.Open();

           SqlDataReader reader = aSqlCommand.ExecuteReader();

           List<Visitor> visitors = new List<Visitor>();

           while (reader.Read())
           {
               Visitor aVisitor = new Visitor();
               aVisitor.VisitorId = int.Parse(reader["visitorId"].ToString());
               aVisitor.Name = reader["VisitorName"].ToString();
               aVisitor.Email = reader["VisitorEmail"].ToString();
               aVisitor.ContactNumber = reader["VisitorContactNumber"].ToString();
               visitors.Add(aVisitor);


           }
           reader.Close();
           aSqlConnection.Close();
           return visitors;
       }
    }
}
