using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KentekenRegistratieLib.Objects
{
    public class LuchtVoertuig : Voertuig
    {
        public int AantalMotoren { get; private set; }

        public LuchtVoertuig(int aantalMotoren,int id, Kenteken k, int snelheid, string merk, bool isapkGekeurd, DateTime registratiedatum, DateTime productiejaar, string typemotor,
            int gewicht, int aantalpk, int tankgrootte) : base(id,k,snelheid,merk,isapkGekeurd,registratiedatum,productiejaar,typemotor,gewicht,aantalpk,tankgrootte)
        {
            AantalMotoren = aantalMotoren;
        }
    }

    public class Vliegtuig : LuchtVoertuig
    {
        public int AantalPassagiers { get; private set; }

        public Vliegtuig(int aantalPassagiers, int aantalMotoren,int id, Kenteken k, int snelheid, string merk, bool isapkGekeurd, DateTime registratiedatum, DateTime productiejaar, string typemotor,
            int gewicht, int aantalpk, int tankgrootte) : base(aantalMotoren,id,k,snelheid,merk,isapkGekeurd,registratiedatum,productiejaar,typemotor,gewicht,aantalpk,tankgrootte)
        {
            AantalPassagiers = aantalPassagiers;
        }

    }
    

}
