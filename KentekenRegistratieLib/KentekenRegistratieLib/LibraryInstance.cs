using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBHandler;
using System.Data;

namespace KentekenRegistratieLib
{
    /// <summary>
    /// contains the whole library as one instance for ease of usage
    /// </summary>
    public class LibraryInstance
    {
        #region Base Values
        public Dictionary<int, Persoon> GeregistreerdePersonen { get; private set; }
        public Dictionary<int, Kenteken> GeregistreerdeKentekens { get; private set; }
        public bool IsInitialized { get; private set; }
        public string ErrorCode { get; private set; }

        public DataBaseHandler dbhandler { get; private set; }
        #endregion

        public LibraryInstance(DatabaseType dbType, string connectionString)
        {
            dbhandler = new DataBaseHandler(dbType, connectionString);

            if(dbhandler.RegisterType(typeof(Kenteken), "Kenteken") == TypeRegResult.Successfull && dbhandler.RegisterType(typeof(Persoon), "Persoon") == TypeRegResult.Successfull
                && dbhandler.RegisterType(typeof(Voertuig), "Voertuig") == TypeRegResult.Successfull)
            {
                if (RetrieveInitialData())
                {
                    IsInitialized = true;
                }
                else
                {
                    ErrorCode = "Failed to initialize initial data";
                }
            }
            else
            {
                IsInitialized = false;
                ErrorCode = "Failed to register base object types";
            }
        }

        #region Interactive methods
        public bool RetrieveInitialData()
        {
            bool flag = false;

            if(dbhandler == null)
            {
                return false;
            }
            DataTable retrievedData = null;
            if(dbhandler.SqlSelectAll(typeof(Persoon), out retrievedData))
            {
                if (retrievedData != null && retrievedData.Rows.Count > 0)
                {
                    foreach(DataRow dr in retrievedData.Rows)
                    {
                        Persoon objPersoon = (Persoon)DataBaseHandler.Convert.DBTable.ToObject(typeof(Persoon), retrievedData);
                        GeregistreerdePersonen.Add(objPersoon.ID,objPersoon);
                    }
                    flag = true;
                }
                else
                {
                    ErrorCode = "No data available to retrieve";
                    flag = false;
                }
            }
            else
            {
                ErrorCode = "Failed to execute SQL Select ALL command";
                return false;
            }

            retrievedData = null;
            if(dbhandler.SqlSelectAll(typeof(Kenteken), out retrievedData))
            {
                if (retrievedData != null && retrievedData.Rows.Count > 0)
                {
                    foreach (DataRow dr in retrievedData.Rows)
                    {
                        Kenteken objKenteken = (Kenteken)DataBaseHandler.Convert.DBTable.ToObject(typeof(Kenteken), retrievedData);
                        GeregistreerdeKentekens.Add(objKenteken.ID, objKenteken);
                    }
                    flag = true;
                }
                else
                {
                    ErrorCode = "No data available to retrieve";
                    flag = false;
                }
            }
            else
            {
                ErrorCode = "Failed to execute SQL Select ALL command";
                return false;
            }

            return flag;
        }

        public bool RegistreerPersoon(Persoon p)
        {
            if(dbhandler.SqlInsert(p))
            {
                GeregistreerdePersonen.Add(p.ID, p);
                return true;
            }
            return false;
        }
        public bool RegistreerKenteken(Kenteken k)
        {
            if(dbhandler.SqlInsert(k))
            {
                GeregistreerdeKentekens.Add(k.ID, k);
                GeregistreerdePersonen[k.EigenaarID].KentekensOpNaam.Add(k);
                return true;
            }
            return false;
        }

        public bool KentekenEigenaarWijzigen(Kenteken k)
        {
            DataTable dtOudeKenteken = null;
            Kenteken objOudeKenteken = null;

            if(dbhandler.SqlSelect(typeof(Kenteken),new KeyValuePair<string,int>("KentekenID",k.ID),out dtOudeKenteken))
            {
                objOudeKenteken = (Kenteken)DataBaseHandler.Convert.DBTable.ToObject(typeof(Kenteken),dtOudeKenteken);
            }
            else
            {
                ErrorCode = "Failed to select the old object from the database";
                return false;
            }

            if(dbhandler.SqlUpdate(k))
            {
                if(GeregistreerdePersonen[objOudeKenteken.EigenaarID].KentekensOpNaam.Remove(objOudeKenteken))
                {
                    GeregistreerdePersonen[k.EigenaarID].KentekensOpNaam.Add(k);
                    return true;
                }
                else
                {
                    ErrorCode = "Failed to update the given object in application memory";
                    return false;
                }

            }
            else
            {
                ErrorCode = "Failed to update the given object in the database";
                return false;
            }
        }
        public bool VerwijderKenteken(Kenteken k)
        {
            if(dbhandler.SqlRemove(k))
            {
                if(GeregistreerdeKentekens.Remove(k.ID) && GeregistreerdePersonen[k.EigenaarID].KentekensOpNaam.Remove(k))
                {
                    return true;
                }
                else
                {
                    ErrorCode = "Failed to remove Kenteken from application memory";
                    return false;
                }
            }
            else
            {
                ErrorCode = "Failed to remove specified object in the database";
                return false;
            }
        }

        #endregion

        // TODO: Genereer nieuw kenteken op basis van het laatst gegenereerde kenteken + verhoging van 1 in letter of numerieke vorm
        private string GenereerNieuwKenteken()
        {
            throw new NotImplementedException();
        }
    }
}
