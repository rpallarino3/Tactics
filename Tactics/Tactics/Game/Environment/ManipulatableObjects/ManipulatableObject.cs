using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;

using Tactics.Game.Environment.ManipulatableObjects.Animations;
using Tactics.Game.Characters;
using Tactics.Game.Chat;

namespace Tactics.Game.Environment.ManipulatableObjects
{
    abstract class ManipulatableObject
    {
        protected int type;
        protected int xLoc;
        protected int yLoc;
        protected ObjectAnimation animation;
        protected bool finishedActivating;

        protected bool upInteract;
        protected bool downInteract;
        protected bool rightInteract;
        protected bool leftInteract;

        protected bool transitionReady;
        protected bool chatWindow;

        protected bool item;

        protected int messageBlockIndex;
        protected int optionIndex;

        protected Vector2 drawOffset;

        public abstract void activate(GameInit gameInit, Character interactingCharacter, int activationCode);
        public abstract void continueActivation(GameInit gameInit, Character interactingCharacter);
        public abstract void finishActivation(GameInit gameInit);
        public abstract void talk(GameInit gameInit);
        public abstract void initialize();

        public Vector2 getDrawOffset()
        {
            return drawOffset;
        }

        public bool giveItem()
        {
            return item;
        }

        public void noItem()
        {
            item = false;
        }

        public int getType()
        {
            return type;
        }

        public bool isTransitionReady()
        {
            return transitionReady;
        }

        public bool showChatWindow()
        {
            return chatWindow;
        }

        public int getXLoc()
        {
            return xLoc;
        }

        public int getYLoc()
        {
            return yLoc;
        }

        public ObjectAnimation getObjectAnimation()
        {
            return animation;
        }

        public bool isUpInteract()
        {
            return upInteract;
        }

        public bool isDownInteract()
        {
            return downInteract;
        }

        public bool isRightInteract()
        {
            return rightInteract;
        }

        public bool isLeftInteract()
        {
            return leftInteract;
        }

        public bool isFinishedActivating()
        {
            return finishedActivating;
        }

        public bool checkForInteract(int direction)
        {
            if (direction == 0)
            {
                return downInteract;
            }
            else if (direction == 1)
            {
                return upInteract;
            }
            else if (direction == 2)
            {
                return leftInteract;
            }
            else if (direction == 3)
            {
                return rightInteract;
            }
            else
            {
                return false;
            }
        }

        public void advanceMessage(GameInit gameInit)
        {
            MessageBlock mb = gameInit.getMessageBlockFactory().getObjectBlock(type);
            int destination = mb.getDestination(messageBlockIndex)[optionIndex];

            if (destination < 0)
            {
                if (destination == -1)
                {
                    chatWindow = false;
                }
                else
                {
                    item = true;
                }
            }
            else
            {
                messageBlockIndex = destination;
                optionIndex = 0;
            }
        }

        public void backAdvanceMessage(GameInit gameInit)
        {
            MessageBlock mb = gameInit.getMessageBlockFactory().getObjectBlock(type);

            if (mb.getOptions(messageBlockIndex).Count == 0)
            {
                advanceMessage(gameInit);
            }
            else
            {
                optionIndex = mb.getOptions(messageBlockIndex).Count - 1;
                advanceMessage(gameInit);
            }
        }

        public void moveUpOptionIndex(GameInit gameInit)
        {
            MessageBlock mb = gameInit.getMessageBlockFactory().getObjectBlock(type);

            if (mb.getOptions(messageBlockIndex).Count == 0)
            {
                optionIndex = 0;
            }
            else
            {
                if (optionIndex == 0)
                {
                    optionIndex = mb.getOptions(messageBlockIndex).Count - 1;
                }
                else
                {
                    optionIndex--;
                }
            }
        }

        public void moveDownOptionIndex(GameInit gameInit)
        {
            MessageBlock mb = gameInit.getMessageBlockFactory().getObjectBlock(type);

            if (mb.getOptions(messageBlockIndex).Count == 0)
            {
                optionIndex = 0;
            }
            else
            {
                if (optionIndex == mb.getOptions(messageBlockIndex).Count - 1)
                {
                    optionIndex = 0;
                }
                else
                {
                    optionIndex++;
                }
            }
        }
    }
}
