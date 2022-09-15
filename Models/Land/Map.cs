using System;
using System.Collections.Generic;
using System.Text;
using static AxisAndAllies3.Models.Land.Territories;
namespace AxisAndAllies3.Models.Land
{
    public class Map
    {
        public Dictionary<Territories, Territories[]> _map = new Dictionary<Territories, Territories[]>()
        {
            {ALASKA, new []{SZ_64, SZ_65, WESTERN_CANADA} },
            {ALGERIA, new []{SZ_14, MOROCCO, LIBYA} },
            {ANGLO_EGYPT_SUDAN, new []{SZ_34, EGYPT, ITALIAN_EAST_AFRICA, RHODESIA, BELGIAN_CONGO, FRENCH_EQUATORIAL_AFRICA} },
            {ANGOLA, new []{SZ_14, MOROCCO, LIBYA} }
        };

    }
}
