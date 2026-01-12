using System;
using System.Collections.Generic;
using System.Text;

namespace Mission_2_Assignment
{
    internal class DiceRoll
    {

        int roll1;
        int roll2;
        int[] results = new int[13];

        public int[] GetRolls(int num)
        {
            for (int i = 0; i < num; i++)
            {
                roll1 = Random.Shared.Next(1, 7);
                roll2 = Random.Shared.Next(1, 7);

                int sum = roll1 + roll2;

                results[sum]++;

            }
            return results;
        }   


    }
}
