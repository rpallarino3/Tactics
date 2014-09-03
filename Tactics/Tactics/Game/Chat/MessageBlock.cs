using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Tactics.Game.Inventory;

namespace Tactics.Game.Chat
{
    class MessageBlock
    {
        private List<string> messages;
        private List<List<string>> options;
        private List<List<int>> destinations;
        private List<Item> items;

        public MessageBlock()
        {
            messages = new List<string>();
            options = new List<List<string>();
            destinations = new List<List<int>>();
            items = new List<Item>();
        }

        public void giveItem(Bag bag, int index)
        {
        }

        public void addItem(Item item)
        {
            items.Add(item);
        }

        public void addMessage(string message, List<int> destinations, List<string> options)
        {
            this.messages.Add(message);
            this.destinations.Add(destinations);
            this.options.Add(options);
        }

        public List<string> getMessages()
        {
            return messages;
        }

        public string getMessage(int index)
        {
            return messages[index];
        }

        public List<List<string>> getOptions()
        {
            return options;
        }

        public List<string> getOptions(int index)
        {
            return options[index];
        }

        public List<List<int>> getDestinations()
        {
            return destinations;
        }

        public List<int> getDestination(int index)
        {
            return destinations[index];
        }
    }
}
