using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace tpCombat.fighter
{
   public class fighter : MonoBehaviour
    {
        protected int hp = 20;
        protected int attack = 10;

        public bool takeDamage(int damage)
        {
            this.hp -= damage;
            return hp < 0;
        }
        public int getAttackStrength()
        {
            return this.attack;
        }
    }
}
