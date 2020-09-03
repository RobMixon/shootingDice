using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice {
    class Program {
        static void Main (string [] args) {
            SmackTalkingPlayer player1 = new SmackTalkingPlayer ();
            player1.Name = "Chad";

            OneHigherPlayer player2 = new OneHigherPlayer ();
            player2.Name = "Rob";

            player2.Play (player1);

            Console.WriteLine ("-------------------");

            HumanPlayer player3 = new HumanPlayer ();
            player3.Name = "Todd";

            player3.Play (player2);

            Console.WriteLine ("-------------------");

            Player large = new LargeDicePlayer ();
            large.Name = "Napoleon the SMALL";

            player1.Play (large);

            Console.WriteLine ("-------------------");

            CreativeSmackTalkingPlayer player4 = new CreativeSmackTalkingPlayer ();
            player4.Name = "Dan";

            player4.Play (large);

            Console.WriteLine ("-------------------");

            SoreLoserPlayer player5 = new SoreLoserPlayer ();
            player5.Name = "Greg";

            player5.Play (player4);

            Console.WriteLine ("-------------------");

            UpperHalfPlayer player6 = new UpperHalfPlayer ();
            player6.Name = "Kris";

            player6.Play (player4);

            Console.WriteLine ("-------------------");

            List<Player> players = new List<Player> () {
                player1,
                player2,
                player3,
                player4,
                player5,
                player6,
                large
            };

            PlayMany (players);
        }

        static void PlayMany (List<Player> players) {
            Console.WriteLine ();
            Console.WriteLine ("Let's play a bunch of times, shall we?");

            // We "order" the players by a random number
            // This has the effect of shuffling them randomly
            Random randomNumberGenerator = new Random ();
            List<Player> shuffledPlayers = players.OrderBy (p => randomNumberGenerator.Next ()).ToList ();

            // We are going to match players against each other
            // This means we need an even number of players
            int maxIndex = shuffledPlayers.Count;
            if (maxIndex % 2 != 0) {
                maxIndex = maxIndex - 1;
            }

            // Loop over the players 2 at a time
            for (int i = 0; i < maxIndex; i += 2) {
                Console.WriteLine ("-------------------");

                // Make adjacent players play noe another
                Player player1 = shuffledPlayers [i];
                Player player2 = shuffledPlayers [i + 1];
                player1.Play (player2);
            }
        }
    }
}