using System;

namespace ShootingDice {
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player {
        public override int Roll () {
            Console.WriteLine ("Please enter your desired dice roll");
            int result = Int32.Parse (Console.ReadLine ());
            int whatTheyGet = new Random ().Next (DiceSize) + 1;
            Console.WriteLine ($"Was it a {result}? To bad! you get a {whatTheyGet}");
            return whatTheyGet;
        }
    }
}