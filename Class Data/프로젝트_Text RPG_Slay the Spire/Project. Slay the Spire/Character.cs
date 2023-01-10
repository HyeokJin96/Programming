using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Project._Slay_the_Spire
{
    public class Character
    {
        public string NAME { get; private set; }
        public int maxHP { get; private set; }
        public int HP { get; private set; }
        public int STR { get; private set; }
        public int DEX { get; private set; }
        public int INT { get; private set; }
        public int WIS { get; private set; }
        public int GOLD { get; private set; }
        public int LUCK { get; private set; }

        public void SetupPlayerCharacter(string NAME_, int HP_, int maxHP_, int STR_, int DEX_, int INT_, int WIS_, int LUCK_, int GOLD_)
        {
            NAME = NAME_;
            HP = HP_;
            maxHP = maxHP_;
            STR = STR_;
            DEX = DEX_;
            INT = INT_;
            WIS = WIS_;
            LUCK = LUCK_;
            GOLD = GOLD_;
        }
    }
}
