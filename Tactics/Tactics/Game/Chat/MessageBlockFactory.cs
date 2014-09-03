using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tactics.Game.Chat
{
    class MessageBlockFactory
    {
        private List<MessageBlock> objectBlocks;
        private List<MessageBlock> currentCharacterBlocks;

        public MessageBlockFactory()
        {
            objectBlocks = new List<MessageBlock>();
            currentCharacterBlocks = new List<MessageBlock>();

            createObjectBlocks();
        }

        public List<MessageBlock> getObjectBlocks()
        {
            return objectBlocks;
        }

        public MessageBlock getObjectBlock(int index)
        {
            return objectBlocks[index];
        }

        private void createObjectBlocks()
        {
        }

        public List<MessageBlock> getCurrentCharacterBlocks()
        {
            return currentCharacterBlocks;
        }

        public MessageBlock getCurrentCharacterBlock(int index)
        {
            return currentCharacterBlocks[index];
        }

        public void createRegionCharacterBlocks(int region)
        {
            if (region == 0)
            {
            }
        }
    }
}
