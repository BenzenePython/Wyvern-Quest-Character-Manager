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
        private String raceFeat;
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
            raceFeat = chooseFeat(race, pride);
        }

        String getName() { return String.Format(racePride + " " + raceName); }
        String getTalent() { return raceTalent; }
        String getFlaw() { return raceFlaw; }
        String getFeat() { return raceFeat; }

        //TODO: create interactive feat selection
        String chooseFeat(String race, String pride)
        {
            String featChoice;
            Console.WriteLine("Please choose a feat: 1, 2, or 3 -");
            int input = 0; //options 1-3 they choose ; input = userinput - 1
            featChoice = ((feat[race])[pride])[input];
            return featChoice;
        }
    }
}
