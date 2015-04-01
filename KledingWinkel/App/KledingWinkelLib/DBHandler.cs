using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

using KledingWinkelLib.Products;
using KledingWinkelLib.OrderManager;
using KledingWinkelLib.Objects;
using System.Data;

namespace KledingWinkelLib
{
    public class DBHandler
    {
        #region base values & constructor
        static private SqlConnection sqlconn;
        static public bool IsClosed {get;private set;}

        /// <summary>
        /// Initializes a new DBHandler class with SQL Connection derived from the specified SQL Database ConnectionString
        /// </summary>
        /// <param name="connString">The SQL Database connection string to use</param>
        public DBHandler(string connString)
        {
            sqlconn = new SqlConnection(connString);
        }
        #endregion

        #region CRUD commands
        /// <summary>
        /// Inserts the specified OBJECT into the given database table
        /// </summary>
        /// <param name="tableName">The table to add the object to</param>
        /// <param name="o">The Object of type Tshirt, Jas(coat), Customer or Order to add to the table</param>
        /// <returns>Whether successful or not</returns>
        public bool SqlInsert(string tableName, Object o)
        {
            bool flag = false;
            
            if(o.GetType() == typeof(Order))
            {
                return CreateNewOrder(tableName, (Order)o);
            }

            string cmdtext = "";
            
            SqlCommand sqlComm = new SqlCommand();
            sqlComm.Parameters.AddRange(GenerateInsertParameters(o,out cmdtext));

            sqlComm.CommandText = string.Format("INSERT INTO {0} {1}",tableName,cmdtext);
            try
            {
                ExecuteSqlCommand("insert", sqlComm);
                flag = true;
            }
            catch
            {
                flag = false;
            }

            return flag;
        }

        #endregion

        private bool CreateNewOrder(string tableName, Order o)
        {
            bool flag = false;

            Dictionary<Jas, int> orderedCoats = o.orderedJassen;
            Dictionary<Tshirt, int> orderedTshirts = o.orderedTshirts;

            // Get the first product ordered from the collection and process it
            // To get a reference point
            int firstLineClothID = 0;
            int firstLineClothAmount = 0;
            if(orderedCoats.Keys.Count != 0)
            {
                firstLineClothID = orderedCoats.First().Key.id;
                firstLineClothAmount = orderedCoats.First().Value;
                orderedCoats.Remove(orderedCoats.First().Key);
            }
            else if(orderedTshirts.Keys.Count != 0)
            {
                firstLineClothID = orderedTshirts.First().Key.id;
                firstLineClothAmount = orderedTshirts.First().Value;
                orderedTshirts.Remove(orderedTshirts.First().Key);
            }
            else
            {
                return false; // there is nothing to add, so report false.
            }

            // Add the order and it's first orderline as reference
            SqlCommand sqlComm = new SqlCommand("AddNewOrder");
            sqlComm.Parameters.Add(new SqlParameter("@CustomerID", System.Data.SqlDbType.Int, 10, "@CustomerID") { Value = o.CustomerID });
            sqlComm.Parameters.Add(new SqlParameter("@ClothID", System.Data.SqlDbType.Int, 10, "@ClothID") { Value = firstLineClothID  });
            sqlComm.Parameters.Add(new SqlParameter("@OrderedAmount", System.Data.SqlDbType.Int, 10, "@OrderedAmount") { Value = firstLineClothAmount });
            
            // Execute the reference adding and get the orderID
            int OrderID = 0;
            if(!ExecuteStoredProcedure(sqlComm,out OrderID))
            {
                return false;
            }

            flag = true;
            sqlComm = null;

            // Add the remaining order lines with the returned OrderID
            SqlCommand sqlCommOrderLine = new SqlCommand("AddOrderLine");
            sqlCommOrderLine.Parameters.Add(new SqlParameter("@OrderID", System.Data.SqlDbType.Int, 10, "@OrderID") { Value = OrderID });
            sqlCommOrderLine.Parameters.Add(new SqlParameter("@ClothingID", System.Data.SqlDbType.Int, 10, "@ClothingID"));
            sqlCommOrderLine.Parameters.Add(new SqlParameter("@Amount", System.Data.SqlDbType.Int, 10, "@Amount"));
            
            foreach(Tshirt t in orderedTshirts.Keys)
            {
                sqlCommOrderLine.Parameters["@ClothingID"].Value = t.id;
                sqlCommOrderLine.Parameters["@Amount"].Value = t.amount;
                if(!ExecuteStoredProcedure(sqlCommOrderLine))
                {
                    flag = false;
                }
            }
            foreach (Jas j in orderedCoats.Keys)
            {
                sqlCommOrderLine.Parameters["@ClothingID"].Value = j.id;
                sqlCommOrderLine.Parameters["@Amount"].Value = j.amount;
                if(!ExecuteStoredProcedure(sqlCommOrderLine))
                {
                    flag = false;
                }
            }
            return flag;
        }

        public DataTable GetOverView(string storedProcedureName)
        {
            return ExecuteStoredProcedure(storedProcedureName);
        }
        
        #region Stored Procedure methods
        private bool ExecuteStoredProcedure(SqlCommand sqlComm, out int rowID)
        {
            try
            {
                int rowid = 0;
                sqlComm.Connection = sqlconn;
                sqlComm.CommandType = System.Data.CommandType.StoredProcedure;

                if (sqlconn.State != System.Data.ConnectionState.Open)
                {
                    sqlconn.Open();
                    IsClosed = false;
                }

                rowid = (int)sqlComm.ExecuteScalar();


                if (sqlconn.State != System.Data.ConnectionState.Closed)
                {
                    sqlconn.Close();
                }
                rowID = rowid;
                return true;
            }
            catch
            {
                rowID = 0;
                return false;
            }
        }
        private bool ExecuteStoredProcedure(SqlCommand sqlComm)
        {
            sqlComm.Connection = sqlconn;
            sqlComm.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                if (sqlconn.State != System.Data.ConnectionState.Open)
                {
                    sqlconn.Open();
                    IsClosed = false;
                }

                sqlComm.ExecuteScalar();


                if (sqlconn.State != System.Data.ConnectionState.Closed)
                {
                    sqlconn.Close();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        private DataTable ExecuteStoredProcedure(string StoredProcedureName)
        {
            SqlCommand sqlComm = new SqlCommand(string.Format("SELECT * FROM {0}",StoredProcedureName));
            sqlComm.Connection = sqlconn;
            sqlComm.CommandType = System.Data.CommandType.Text;
            DataTable dt = null;
            try
            {
                if (sqlconn.State != System.Data.ConnectionState.Open)
                {
                    sqlconn.Open();
                    IsClosed = false;
                }

                SqlDataReader sqlReader = sqlComm.ExecuteReader();
                if (sqlReader.HasRows)
                {
                    dt = new DataTable();
                    dt.Load(sqlReader);
                }


                if (sqlconn.State != System.Data.ConnectionState.Closed)
                {
                    sqlconn.Close();
                }
            }
            catch(Exception ex)
            {
                return null;
            }
            return dt;
        }
        #endregion

        // TODO: return the values read, or the results of adding, editing and removal of values
        
        /// <summary>
        /// Executes the given SQLCommand with the appropiate tools derived from the given crudCommand
        /// </summary>
        /// <param name="crudCmd">Can be either 'select','insert','update' or 'delete'</param>
        /// <param name="sqlComm">The prepped SQLCommand to execute</param>
        private void ExecuteSqlCommand(string crudCmd, SqlCommand sqlComm)
        {
            sqlComm.Connection = sqlconn;
            
            if (sqlconn.State != System.Data.ConnectionState.Open)
            {
                sqlconn.Open();
                IsClosed = false;
            }

            switch(crudCmd)
            {
                case "select":
                    SqlDataReader sqlReader = sqlComm.ExecuteReader();
                    // todo : read what the reader has read and cast to object
                    break;
                case "insert":

                    int rowsAffected = sqlComm.ExecuteNonQuery();

                    break;
                case "update":
                    // todo

                    break;
                case "remove":
                    // todo

                    break;
            }



            if (sqlconn.State != System.Data.ConnectionState.Closed)
            {
                sqlconn.Close();
            }
        }

        #region Helper methods
        /// <summary>
        /// Closes the connection to the SQL database if the connection is deemed still open. Returns true or false depending on a successful connection close.
        /// </summary>
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

        /// <summary>
        /// Generates an insert SQL query with the needed parameters derived from the Object specified.
        /// </summary>
        /// <param name="O">Object of type Tshirt, Jas(coat) or Customer</param>
        /// <param name="cmdText">The string field to store the SQL Query string in</param>
        /// <returns>An array of SQL Parameters to be added to the SQLCommand</returns>
        private SqlParameter[] GenerateInsertParameters(Object O, out string cmdText)
        {
            List<SqlParameter> sqlParamColl = new List<SqlParameter>();
            string columnNames = "(";
            string values = " ) VALUES (";
            string cmdtext = "";

            if (O.GetType() == typeof(Tshirt))
            {
                #region Tshirt Parameters creation
                Tshirt t = (Tshirt)O;
                Dictionary<string, string> objectData = t.GetData;
                foreach (string key in objectData.Keys)
                {
                    Int32 idField = 0;
                    if (key != "KledingStukID")
                    {
                        columnNames += key;
                        if (key.ToLower().Contains("id"))
                        {
                            idField = Int32.Parse(objectData[key]);
                            SqlParameter idParam = new SqlParameter(string.Format("@{0}", key), System.Data.SqlDbType.Int, 10, key);
                            idParam.Value = idField;
                            sqlParamColl.Add(idParam);

                            values += string.Format("'@{0}'", key);
                        }
                        else
                        {
                            KeyValuePair<System.Data.SqlDbType, int> columnSpecifics = DefineColumnSpecifics(key);
                            if (key == "Text")
                            {
                                SqlParameter param = new SqlParameter(string.Format("@{0}", key), columnSpecifics.Key, columnSpecifics.Value, key);
                                param.IsNullable = true;
                                param.Value = objectData[key];
                                sqlParamColl.Add(param);
                            }
                            else if (key == "Price")
                            {
                                SqlParameter priceParam = new SqlParameter(string.Format("@{0}", key), columnSpecifics.Key, columnSpecifics.Value, key);
                                priceParam.Value = decimal.Parse(objectData[key]);
                                sqlParamColl.Add(priceParam);
                            }
                            else
                            {
                                sqlParamColl.Add(new SqlParameter(string.Format("@{0}", key), columnSpecifics.Key, columnSpecifics.Value, key) { Value = objectData[key] });
                            }
                            values += string.Format("@{0}", key);
                        }
                        if (objectData.Keys.Last() != key)
                        {
                            columnNames += ",";
                            values += ",";
                        }
                    }
                }
                values += ")";
                cmdtext = string.Format("{0} {1}", columnNames, values);
                #endregion
            }
            else if (O.GetType() == typeof(Jas))
            {
                #region Jas Parameters creation
                Jas j = (Jas)O;
                Dictionary<string, string> objectData = j.GetData;
                foreach (string key in objectData.Keys)
                {
                    Int32 idField = 0;
                    if (key != "KledingStukID")
                    {
                        columnNames += key;
                        if (key.ToLower().Contains("id"))
                        {
                            idField = Int32.Parse(objectData[key]);
                            SqlParameter idParam = new SqlParameter(string.Format("@{0}", key), System.Data.SqlDbType.Int, 10, key);
                            idParam.Value = idField;
                            sqlParamColl.Add(idParam);

                            values += string.Format("'@{0}'", key);
                        }
                        else
                        {
                            KeyValuePair<System.Data.SqlDbType, int> columnSpecifics = DefineColumnSpecifics(key);
                            if (key == "JasType")
                            {
                                SqlParameter param = new SqlParameter(string.Format("@{0}", key), columnSpecifics.Key, columnSpecifics.Value, key);
                                param.IsNullable = true;
                                param.Value = objectData[key];
                                sqlParamColl.Add(param);
                            }
                            else if (key == "Price")
                            {
                                SqlParameter priceParam = new SqlParameter(string.Format("@{0}", key), columnSpecifics.Key, columnSpecifics.Value, key);
                                priceParam.Value = decimal.Parse(objectData[key]);
                                sqlParamColl.Add(priceParam);
                            }
                            else
                            {
                                sqlParamColl.Add(new SqlParameter(string.Format("@{0}", key), columnSpecifics.Key, columnSpecifics.Value, key) { Value = objectData[key] });
                            }
                            values += string.Format("@{0}", key);
                        }
                        if (objectData.Keys.Last() != key)
                        {
                            columnNames += ",";
                            values += ",";
                        }
                    }
                }
                values += ")";
                cmdtext = string.Format("{0} {1}", columnNames, values);
                #endregion
            }
            else if (O.GetType() == typeof(Objects.Customer))
            {
                #region Customer Parameters creation
                Customer c = (Customer)O;
                Dictionary<string, string> objectData = c.GetData;
                foreach (string key in objectData.Keys)
                {
                    columnNames += key;

                    KeyValuePair<System.Data.SqlDbType, int> columnSpecifics = DefineColumnSpecifics(key);
                    sqlParamColl.Add(new SqlParameter(string.Format("@{0}", key), columnSpecifics.Key, columnSpecifics.Value, key) { Value = objectData[key] });

                    values += string.Format("@{0}", key);
                    if (objectData.Keys.Last() != key)
                    {
                        columnNames += ",";
                        values += ",";
                    }
                }
                values += ")";
                cmdtext = string.Format("{0} {1}", columnNames, values);
                #endregion
            }
            cmdText = cmdtext;
            return sqlParamColl.ToArray();
        }

        /// <summary>
        /// Defines the SQL database column specifics by column name.
        /// </summary>
        /// <param name="colName">The column name to get the specifics from</param>
        /// <returns>KeyValuePair with the DB column TYPE and LENGTH</returns>
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
                case "Price":
                    colLength = 8;
                    colDataType = System.Data.SqlDbType.Decimal;
                    break;
                case "IsForSale":
                    colLength = 1;
                    colDataType = System.Data.SqlDbType.Bit;
                    break;
                default:
                    colDataType = System.Data.SqlDbType.Int;
                    colLength = 10;
                    break;
            }
            return new KeyValuePair<System.Data.SqlDbType, int>(colDataType, colLength);
        }
        #endregion
    }

    //else if(O.GetType() == typeof(Order))
    //{
    //    Order o = (Order)O;
    //    Dictionary<string, string> objectData = o.GetData;
    //    int customerID = int.Parse(objectData["CustomerID"]);

    //    // Experimental

    //    string queryString = "AddNewOrder(@CustomerID, @ClothID,@OrderedAmount)";

    //    SqlParameter orderParam = new SqlParameter(string.Format("@CustomerID"), System.Data.SqlDbType.Int, 10, "CustomerID");



    //    values += ")";
    //    cmdtext = string.Format("{0} {1}", columnNames, values);
    //}
    /*
    public class DBHandlerV2
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
            ExecuteSqlCommand(GeneratedCommand);
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
            cmdstr = string.Format("{0} * FROM {1}", cmd, tablename);

            if (objectvalues.Keys.Count != 0)
            {
                cmdstr += string.Format(" WHERE");
                foreach (string objectKey in objectvalues.Keys)
                {
                    KeyValuePair<System.Data.SqlDbType, int> ColumnSpecifics = DefineColumnSpecifics(objectKey);
                    cmdstr += string.Format(" {0} = @{1}", objectKey, objectKey);
                    int idField = 0;

                    if(objectKey.ToLower().Contains("id") && ColumnSpecifics.Key == System.Data.SqlDbType.Int)
                    {
                        if(int.TryParse(objectvalues[objectKey], out idField))
                        {
                            sqlcmd.Parameters.AddWithValue(string.Format("@{0}", objectKey),(object)idField);
                        }
                    }
                    else
                    {
                        sqlcmd.Parameters.AddWithValue(string.Format("@{0}", objectKey), (object)objectvalues[objectKey]);
                    }

                    if(objectvalues[objectKey] != objectvalues.Values.Last())
                    {
                        cmdstr += " AND";
                    }
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
                    colLength = 10;
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

        private void ExecuteSqlCommand(SqlCommand sqlComm)
        {
            sqlComm.Connection = sqlconn;
            
            if (sqlconn.State != System.Data.ConnectionState.Open)
            {
                sqlconn.Open();
                IsClosed = false;
            }
            SqlDataReader reader = sqlComm.ExecuteReader();
            reader.Read();
            //while (reader.Read())
            //{
            //    //string r = reader.GetFieldValue<string>(1);

            //}

            if (sqlconn.State != System.Data.ConnectionState.Closed)
            {
                sqlconn.Close();
            }
        }
    }
     * 
     * */
}

// fill the receivedInfo dict with any select cmds
//Dictionary<string, Dictionary<string, string>> receivedInfo = new Dictionary<string, Dictionary<string, string>>();
