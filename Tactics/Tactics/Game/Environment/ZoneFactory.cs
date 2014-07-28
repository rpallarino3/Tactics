using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tactics.Game.Environment
{
    abstract class ZoneFactory
    {

        protected List<Zone> regionZones;


        public abstract void createZones();

        public List<Zone> getRegionZones()
        {
            return regionZones;
        }
    }
}
