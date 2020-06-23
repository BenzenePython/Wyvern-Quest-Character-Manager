namespace WQClassTest
{
    class Item
    {
        private string name;
        private string description;
        private bool Equipped = false;

        public Item(string name)
        {
            this.name = name;
            description = "No description available.";
        }
        public Item(string name, string description)
        {
            this.name = name;
            this.description = description;
        }
        public Item(string name, string description, bool equip)
        {
            this.name = name;
            this.description = description;
            Equipped = equip;
        }

        public void setName(string name) { this.name = name; }
        public void setDescription(string description) { this.description = description; }

        public string getName() { return name; }
        public string getDescription() { return description; }

        public void Equip() { Equipped = true; }
        public void Remove() { Equipped = false; }
        public bool isEquipped() { return Equipped; }
    }
}
