using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Tactics.Game.Characters.CharacterAnimation;

namespace Tactics.Game.Characters
{
    class Character
    {
        private int type;

        private int xPos;
        private int yPos;
        private int height;
        private int facingDirection;

        private CharacterAnimations characterAnimations;

        public Character(int type, CharacterAnimations characterAnimations)
        {
            this.type = type;
            this.characterAnimations = characterAnimations;
            xPos = 0;
            yPos = 0;
            height = 0;
            facingDirection = 0;
        }

        public int getFacingDirection()
        {
            return facingDirection;
        }

        public void setFacingDirection(int direction)
        {
            facingDirection = direction;
        }

        public void moveUp()
        {
            xPos--;
        }

        public void moveDown()
        {
            xPos++;
        }

        public void moveRight()
        {
            yPos--;
        }

        public void moveLeft()
        {
            yPos++;
        }

        public int getX()
        {
            return xPos;
        }

        public void setXPosition(int x)
        {
            xPos = x;
        }

        public int getY()
        {
            return yPos;
        }

        public void setYPosition(int y)
        {
            yPos = y;
        }

        public int getHeight()
        {
            return height;
        }

        public void setHeight(int height)
        {
            this.height = height;
        }

        public int getType()
        {
            return type;
        }

        public CharacterAnimations getCharacterAnimations()
        {
            return characterAnimations;
        }
    }
}
