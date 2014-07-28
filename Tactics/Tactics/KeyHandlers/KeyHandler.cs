using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework.Input;

namespace Tactics.KeyHandlers
{
    class KeyHandler
    {
        private Keybinds keybinds;
        private KeyboardState previousState;

        private int moveUpTime;
        private int moveDownTime;
        private int moveRightTime;
        private int moveLeftTime;

        private bool actionReady;
        private bool backReady;
        private bool m1Ready;
        private bool m2Ready;

        private bool leftBump;
        private bool rightBump;

        public KeyHandler()
        {
            keybinds = new Keybinds();
            previousState = new KeyboardState();
            moveUpTime = 0;
            moveDownTime = 0;
            moveRightTime = 0;
            moveLeftTime = 0;

            actionReady = false;
            backReady = false;
            m1Ready = false;
            m2Ready = false;

            leftBump = false;
            rightBump = false;
        }


        public void updateKeys(KeyboardState keyState)
        {
            checkMoveKeys(keyState);
            checkReadies(keyState);
            checkBumpers(keyState);
            previousState = keyState;
        }

        private void checkBumpers(KeyboardState keyState)
        {
            if (keyState.IsKeyDown(keybinds.getKeybinds()["LEFTBUMP"]))
            {
                leftBump = true;
            }
            else
            {
                leftBump = false;
            }

            if (keyState.IsKeyDown(keybinds.getKeybinds()["RIGHTBUMP"]))
            {
                rightBump = true;
            }
            else
            {
                rightBump = false;
            }
        }

        private void checkReadies(KeyboardState keyState)
        {
            if (keyState.IsKeyDown(keybinds.getKeybinds()["ACTION"]) && !previousState.IsKeyDown(keybinds.getKeybinds()["ACTION"]))
            {
                actionReady = true;
            }
            else if (!keyState.IsKeyDown(keybinds.getKeybinds()["ACTION"]))
            {
                actionReady = false;
            }

            if (keyState.IsKeyDown(keybinds.getKeybinds()["BACK"]) && !previousState.IsKeyDown(keybinds.getKeybinds()["BACK"]))
            {
                backReady = true;
            }
            else if (!keyState.IsKeyDown(keybinds.getKeybinds()["BACK"]))
            {
                backReady = false;
            }

            if (keyState.IsKeyDown(keybinds.getKeybinds()["MENU1"]) && !previousState.IsKeyDown(keybinds.getKeybinds()["MENU1"]))
            {
                m1Ready = true;
            }
            else if (!keyState.IsKeyDown(keybinds.getKeybinds()["MENU1"]))
            {
                m1Ready = false;
            }

            if (keyState.IsKeyDown(keybinds.getKeybinds()["MENU2"]) && !previousState.IsKeyDown(keybinds.getKeybinds()["MENU2"]))
            {
                m2Ready = true;
            }
            else if (!keyState.IsKeyDown(keybinds.getKeybinds()["MENU2"]))
            {
                m2Ready = false;
            }
        }

        private void checkMoveKeys(KeyboardState keyState)
        {
            if (keyState.IsKeyDown(keybinds.getKeybinds()["MOVEUP"]))
            {
                moveUpTime++;
            }
            else
            {
                moveUpTime = 0;
            }

            if (keyState.IsKeyDown(keybinds.getKeybinds()["MOVEDOWN"]))
            {
                moveDownTime++;
            }
            else
            {
                moveDownTime = 0;
            }

            if (keyState.IsKeyDown(keybinds.getKeybinds()["MOVERIGHT"]))
            {
                moveRightTime++;
            }
            else
            {
                moveRightTime = 0;
            }

            if (keyState.IsKeyDown(keybinds.getKeybinds()["MOVELEFT"]))
            {
                moveLeftTime++;
            }
            else
            {
                moveLeftTime = 0;
            }
        }

        public void useAction(string key)
        {
            if (key == "ACTION")
            {
                actionReady = false;
            }
            else if (key == "BACK")
            {
                backReady = false;
            }
            else if (key == "MENU1")
            {
                m1Ready = false;
            }
            else if (key == "MENU2")
            {
                m2Ready = false;
            }
        }

        public int getUpTime()
        {
            return moveUpTime;
        }

        public int getDownTime()
        {
            return moveDownTime;
        }

        public int getRightTime()
        {
            return moveRightTime;
        }

        public int getLeftTime()
        {
            return moveLeftTime;
        }

        public bool isActionReady()
        {
            return actionReady;
        }

        public bool isBackReady()
        {
            return backReady;
        }

        public bool isM1Ready()
        {
            return m1Ready;
        }

        public bool isM2Ready()
        {
            return m2Ready;
        }

        public bool isLeftBumpDown()
        {
            return leftBump;
        }

        public bool isRightBumDown()
        {
            return rightBump;
        }

        public Keybinds getKeybinds()
        {
            return keybinds;
        }
    }
}
