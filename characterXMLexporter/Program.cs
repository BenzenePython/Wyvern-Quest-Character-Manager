using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace characterXMLexporter
{
    class Program
    {
        static void Main(string[] args)
        {
            Character Arcon = new Character("Arcon", "Human Half-Elf", "Hero", 20);
            Console.WriteLine("Name the file. Do not include the file extension.");
            string filename = Console.ReadLine();

            XMLWrite(Arcon, filename);

            Console.WriteLine("where did it go...?");
        }

        static void XMLWrite(Character PC, string filename)
        {
            string fFilename;

            if (!filename.Contains(".xml"))
                fFilename = filename + ".xml";
            else
                fFilename = filename;
            
            using (XmlWriter writer = XmlWriter.Create(fFilename))
            {
                writer.WriteStartElement("Character");
                    writer.WriteElementString("Name", PC.getName());
                    writer.WriteElementString("Race", PC.getRace());
                    writer.WriteElementString("Class", PC.getClass());
                    writer.WriteElementString("Level", PC.getLevel().ToString());
                    writer.WriteElementString("XpPool", PC.getExp().ToString());
                writer.WriteEndElement();
                writer.Flush();
            }
        }
    }

    public class Character
    {
        //initialize standard stats for testing xml serialization
        private string Name;
        private string Race;
        private string Class;
        private int Level = 1;
        private int Experience = 0;

        //Constructors, overloaded to overwrite defaults
        public Character()
        {
            Name = "This didn't work";
            Race = "How you";
            Class = "wanted to";
            Level = 69;
            Experience = 13;
        }
        public Character(string Name, string Race, string Class)
        {
            this.Name = Name;
            this.Race = Race;
            this.Class = Class;
        }
        public Character(string Name, string Race, string Class, int Level)
        {
            this.Name = Name;
            this.Race = Race;
            this.Class = Class;
            this.Level = Level;
        }
        //generally players will not be at level 1 and start with XP. If they are making a level 1 character, they can add xp post-creation.
        public Character(string Name, string Race, string Class, int Level, int Experience)
        {
            this.Name = Name;
            this.Race = Race;
            this.Class = Class;
            this.Level = Level;
            this.Experience = Experience;
        }

        public string getName() { return Name; }
        public string getRace() { return Race; }
        public string getClass() { return Class; }
        public int getLevel() { return Level; }
        public int getExp() { return Experience; }
    }
}
