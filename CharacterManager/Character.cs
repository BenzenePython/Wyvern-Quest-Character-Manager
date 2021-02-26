using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterManager
{
    class Character
    {
        private String charName;
        private String charClass;
        /*private String charRaceName;
        private String charPrideName;
        public Race(charRaceName, charPrideName) charRace;*/

        private String[] charGens = new string[3];
        private Dictionary<String, int> charSpecs = new Dictionary<String,int>(5);
        private Dictionary<String, int> charSkills = new Dictionary<string, int>(70); //max skill points is 62 at 1 point per skill, no more than 62 skills. added 8 for special case buffers.
        private Dictionary<String, int> charAttributes = new Dictionary<string, int>(6)
            {
                {"Strength", 5 },
                {"Constitution", 5 },
                {"Dexterity", 5 },
                {"Intelligence", 5 },
                {"Fortitude", 5 },
                {"Wisdom", 5 }
            };

        private int charLevel = 1;
        private int charPool = 0;
        private int charSkillPoints = 6;
        private int charAttributePoints = 5;

        private int charHealth;
        private int charStamina;
        private int charCast;
        private String charAC;
        private int charDef;
        //if value is negative, generate rand between -1 and -8
        private readonly Dictionary<String, int> armorClasses = new Dictionary<String, int>(8)
        {
            {"Naked", -8 },
            {"Super-Light", -4 },
            {"Light", 2 },
            {"Medium-Light", 4 },
            {"Medium", 6 },
            {"Medium-Heavy", 8 },
            {"Heavy", 10 },
            {"Super-Heavy", 12 }
        };

        //TODO: constructor
        //TODO: level up method
        //TODO: auto-calculate hp/sp
        //TODO: determine casts
        //TODO: 
    }


}
