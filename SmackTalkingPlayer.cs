using System;

namespace ShootingDice {
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player {
        public string Taunt { get; } = "Suck it NERD!";

        public override int Roll () {
            Console.WriteLine ($"{Name} says: {Taunt}");
            // Return a random number between 1 and DiceSize
            return new Random ().Next (DiceSize) + 1;
        }

    }
}