using System;
using System.Collections.Generic;
using System.Xml;

namespace characterXMLimporter
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static Character importXML(string filePath)
        {
            /*string Name;
            string Race;
            string Class;
            int Level;
            int Experience;*/
            //storage of values in case structure
            Dictionary<string, string> characterValues = new Dictionary<string, string>();

            using (XmlReader reader = XmlReader.Create(@filePath))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        switch (reader.Name.ToString())
                        {
                            case "Name":
                                Console.WriteLine("Name: " + reader.ReadElementContentAsString());
                                characterValues.Add("Name", reader.ReadElementContentAsString());
                                break;
                            case "Race":
                                Console.WriteLine("Race: " + reader.ReadElementContentAsString());
                                characterValues.Add("Race", reader.ReadElementContentAsString());
                                break;
                            case "Class":
                                Console.WriteLine("Class: " + reader.ReadElementContentAsString());
                                characterValues.Add("Class", reader.ReadElementContentAsString());
                                break;
                            case "Level":
                                Console.WriteLine("Level: " + reader.ReadElementContentAsString());
                                characterValues.Add("Level", reader.ReadElementContentAsString());
                                break;
                            case "Experience":
                                Console.WriteLine("Experience: " + reader.ReadElementContentAsString());
                                characterValues.Add("Experience", reader.ReadElementContentAsString());
                                break;
                        }
                    }
                }
                //in the real program, we will need some form of error handling here, as there are a lot of bugs in this current line.
                //for testing purposes, we will assume nothing will go wrong.
                return new Character(characterValues.GetValueOrDefault("Name"), characterValues.GetValueOrDefault("Race"), characterValues.GetValueOrDefault("Class"),
                    Int32.Parse(characterValues.GetValueOrDefault("Level")), Int32.Parse(characterValues.GetValueOrDefault("Experience")));
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
        //must add a constructor using a character object
        public Character(Character character)
        {
            Name = character.getName();
            Race = character.getRace();
            Class = character.getClass();
            Level = character.getLevel();
            Experience = character.getExp();
        }

        public string getName() { return Name; }
        public string getRace() { return Race; }
        public string getClass() { return Class; }
        public int getLevel() { return Level; }
        public int getExp() { return Experience; }
    }
}
