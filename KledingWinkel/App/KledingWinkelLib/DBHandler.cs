using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

using KledingWinkelLib.Products;
using KledingWinkelLib.OrderManager;

namespace KledingWinkelLib
{
    public class DBHandler
    {
        static private SqlConnection sqlconn;
        static public bool IsClosed { get; private set; }
        public DBHandler(string connString)
        {
            sqlconn = new SqlConnection(connString);
        }
        public bool ClientExists(string name)
        {
            SqlCommand sqlcom = new SqlCommand(string.Format("SELECT Count(*) FROM Customer WHERE Customer.Name='{0}'",name), sqlconn);
            //SqlParameter sqpPram = new SqlParameter()
            sqlconn.Open();
            SqlDataReader sqldr = sqlcom.ExecuteReader();
            bool flag = false;
            while (sqldr.Read())
            {
                if ((int)sqldr[0] == 1)
                {
                    flag = true;
                }
            }
            return flag;
        }

        public void SendMessage(int cmdid ,Object obj)
        {
            Dictionary<string, string> objInfo = new Dictionary<string, string>();
            string tablename = "";
            // Define the object type and retrieve its details
            if(obj.GetType() == typeof(Jas))
            {
                Jas j = (Jas)obj;
                objInfo = j.GetData;
                tablename = "KledingStuk";
            }
            else if(obj.GetType() == typeof(Tshirt))
            {
                Tshirt t = (Tshirt)obj;
                objInfo = t.GetData;
                tablename = "KledingStuk";
            }
            else if(obj.GetType() == typeof(Order))
            {
                Order o = (Order)obj;
                objInfo = o.GetData;

            }

            // Generate query from objInfo
            SqlCommand GeneratedCommand = GenerateQuery(cmdid, tablename,objInfo);

        }

        private SqlCommand GenerateQuery(int cmdID, string tablename, Dictionary<string, string> objectvalues)
        {
            string cmdstr = "";
            SqlCommand sqlcmd = null;
            string cmd = "";

            #region Command types
            switch (cmdID)
            {
                case 1:
                    cmd = "SELECT";
                    break;
                case 2:
                    cmd = "INSERT";
                    break;
                case 3:
                    cmd = "UPDATE";
                    break;
                case 4:
                    cmd = "REMOVE";
                    break;
            }
            #endregion

            sqlcmd = new SqlCommand();
            sqlcmd.Connection = sqlconn;
            cmdstr = string.Format("{0} * FROM {1}", cmd, tablename);

            if (objectvalues.Keys.Count != 0)
            {
                cmdstr += string.Format(" WHERE");
                foreach (string objectKey in objectvalues.Keys)
                {
                    KeyValuePair<System.Data.SqlDbType, int> ColumnSpecifics = DefineColumnSpecifics(objectKey);
                    cmdstr += string.Format(" @{0} = {1}", objectKey, objectvalues[objectKey]);
                    sqlcmd.Parameters.Add(new SqlParameter(string.Format("@{0}", objectKey), ColumnSpecifics.Key, ColumnSpecifics.Value, objectKey).Value = objectvalues[objectKey]);
                }
            }
            sqlcmd.CommandText = cmdstr;

            return sqlcmd;
        }
        
        private KeyValuePair<System.Data.SqlDbType,int> DefineColumnSpecifics(string colName)
        {
            System.Data.SqlDbType colDataType = System.Data.SqlDbType.Variant;
            int colLength = 0;
            switch(colName)
            {
                case "Name":
                    colLength = 50;
                    colDataType = System.Data.SqlDbType.VarChar;
                    break;
                case "StreetName":
                    colLength = 50;
                    colDataType = System.Data.SqlDbType.VarChar;
                    break;
                case "City":
                    colLength = 50;
                    colDataType = System.Data.SqlDbType.VarChar;
                    break;
                case "Country":
                    colLength = 50;
                    colDataType = System.Data.SqlDbType.VarChar;
                    break;
                case "Zippcode":
                    colLength = 12;
                    colDataType = System.Data.SqlDbType.VarChar;
                    break;
                case "Text":
                    colLength = 50;
                    colDataType = System.Data.SqlDbType.VarChar;
                    break;
                case "ImageUrl":
                    colLength = 255;
                    colDataType = System.Data.SqlDbType.VarChar;
                    break;
                case "Size":
                    colLength = 10;
                    colDataType = System.Data.SqlDbType.VarChar;
                    break;
                case "Merk":
                    colLength = 50;
                    colDataType = System.Data.SqlDbType.VarChar;
                    break;
                case "JasType":
                    colLength = 50;
                    colDataType = System.Data.SqlDbType.VarChar;
                    break;
                default:
                    colDataType = System.Data.SqlDbType.Int;
                    break;
            }
            return new KeyValuePair<System.Data.SqlDbType, int>(colDataType, colLength);
        }

        static public bool CloseConnection
        {
            get
            {
                bool flag = false;
                try
                {
                    sqlconn.Close();
                    flag = true;
                }
                catch(Exception ex)
                {
                    flag = false;
                }
                IsClosed = flag;
                return flag;
            }
        }

        private void ExecuteSqlCommand(string queryString)
        {
            SqlCommand sqlcomm = new SqlCommand(queryString,sqlconn);
            if (sqlconn.State != System.Data.ConnectionState.Open)
            {
                sqlconn.Open();
                IsClosed = false;
            }
            SqlDataReader reader = sqlcomm.ExecuteReader();

            while (reader.Read())
            {
                string r = reader.GetFieldValue<string>(1);

                string cName = (string)reader["CustomerName"];
            }

            if (sqlconn.State != System.Data.ConnectionState.Closed)
            {
                sqlconn.Close();
            }
        }
    }
}

// fill the receivedInfo dict with any select cmds
//Dictionary<string, Dictionary<string, string>> receivedInfo = new Dictionary<string, Dictionary<string, string>>();
