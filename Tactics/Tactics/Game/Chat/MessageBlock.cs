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
        private List<int> items;
        private List<List<string>> parsedMessages;

        public MessageBlock()
        {
            messages = new List<string>();
            options = new List<List<string>>();
            destinations = new List<List<int>>();
            items = new List<int>();
            parsedMessages = new List<List<string>>();
        }

        public void giveItem(Bag bag, int index)
        {
        }

        public void addItem(int item)
        {
            items.Add(item);
        }

        public void addMessage(string message, List<int> destinations, List<string> options)
        {
            this.messages.Add(message);
            this.destinations.Add(destinations);
            this.options.Add(options);
            parseMessage(message);
        }

        private void parseMessage(string message)
        {
            List<string> parsedString = new List<string>();
            int lastIndex = 0;

            for (int j = 0; j < message.Length; j++)
            {
                if (j == message.Length - 1 || message[j] == ' ')
                {
                    parsedString.Add(message.Substring(lastIndex, j - lastIndex + 1));
                    lastIndex = j + 1;
                }
            }

            parsedMessages.Add(parsedString);
        }

        public List<List<string>> getParsedMessages()
        {
            return parsedMessages;
        }

        public List<string> getParsedMessage(int message)
        {
            return parsedMessages[message];
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
