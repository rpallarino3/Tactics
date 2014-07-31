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
        private CharacterContentHandler testCharacterContentHandler;

        private Dictionary<int, RegionContentHandler> regionContent;
        private Dictionary<int, CharacterContentHandler> characterContent;

        public ContentHandler(ContentManager npcAnimationContent, ContentManager menuContent, ContentManager zoneContent, ContentManager battleContent)
        {
            this.npcAnimationContent = npcAnimationContent;
            this.menuContent = menuContent;
            this.zoneContent = zoneContent;
            this.battleContent = battleContent;

            regionContent = new Dictionary<int, RegionContentHandler>();
            testRegionContentHandler = new TestRegionContentHandler(zoneContent);
            regionContent.Add(0, testRegionContentHandler);

            characterContent = new Dictionary<int, CharacterContentHandler>();
            testCharacterContentHandler = new TestCharacterContentHandler(npcAnimationContent);
            testCharacterContentHandler.loadContent(); // probably move this somewhere
            characterContent.Add(0, testCharacterContentHandler);
        }

        public Dictionary<int, RegionContentHandler> getRegionContent()
        {
            return regionContent;
        }

        public Dictionary<int, CharacterContentHandler> getCharacterContent()
        {
            return characterContent;
        }
    }
}
