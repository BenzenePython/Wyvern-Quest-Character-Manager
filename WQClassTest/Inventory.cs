using System;
using System.Collections.Generic;
using System.Text;

namespace WQClassTest
{
    class Inventory
    {
        private Dictionary<string, string> names = new Dictionary<string, string>();
        private Dictionary<string, string> descriptions = new Dictionary<string, string>();
        private Dictionary<string, int> quantities = new Dictionary<string, int>();
        private Dictionary<string, bool> equipped = new Dictionary<string, bool>();

        public Inventory() { ; }
        public Inventory(Item item)
        {
            addItem(item);
        }
        public Inventory(Item item, int quantity)
        {
            addItem(item, quantity);
        }
        public Inventory(params Item[] items)
        {
            foreach(Item item in items)
            {
                addItem(item);
            }
        }

        public void addItem(Item item)
        {
            names.Add(item.getName(), item.getName());
            descriptions.Add(item.getName(), item.getDescription());
            quantities.Add(item.getName(), 1);
            equipped.Add(item.getName(), item.isEquipped());
        }
        public void addItem(Item item, int quantity)
        {
            names.Add(item.getName(), item.getName());
            descriptions.Add(item.getName(), item.getDescription());
            quantities.Add(item.getName(), quantity);
            equipped.Add(item.getName(), item.isEquipped());
        }
        //remove or add some of an item, but not affect the entire entry
        public string adjustItem(int newQuantity, Item item)
        {
            quantities[item.getName()] = newQuantity;
            return ("The new quantity is " + newQuantity);
        }
        public string adjustItem(int newQuantity, string itemName)
        {
            if (names.GetValueOrDefault(itemName, "NameNotFound").Equals("NameNotFound"))
                return "This item was not found.";
            else
            {
                quantities[itemName] = newQuantity;
                return ("The new quantity is " + newQuantity);
            }
        }
        //completely remove an item entry
        public string removeitem(Item item)
        {
            string name = item.getName();

            names.Remove(name);
            descriptions.Remove(name);
            quantities.Remove(name);
            equipped.Remove(name);

            return "Item has been removed.";
        }
        public string removeItemByName(string name)
        {
            names.Remove(name);
            descriptions.Remove(name);
            quantities.Remove(name);
            equipped.Remove(name);

            return "Item has been removed.";
        }
        public string updateItem(Item item, string newName)
        {
            if (names.ContainsKey(item.getName()))
            {
                names[item.getName()] = newName;
                return "item updated.";
            }
            else
                return "this item was not present.";
        }
        public string updateItem(Item item, string newName, string newDescription)
        {
            if (names.ContainsKey(item.getName()))
            {
                names[item.getName()] = newName;
                descriptions[item.getName()] = newDescription;
                return "item updated.";
            }
            else
                return "this item was not present.";
        }

        public Item GetItemByName(string name)
        {
            string itemName = names.GetValueOrDefault(name, "NameNotFound");
            if (itemName.Equals("NameNotFound"))
                return new Item("Name not Found");
            else
                return new Item(itemName, descriptions.GetValueOrDefault(name), equipped.GetValueOrDefault(name));
        }

        public void Equip(string itemName) { equipped[itemName] = true; }
        public void Dequip(string itemName) { equipped[itemName] = false; }
        public void changeEquip(Item item) { equipped[item.getName()] = item.isEquipped(); }
    }
}
