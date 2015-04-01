using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KledingWinkelLib.KledingTypes.Algemeen;

namespace KledingWinkelLib.KledingTypes.Algemeen
{
    public enum KledingSize
    {
        NONE =0,
        S,
        M,
        L,
        XL,
        XXL
    }
    public enum KledingType /* OBSOLETE */
    {
        TSHIRT=0,
        JAS
    }
    public enum Merk
    {
        A, B, C, D, E
    }
}


namespace KledingWinkelLib.KledingTypes.Jas
{
    public enum JasType
    {
        Lente =0,
        Zomer,
        Herfst,
        Winter
    }

}