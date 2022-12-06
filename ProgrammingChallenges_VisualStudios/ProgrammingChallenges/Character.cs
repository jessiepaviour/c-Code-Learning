using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingChallenges
{
    public class Character
    {
        public string characterName;
        public int maxHP;
        public bool isPlayer;

        public bool isPlayingAttackAnimation;

        public Character(string characterName, int maxHP, bool isPlayer)
        {

        }

        public void Attack(Character defender)
        {
            defender.maxHP -= 1;
        }
    }
}
