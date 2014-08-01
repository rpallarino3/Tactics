using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;

namespace Tactics.ContentHandlers
{
    class CharacterContentHandler
    {
        private ContentManager content;
        private Dictionary<int, Texture2D> spriteSheets;

        public CharacterContentHandler(ContentManager content)
        {
            this.content = content;
            spriteSheets = new Dictionary<int, Texture2D>();
        }

        public void loadContent()
        {
            spriteSheets.Add(0, content.Load<Texture2D>("Images/TestCharacter/testplayersprites"));
        }

        public ContentManager getContent()
        {
            return content;
        }

        public Dictionary<int, Texture2D> getSpriteSheets()
        {
            return spriteSheets;
        }
    }
}
