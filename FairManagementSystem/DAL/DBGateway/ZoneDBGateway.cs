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
    public class ZoneDbGateway
    {
        string connStr = ConfigurationManager.ConnectionStrings["ConnectionToFairManagementDB"].ToString();
        SqlConnection aSqlConnection;
        private SqlCommand aSqlCommand;
        public ZoneDbGateway()
        {
            aSqlConnection = new SqlConnection(connStr);
        }

        public void Save(Zone aZone)
        {

            
            string query = "INSERT INTO tbl_zone VALUES('" + aZone.ZoneName + "')";

            aSqlCommand = new SqlCommand(query, aSqlConnection);

            aSqlConnection.Open();

            int affectedRows = aSqlCommand.ExecuteNonQuery();
            
            aSqlConnection.Close();

            if (affectedRows > 0)
            {
                MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("An Error ocured");
            }


        }

        public List<Zone> GetZone()
        {

            string query = "SELECT * FROM tbl_zone";

            aSqlCommand = new SqlCommand(query, aSqlConnection);

            aSqlConnection.Open();

            SqlDataReader reader = aSqlCommand.ExecuteReader();

            List<Zone> zones = new List<Zone>();

            while (reader.Read())
            {
                Zone aZone = new Zone();
                aZone.ZoneId = int.Parse(reader["zoneId"].ToString());
                aZone.ZoneName = reader["zoneName"].ToString();
                zones.Add(aZone);
            }
            reader.Close();
            aSqlConnection.Close();

            return zones;
        }

       
    }
  }

