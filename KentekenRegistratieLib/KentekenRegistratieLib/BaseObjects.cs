using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KentekenRegistratieLib
{
    public class Voertuig : DBHandler.DBHandlerEntity
    {
        public int ID {get;private set;}
        public Kenteken GeregistreerdKenteken { get; private set; }
        public int Snelheid { get; private set; }
        public string Merk { get; private set; }
        public bool IsAPKGekeurd { get; private set; }
        public DateTime RegistratieDatum { get; private set; }
        public DateTime ProductieJaar { get; private set; }
        public string TypeMotor { get; private set;}
        public int Gewicht {get;private set;}
        public int AantalPK {get;private set;}
        public int TankGrootte {get;private set;}
        Dictionary<string, object> VoertuigDatabaseGegevens;

        public Voertuig(int voertuigID, Kenteken kenteken, int snelheid, string merk, bool isApkGekeurd, DateTime registratieDatum, DateTime productieJaar, 
            string typeMotor, int gewicht, int aantalPK, int tankGrootte)
        {
            ID = voertuigID;
            GeregistreerdKenteken = kenteken;
            Snelheid = snelheid;
            Merk = merk;
            IsAPKGekeurd = isApkGekeurd;
            RegistratieDatum = registratieDatum;
            ProductieJaar = productieJaar;
            TypeMotor = typeMotor;
            Gewicht = gewicht;
            AantalPK = aantalPK;
            TankGrootte = tankGrootte;
            VoertuigDatabaseGegevens = new Dictionary<string, object>();

        }

        public override Dictionary<string, object> GetData
        {
            get { return VoertuigDatabaseGegevens; }
        }

        public override Dictionary<string, object> SetData
        {
            set { VoertuigDatabaseGegevens = value; }
        }

    }

    public class Kenteken : DBHandler.DBHandlerEntity
    {
        public int ID { get; private set; }
        public int EigenaarID { get; private set; }
        public string kenteken { get; private set; }
        public DateTime RegistratieDatum { get; private set; }
        public DateTime VerloopDatum { get; private set; }

        public Kenteken(int kentekenID, int eigenaarID, string _kenteken, DateTime registratieDatum, DateTime verloopDatum)
        {
            ID = kentekenID;
            EigenaarID = eigenaarID;
            kenteken = _kenteken;
            RegistratieDatum = registratieDatum;
            VerloopDatum = verloopDatum;
        }


        public override Dictionary<string, object> GetData
        {
            get { throw new NotImplementedException(); }
        }

        public override Dictionary<string, object> SetData
        {
            set { throw new NotImplementedException(); }
        }
    }

    public class Persoon : DBHandler.DBHandlerEntity
    {
        public int ID { get; private set; }
        public string VoorNaam { get; private set; }
        public string TussenVoegsel { get; private set; }
        public string AchterNaam { get; private set; }
        public DateTime GeboorteDatum { get; private set; }
        public List<Kenteken> KentekensOpNaam { get; private set; }

        public Persoon(int persoonID, string voorNaam, string tussenVoegsel, string achterNaam, DateTime geboorteDatum, List<Kenteken> kentekensOpNaam)
        {
            ID = persoonID;
            VoorNaam = voorNaam;
            TussenVoegsel = tussenVoegsel;
            AchterNaam = achterNaam;
            GeboorteDatum = geboorteDatum;
            KentekensOpNaam = kentekensOpNaam;
        }

        public override Dictionary<string, object> GetData
        {
            get { throw new NotImplementedException(); }
        }

        public override Dictionary<string, object> SetData
        {
            set { throw new NotImplementedException(); }
        }
    }

}
