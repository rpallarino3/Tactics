using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace Tactics.ContentHandlers
{
    abstract class RegionContentHandler
    {

        protected ContentManager content;
        protected List<Texture2D> tileImages;
        protected List<Texture2D> leftWallImages;
        protected List<Texture2D> rightWallImages;
        protected List<Texture2D> bottomRightSlope;
        protected List<Texture2D> bottomLeftSlope;
        protected List<Texture2D> topRightSlope;
        protected List<Texture2D> topLeftSlope;
        protected List<Texture2D> rightSlope;
        protected List<Texture2D> leftSlope;
        protected List<Texture2D> topSlope;
        protected List<Texture2D> bottomSlope;

        public abstract void loadContent();

        public void unloadContent()
        {
            content.Unload();
        }

        public List<Texture2D> getTileImages()
        {
            return tileImages;
        }

        public Texture2D getSpecificTileImage(int index)
        {
            return tileImages[index];
        }

        public List<Texture2D> getLeftWallImages()
        {
            return leftWallImages;
        }

        public Texture2D getSpecificLeftWallImage(int index)
        {
            return leftWallImages[index];
        }

        public List<Texture2D> getRightWallImages()
        {
            return rightWallImages;
        }

        public Texture2D getSpecificRightWallImage(int index)
        {
            return rightWallImages[index];
        }

        public List<Texture2D> getBottomRightSlope()
        {
            return bottomRightSlope;
        }

        public Texture2D getSpecificBottomRightSlopeImage(int index)
        {
            return bottomRightSlope[index];
        }

        public List<Texture2D> getBottomLeftSlope()
        {
            return bottomLeftSlope;
        }

        public Texture2D getSpecificBottomLeftSlopeImage(int index)
        {
            return bottomLeftSlope[index];
        }

        public List<Texture2D> getTopRightSlope()
        {
            return topRightSlope;
        }

        public Texture2D getSpecificTopRightSlopeImage(int index)
        {
            return topRightSlope[index];
        }

        public List<Texture2D> getTopLeftSlope()
        {
            return topLeftSlope;
        }

        public Texture2D getSpecificTopLeftSlopeImage(int index)
        {
            return topLeftSlope[index];
        }

        public List<Texture2D> getTopSlope()
        {
            return topSlope;
        }

        public Texture2D getSpecificTopSlopeImage(int index)
        {
            return topSlope[index];
        }

        public List<Texture2D> getBottomSlope()
        {
            return bottomSlope;
        }

        public Texture2D getSpecificBottomSlopeImage(int index)
        {
            return bottomSlope[index];
        }

        public List<Texture2D> getRightSlope()
        {
            return rightSlope;
        }

        public Texture2D getSpecificRightSlopeImage(int index)
        {
            return rightSlope[index];
        }

        public List<Texture2D> getLeftSlope()
        {
            return leftSlope;
        }

        public Texture2D getSpecificLeftSlopeImage(int index)
        {
            return leftSlope[index];
        }
    }
}
