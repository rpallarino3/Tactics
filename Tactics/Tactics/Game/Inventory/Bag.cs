using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tactics.Game.Inventory
{
    class Bag
    {
        private List<string> keyNames;
        private List<bool> ownedKeys;

        private List<string> reagentNames;
        private List<int> ownedReagents;

        private List<string> displayedReagentOrder;
        private List<int> displayedReagents;

        private List<string> consumableNames;
        private List<int> ownedConsumables;

        private List<string> displayedConsumableOrder;
        private List<int> displayedConsumables;

        private List<string> keyItemNames;
        private List<bool> ownedKeyItems;

        private int money;

        public Bag()
        {
            keyNames = new List<string>();
            ownedKeys = new List<bool>();
            reagentNames = new List<string>();
            ownedReagents = new List<int>();
            displayedReagentOrder = new List<string>();
            displayedReagents = new List<int>();
            consumableNames = new List<string>();
            ownedConsumables = new List<int>();
            displayedConsumableOrder = new List<string>();
            displayedConsumables = new List<int>();
            keyItemNames = new List<string>();
            ownedKeyItems = new List<bool>();
            money = 0;

            fillLists();
        }

        private void fillLists()
        {
        }

        public List<string> getKeyNames()
        {
            return keyNames;
        }

        public string getKeyName(int keyID)
        {
            return keyNames[keyID];
        }

        public List<bool> getOwnedKeys()
        {
            return ownedKeys;
        }

        public bool doesOwnKey(int keyID)
        {
            return ownedKeys[keyID];
        }

        public void obtainedKey(int keyID)
        {
            ownedKeys[keyID] = true;
        }

        public List<string> getReagentNames()
        {
            return reagentNames;
        }

        public string getReagentName(int reagentID)
        {
            return reagentNames[reagentID];
        }

        public List<int> getOwnedReagents()
        {
            return ownedReagents;
        }

        public int getOwnedReagent(int reagentID)
        {
            return ownedReagents[reagentID];
        }

        public void obtainReagent(int reagentID, int number)
        {
            if (ownedReagents[reagentID] + number > 99)
            {
                ownedReagents[reagentID] = 99;
            }
            else
            {
                ownedReagents[reagentID] += number;
            }
        }

        public void useReagent(int reagentID, int number)
        {
            if (ownedReagents[reagentID] - number < 0)
            {
                ownedReagents[reagentID] = 0;
            }
            else
            {
                ownedReagents[reagentID] -= number;
            }
        }

        public List<string> getConsumableNames()
        {
            return consumableNames;
        }

        public string getConsumableName(int consumableID)
        {
            return consumableNames[consumableID];
        }

        public List<int> getOwnedConsumables()
        {
            return ownedConsumables;
        }

        public int getOwnedConsumable(int consumableID)
        {
            return ownedConsumables[consumableID];
        }

        public void obtainConsumable(int consumableID, int number)
        {
            if (ownedConsumables[consumableID] + number > 99)
            {
                ownedConsumables[consumableID] = 99;
            }
            else
            {
                ownedConsumables[consumableID] += number;
            }
        }

        public void useConsumable(int consumableID, int number)
        {
            if (ownedConsumables[consumableID] - number < 0)
            {
                ownedConsumables[consumableID] = 0;
            }
            else
            {
                ownedConsumables[consumableID] -= number;
            }
        }

        public List<string> getKeyItemNames()
        {
            return keyItemNames;
        }

        public string getKeyItemName(int keyItemID)
        {
            return keyItemNames[keyItemID];
        }

        public List<bool> getOwnedKeyItems()
        {
            return ownedKeyItems;
        }

        public bool getOwnedKeyItem(int keyItemID)
        {
            return ownedKeyItems[keyItemID];
        }

        public void obtainKeyItem(int keyItemID)
        {
            ownedKeyItems[keyItemID] = true;
        }

        public int getMoney()
        {
            return money;
        }

        public void addMoney(int number)
        {
            if (money + number > 999999)
            {
                money = 999999;
            }
            else
            {
                money += number;
            }
        }

        public bool useMoney(int number)
        {
            if (money - number < 0)
            {
                return false;
            }
            else
            {
                money -= number;
                return true;
            }
        }
    }
}
