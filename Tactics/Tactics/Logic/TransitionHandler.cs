using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Tactics.Game;
using Tactics.ContentHandlers;

namespace Tactics.Logic
{
    class TransitionHandler
    {

        public TransitionHandler()
        {
        }

        public void createRegion(GameInit gameInit, ContentHandler content, int regionNumber)
        {
            gameInit.getFreeRoamState().setCurrentRegion(regionNumber);
            gameInit.getRegionFactory().getZoneFactories()[regionNumber].createZones();
            gameInit.getRegionFactory().setCurrentZones(gameInit.getRegionFactory().getZoneFactories()[regionNumber].getRegionZones());
            content.getRegionContent()[regionNumber].loadContent();
        }
    }
}
