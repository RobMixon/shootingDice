using System;
using System.Collections.Generic;

namespace ShootingDice {
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player {

        List<string> TauntList = new List<string> {
            "You suck",
            "nerd!",
            "super nerd!",
            "suck it nerd!",
            "NERD",
            "I bet your mom thinks you are a nerd",
            "nice shirt... nerd"
        };
        public override int Roll () {
            // Return a random number between 1 and DiceSize
            int roll = new Random ().Next (DiceSize) + 1;
            Console.WriteLine ($"{Name} says {TauntList[roll]}");
            return roll;
        }

    }
}