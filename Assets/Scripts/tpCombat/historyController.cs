using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace tpCombat.historyController
{
    public class historyController
    {
        public void fight() // called by button
        {
            //p1 attack p2
            strikeBack(false);
        }
        public void defend() // called by button
        {
            //p1 attack p2
            strikeBack(true);
        }

        private void strikeBack(bool isPlayerDefending)
        {
            //p2 attack p1
            //if defending, player take only 20% damage
        }

        public void printHistory(fighter attacker, int damageOutput)
        {
            //change text off text area
        }
    }
}
