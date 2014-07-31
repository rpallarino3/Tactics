using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;

namespace Tactics.ContentHandlers.Test
{
    class TestCharacterContentHandler : CharacterContentHandler
    {

        public TestCharacterContentHandler(ContentManager content)
        {
            this.content = content;
        }

        public override void loadContent()
        {
            spriteSheet = content.Load<Texture2D>("Images/TestCharacter/testplayersprites");
            spriteSize = new Vector2(24, 34);
            blockStart = new Vector2(1, 1);
            blockSize = new Vector2(30, 40);
        }
    }
}
