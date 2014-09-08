using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Tactics.Game.Environment.ManipulatableObjects.Animations;
using Tactics.Game.Characters;
using Microsoft.Xna.Framework;

namespace Tactics.Game.Environment.ManipulatableObjects.Objects
{
    class Door : ManipulatableObject
    {
        private int destination;
        private bool locked;
        private Vector2 destinationTile;
        private int orientation;
        private int heightDiff;
        private int keyId;

        public Door(int x, int y, int destination, Vector2 destinationTile, int side, bool locked, int orientation, int heightDiff, int keyID)
        {
            
            xLoc = x;
            yLoc = y;
            type = 1;
            animation = new DoorAnimation();
            this.orientation = orientation;
            this.heightDiff = heightDiff;
            keyId = keyID;

            messageBlockIndex = 0;
            optionIndex = 0;

            chatWindow = false;

            drawOffset = new Vector2(-2, heightDiff * 8 - 21);

            this.destination = destination;
            this.destinationTile = destinationTile;
            this.locked = locked;

            finishedActivating = true;
            upInteract = false;
            downInteract = false;
            rightInteract = false;
            leftInteract = false;

            if (side == 0)
            {
                upInteract = true;
                animation.setNewAnimation(0);
            }
            else if (side == 1)
            {
                downInteract = true;
                animation.setNewAnimation(1);
            }
            else if (side == 2)
            {
                rightInteract = true;
                animation.setNewAnimation(2);
            }
            else if (side == 3)
            {
                leftInteract = true;
                animation.setNewAnimation(3);
            }

        }

        public bool isLocked()
        {
            return locked;
        }

        public int getDestination()
        {
            return destination;
        }

        public Vector2 getDestinationTile()
        {
            return destinationTile;
        }

        public override void activate(GameInit gameInit, Character interactingCharacter, int activationCode)
        {
            if (locked)
            {
                chatWindow = true;
                if (false)
                {
                    messageBlockIndex = 1;
                    locked = false;
                }
                else
                {
                    messageBlockIndex = 0;
                }
            }
            else
            {
                finishedActivating = false;

                if (orientation == 0)
                {
                    animation.setNewAnimation(2);
                }
                else
                {
                    animation.setNewAnimation(3);
                }
            }
        }

        public override void continueActivation(GameInit gameInit, Character interactingCharacter)
        {
            animation.advanceAnimation();
            if (animation.isAnimationFinished())
            {
                finishedActivating = true;
            }
        }

        public override void finishActivation(GameInit gameInit)
        {
            transitionReady = true;
        }

        public override void talk(GameInit gameInit)
        {
            gameInit.getFreeRoamState().setChatWindow(true);

            if (messageBlockIndex == 0)
            {
                gameInit.getFreeRoamState().setMessage(gameInit.getMessageBlockFactory().getObjectBlock(type).getMessage(messageBlockIndex));
                gameInit.getFreeRoamState().setOptions(gameInit.getMessageBlockFactory().getObjectBlock(type).getOptions()[messageBlockIndex]);
                gameInit.getFreeRoamState().setParsedMessage(gameInit.getMessageBlockFactory().getObjectBlock(type).getParsedMessage(messageBlockIndex));
            }
            else if (messageBlockIndex == 1)
            {
                gameInit.getFreeRoamState().setMessage(gameInit.getMessageBlockFactory().getObjectBlock(type).getMessage(messageBlockIndex)); // add key after
                gameInit.getFreeRoamState().setOptions(gameInit.getMessageBlockFactory().getObjectBlock(type).getOptions()[messageBlockIndex]);
                gameInit.getFreeRoamState().setParsedMessage(gameInit.getMessageBlockFactory().getObjectBlock(type).getParsedMessage(messageBlockIndex));
            }
        }

        public override void initialize()
        {
            if (orientation == 0)
            {
                animation.setNewAnimation(0);
            }
            else
            {
                animation.setNewAnimation(1);
            }
        }
    }
}
