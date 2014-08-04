using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace Tactics.ContentHandlers.Test
{
    class TestRegionContentHandler : RegionContentHandler
    {
        public TestRegionContentHandler(ContentManager content)
        {
            this.content = content;
            tileImages = new List<Texture2D>();
            leftWallImages = new List<Texture2D>();
            rightWallImages = new List<Texture2D>();
            bottomRightSlope = new List<Texture2D>();
            bottomLeftSlope = new List<Texture2D>();
            topLeftSlope = new List<Texture2D>();
            topRightSlope = new List<Texture2D>();
            leftSlope = new List<Texture2D>();
            rightSlope = new List<Texture2D>();
            topSlope = new List<Texture2D>();
            bottomSlope = new List<Texture2D>();
        }

        public override void loadContent()
        {
            loadBlueTileImages();
            loadGreenTileImages();
            loadBrownTileImages();
        }

        private void loadBlueTileImages()
        {
            tileImages.Add(content.Load<Texture2D>("Images/TestZones/SolidBlue/tilewithedges"));
            leftWallImages.Add(content.Load<Texture2D>("Images/TestZones/SolidBlue/leftvertical"));
            rightWallImages.Add(content.Load<Texture2D>("Images/TestZones/SolidBlue/rightvertical"));
            bottomRightSlope.Add(content.Load<Texture2D>("Images/TestZones/SolidBlue/slopebottomright"));
            bottomLeftSlope.Add(content.Load<Texture2D>("Images/TestZones/SolidBlue/slopebottomleft"));
            topLeftSlope.Add(content.Load<Texture2D>("Images/TestZones/SolidBlue/slopetopleft"));
            topRightSlope.Add(content.Load<Texture2D>("Images/TestZones/SolidBlue/slopetopright"));
            leftSlope.Add(content.Load<Texture2D>("Images/TestZones/SolidBlue/slopeleft"));
            rightSlope.Add(content.Load<Texture2D>("Images/TestZones/SolidBlue/sloperight"));
            topSlope.Add(content.Load<Texture2D>("Images/TestZones/SolidBlue/slopetop"));
            bottomSlope.Add(content.Load<Texture2D>("Images/TestZones/SolidBlue/slopedown"));
        }

        private void loadGreenTileImages()
        {
            tileImages.Add(content.Load<Texture2D>("Images/TestZones/SolidGreen/tilewithedges"));
            leftWallImages.Add(content.Load<Texture2D>("Images/TestZones/SolidGreen/leftvertical"));
            rightWallImages.Add(content.Load<Texture2D>("Images/TestZones/SolidGreen/rightvertical"));
            bottomRightSlope.Add(content.Load<Texture2D>("Images/TestZones/SolidGreen/slopebottomright"));
            bottomLeftSlope.Add(content.Load<Texture2D>("Images/TestZones/SolidGreen/slopebottomleft"));
            topLeftSlope.Add(content.Load<Texture2D>("Images/TestZones/SolidGreen/slopetopleft"));
            topRightSlope.Add(content.Load<Texture2D>("Images/TestZones/SolidGreen/slopetopright"));
            leftSlope.Add(content.Load<Texture2D>("Images/TestZones/SolidGreen/slopeleft"));
            rightSlope.Add(content.Load<Texture2D>("Images/TestZones/SolidGreen/sloperight"));
            topSlope.Add(content.Load<Texture2D>("Images/TestZones/SolidGreen/slopetop"));
            bottomSlope.Add(content.Load<Texture2D>("Images/TestZones/SolidGreen/slopedown"));
        }

        private void loadBrownTileImages()
        {
            tileImages.Add(content.Load<Texture2D>("Images/TestZones/SolidBrown/tilewithedges"));
            leftWallImages.Add(content.Load<Texture2D>("Images/TestZones/SolidBrown/leftvertical"));
            rightWallImages.Add(content.Load<Texture2D>("Images/TestZones/SolidBrown/rightvertical"));
            bottomRightSlope.Add(content.Load<Texture2D>("Images/TestZones/SolidBrown/slopebottomright"));
            bottomLeftSlope.Add(content.Load<Texture2D>("Images/TestZones/SolidBrown/slopebottomleft"));
            topLeftSlope.Add(content.Load<Texture2D>("Images/TestZones/SolidBrown/slopetopleft"));
            topRightSlope.Add(content.Load<Texture2D>("Images/TestZones/SolidBrown/slopetopright"));
            leftSlope.Add(content.Load<Texture2D>("Images/TestZones/SolidBrown/slopeleft"));
            rightSlope.Add(content.Load<Texture2D>("Images/TestZones/SolidBrown/sloperight"));
            topSlope.Add(content.Load<Texture2D>("Images/TestZones/SolidBrown/slopetop"));
            bottomSlope.Add(content.Load<Texture2D>("Images/TestZones/SolidBrown/slopedown"));
        }
    }
}
