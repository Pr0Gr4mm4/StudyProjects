using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KentekenRegistratieLib.Objects
{

    public class LandVoertuig : Voertuig
    {
        public LandVoertuig(int id, Kenteken k, int snelheid, string merk, bool isapkGekeurd, DateTime registratiedatum, DateTime productiejaar, string typemotor,
            int gewicht, int aantalpk, int tankgrootte) : base(id,k,snelheid,merk,isapkGekeurd,registratiedatum,productiejaar,typemotor,gewicht,aantalpk,tankgrootte)
        {

        }

    }

    public class Auto : LandVoertuig
    {
        public int AantalDeuren { get; private set; }
        public bool HeeftDakRaam { get; private set; }

        public Auto(int aantalDeuren, bool heeftDakRaam,int id, Kenteken k, int snelheid, string merk, bool isapkGekeurd, DateTime registratiedatum, DateTime productiejaar, string typemotor,
            int gewicht, int aantalpk, int tankgrootte) : base(id,k,snelheid,merk,isapkGekeurd,registratiedatum,productiejaar,typemotor,gewicht,aantalpk,tankgrootte)
        {
            AantalDeuren = aantalDeuren;
            HeeftDakRaam = heeftDakRaam;
        }



    }
    public class Motor : LandVoertuig
    {
        public bool WindScherm { get; private set; }

        public Motor(bool windScherm,int id, Kenteken k, int snelheid, string merk, bool isapkGekeurd, DateTime registratiedatum, DateTime productiejaar, string typemotor,
            int gewicht, int aantalpk, int tankgrootte) : base(id,k,snelheid,merk,isapkGekeurd,registratiedatum,productiejaar,typemotor,gewicht,aantalpk,tankgrootte)
        {
            WindScherm = windScherm;
        }

    }
    public class Vrachtwagen : LandVoertuig
    {
        public bool IsTruck { get; private set; }

        public Vrachtwagen(bool isTruck,int id, Kenteken k, int snelheid, string merk, bool isapkGekeurd, DateTime registratiedatum, DateTime productiejaar, string typemotor,
            int gewicht, int aantalpk, int tankgrootte) : base(id,k,snelheid,merk,isapkGekeurd,registratiedatum,productiejaar,typemotor,gewicht,aantalpk,tankgrootte)
        {
            IsTruck = isTruck;
        }
    }
}
