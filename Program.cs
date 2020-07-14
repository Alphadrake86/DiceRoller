using System;

namespace DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            Die[] dice = new Die[15];
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = new Die();
            }

            foreach (Die die in dice)
            {
                Console.WriteLine(die.value);
            }
        }
    }
}
