using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

using Tactics.ContentHandlers.Test;

namespace Tactics.ContentHandlers
{
    class ContentHandler
    {

        private ContentManager npcAnimationContent;
        private ContentManager menuContent;
        private ContentManager zoneContent;
        private ContentManager battleContent;

        private RegionContentHandler testRegionContentHandler;

        private Dictionary<int, RegionContentHandler> regionContent;

        public ContentHandler(ContentManager npcAnimationContent, ContentManager menuContent, ContentManager zoneContent, ContentManager battleContent)
        {
            this.npcAnimationContent = npcAnimationContent;
            this.menuContent = menuContent;
            this.zoneContent = zoneContent;
            this.battleContent = battleContent;
            regionContent = new Dictionary<int, RegionContentHandler>();
            testRegionContentHandler = new TestRegionContentHandler(zoneContent);
            regionContent.Add(0, testRegionContentHandler);
        }

        public Dictionary<int, RegionContentHandler> getRegionContent()
        {
            return regionContent;
        }
    }
}
