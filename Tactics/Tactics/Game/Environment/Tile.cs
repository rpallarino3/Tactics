using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tactics.Game.Environment
{
    class Tile
    {

        private readonly int TOP_LEFT = 0;
        private readonly int TOP_RIGHT = 1;
        private readonly int BOTTOM_RIGHT = 2;
        private readonly int BOTTOM_LEFT = 3;
        private readonly int TOP = 4;
        private readonly int BOTTOM = 5;
        private readonly int RIGHT = 6;
        private readonly int LEFT = 7;
        // might actually not want these here, move to class where this is actually being constructed

        private bool sloped;
        private int slopedOrientation;

        private int walkingHeight;


        public Tile(bool sloped, int walkingHeight)
        {
            this.sloped = sloped;
            this.walkingHeight = walkingHeight;
        }

        public Tile(bool sloped, int slopedOrientation, int walkingHeight)
        {
            this.sloped = sloped;
            this.slopedOrientation = slopedOrientation;
            this.walkingHeight = walkingHeight;
        }

        public void setWalkingHeight(int height)
        {
            walkingHeight = height;
        }

        public void slope(int direction)
        {
            sloped = true;
            slopedOrientation = direction;
        }

        public void flatten()
        {
            sloped = false;
        }

        public bool isSloped()
        {
            return sloped;
        }

        public int getSlopedOrientation()
        {
            return slopedOrientation;
        }

        public int getWalkingHeight()
        {
            return walkingHeight;
        }




    }
}
