using System;
using System.Collections.Generic;
using System.Text;

namespace WQClassTest
{
    class Character
    {
        //Character info
        private string Name;
        private string Race;
        private string Class;
        private int Level = 1;
        private int Experience = 0;
        //Stats
        private int Health;
        private int Stamina;
        private int Casts;
        private string ArmorClass;
        //Attributes
        private int Strength = 5;
        private int Constitution = 5;
        private int Dexterity = 5;
        private int Intelligence = 5;
        private int Wisdom = 5;
        private int Fortitude = 5;
        //Generalities, Specialties, & Skills
        private string[] Generalities = new string[3];
        private Dictionary<string, int> Specialties = new Dictionary<string, int>(5);
        private Dictionary<string, int> Skills = new Dictionary<string, int>();
        //inventory - made public for specific character use
        public Inventory inventory = new Inventory();

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
        
        //get set name
        //get set race
        //get set class
        //get set level
        //get set experience/level-up
        //get set hp/sp
        //get casts / auto-set cast by level
        //get set ac
        //get set attributes with case structure
        //get set gens
        //get set specs
        //get set skills
    }
}
