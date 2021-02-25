using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterManager
{
    class Race
    {
        private String raceName;
        private String racePride;
        private String raceTalent;
        private String raceFlaw;
        private String[] raceFeat = new String[2];
        //TODO: add race stats
        private Dictionary<String, Dictionary<String, String>> talent = new Dictionary<string, Dictionary<string, string>>();
        private Dictionary<String, Dictionary<String, String>> flaw = new Dictionary<string, Dictionary<string, string>>();
        private Dictionary<String, Dictionary<String, String[]>> feat = new Dictionary<string, Dictionary<string, string[]>>();

        Race(String race, String pride)
        {
            raceName = race;
            racePride = pride;
            raceTalent = (talent[race])[pride];
            raceFlaw = (talent[race])[pride];

        }

        String[] chooseFeat(String race, String pride)
        {
            String[] featChoice = new string[2];
            Console.WriteLine("Please choose a feat: 1, 2, or 3 -");
            featChoice[0] = 
        }
    }
}
