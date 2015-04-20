using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KentekenRegistratieLib.Objects
{
    public class WaterVoertuig : Voertuig
    {
        public bool HeeftCabine { get; private set; }

        public WaterVoertuig(bool heeftCabine ,int id, Kenteken k, int snelheid, string merk, bool isapkGekeurd, DateTime registratiedatum, DateTime productiejaar, 
            string typemotor, int gewicht, int aantalpk, int tankgrootte) 
            : base(id,k,snelheid,merk,isapkGekeurd,registratiedatum,productiejaar,typemotor,gewicht,aantalpk,tankgrootte)
        {
            HeeftCabine = heeftCabine;
        }

    }
    public class Boot : WaterVoertuig
    {

        public Boot(bool heeftCabine ,int id, Kenteken k, int snelheid, string merk, bool isapkGekeurd, DateTime registratiedatum, DateTime productiejaar, 
            string typemotor, int gewicht, int aantalpk, int tankgrootte) 
            : base(heeftCabine,id,k,snelheid,merk,isapkGekeurd,registratiedatum,productiejaar,typemotor,gewicht,aantalpk,tankgrootte)
        {

        }

    }
    public class JetSki : WaterVoertuig
    {
        public JetSki(bool heeftCabine ,int id, Kenteken k, int snelheid, string merk, bool isapkGekeurd, DateTime registratiedatum, DateTime productiejaar, 
            string typemotor, int gewicht, int aantalpk, int tankgrootte)
            : base(heeftCabine,id, k, snelheid, merk, isapkGekeurd, registratiedatum, productiejaar, typemotor, gewicht, aantalpk, tankgrootte)
        {

        }
    }

}
