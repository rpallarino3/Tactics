using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;

namespace Tactics.ContentHandlers
{
    abstract class CharacterContentHandler
    {
        protected ContentManager content;
        protected Texture2D spriteSheet;
        protected Vector2 spriteSize;
        protected Vector2 blockStart;
        protected Vector2 blockSize;

        public abstract void loadContent();

        public ContentManager getContent()
        {
            return content;
        }

        public Texture2D getSpriteSheet()
        {
            return spriteSheet;
        }

        public Vector2 getSpriteSize()
        {
            return spriteSize;
        }

        public Vector2 getBlockStart()
        {
            return blockStart;
        }

        public Vector2 getBlockSize()
        {
            return blockSize;
        }
    }
}
