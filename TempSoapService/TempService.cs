using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;

namespace TempSoapService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TempService" in both code and config file together.
    public class TempService : ITempService
    {

        private string connectionString =
            @"Server=tcp:easytempdb.database.windows.net,1433;Initial Catalog=easytempdb;Persist Security Info=False;User ID=easytemp;Password=Temp1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public bool PostData(Temperatur temperatur)
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();
                string postSql =
                    "Insert into Temperatur(DatoTid, Sted, Inde, Ude, Temp, Kommentar) values (@DatoTid, @Sted, @Inde, @Ude, @Temp, @Kommentar)";

                SqlCommand cmd = new SqlCommand(postSql, connect);
                cmd.Parameters.AddWithValue("@DatoTid", temperatur.DatoTid);
                cmd.Parameters.AddWithValue("@Sted", temperatur.Sted);
                cmd.Parameters.AddWithValue("@Inde", temperatur.Inde);
                cmd.Parameters.AddWithValue("@Ude", temperatur.Ude);
                cmd.Parameters.AddWithValue("@Temp", temperatur.Temp);
                cmd.Parameters.AddWithValue("@Kommentar", temperatur.Kommentar);

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

            }
            return true;
        }

        public float Sum(float Temp)
        {
            int count = 7;

            for (int i = 0; i < count; i++)
            {
                
            }
        }

        public float TempStatistic(float Temp)
        {
            for (int i = 0; i < 7; i++)
            {
               float sum = Supporte
            }
        }
    }
}
