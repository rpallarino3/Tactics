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
            objectBlocks.Add(new MessageBlock());

            MessageBlock doorBlock = new MessageBlock();
            List<int> destination = new List<int>();
            destination.Add(-1);
            List<string> option = new List<string>();
            doorBlock.addMessage("It's locked.", destination, option);

            objectBlocks.Add(doorBlock);
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
