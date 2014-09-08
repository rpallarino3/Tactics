using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Tactics.Game.Environment;

namespace Tactics.Game
{
    class FreeRoamState
    {
        private int currentRegion;
        private int currentZone;
        private bool chatWindow;
        private string message;
        private List<string> options;
        private List<string> parsedMessage;


        private List<Zone> currentZones;

        public FreeRoamState()
        {
        }

        public bool showChatWindow()
        {
            return chatWindow;
        }

        public void setParsedMessage(List<string> message)
        {
            parsedMessage = message;
        }

        public void setChatWindow(bool b)
        {
            chatWindow = b;
        }

        public void setMessage(string message)
        {
            this.message = message;
        }

        public void setOptions(List<string> options)
        {
            this.options = options;
        }

        public List<string> getParsedMessage()
        {
            return parsedMessage;
        }

        public string getMessage()
        {
            return message;
        }

        public List<string> getOptions()
        {
            return options;
        }

        public void setCurrentZones(List<Zone> newZones)
        {
            currentZones = newZones;
        }

        public List<Zone> getCurrentZones()
        {
            return currentZones;
        }

        public int getCurrentRegion()
        {
            return currentRegion;
        }

        public void setCurrentRegion(int region)
        {
            currentRegion = region;
        }

        public Zone getCurrentZone()
        {
            return currentZones[currentZone];
        }

        public int getCurrentZoneNumber()
        {
            return currentZone;
        }

        public void setCurrentZone(int zone)
        {
            currentZone = zone;
        }
    }
}
