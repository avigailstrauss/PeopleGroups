using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleGroups
{
    class DBConnector
    {
        public string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
        
        public void ExecuteSP(string spName, List<SqlParameter> oParams)
        {
            try
            {
                using (SqlConnection oConn = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand oComm = new SqlCommand(spName, oConn))
                    {
                        oConn.Open();
                        for(int i = 0; i < oParams.Count; i++)
                        {
                            oComm.Parameters.Add(oParams[i].ParameterName, oParams[i].Value);
                        }
                        oComm.CommandType = System.Data.CommandType.StoredProcedure;
                        oComm.ExecuteNonQuery();
                    }               
                }
       

            }
            catch (Exception e)
            {

            }
        }

        public DataSet GetDSfromSP(string spName, List<SqlParameter> oParams)
        {
            try
            {
                DataSet oDs;
                using (SqlConnection oConn = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand oComm = new SqlCommand(spName, oConn))
                    {
                        oConn.Open();
                        for (int i = 0; i < oParams.Count; i++)
                        {
                            oComm.Parameters.Add(oParams[i].ParameterName, oParams[i].Value);
                        }
                        oComm.CommandType = System.Data.CommandType.StoredProcedure;

                        SqlDataAdapter adpt = new SqlDataAdapter(oComm);
                        oDs = new DataSet();

                        adpt.Fill(oDs);
                    }
                }

                return oDs;
            }
            catch (Exception e)
            {
                return new DataSet();
            }
        }
    }
}
