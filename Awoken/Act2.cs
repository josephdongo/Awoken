using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Awoken
{
    public class Act2
    {

        public static string Act2Prologue()
        {
            return ("You suddenly here a loud explosion and the room fills with smoke.  As the blast smoke clears, you see a cloaked figure with a wicked smile." +
                    "Well hello friend!\" He waddles over to you slowly as his head twists to the left. \"What are you doing on this fine and beautiful day!\"
                    "You still couldn’t clearly see his face, but you could definitely tell that this guy wasn’t all there. He held out his hand and gave an exaggerated bow." +
                    "\"My name is More Dread, and I have come to take over the planet.");
        }

        //if morality > 0

        public static string Act2PrologueGood()
        {
            return ("You growl and try to punch him. He dodges and laughs at your pathetic attempt to kill him." +
              "\"Oh how wonderful! Is this how you introduce yourselves here? I’ll join in on the fun!\"" +
              "He slaps you once and you fly straight into a wall. He waddles over to you and stares into your misery." +
              "\"Well wasn’t that the introduction. You look like you had more fun with that than I did! Its nice to have meet you, but I must be on my way.\"" +
              "He waddles off and flies into the sunset. You clench your fist and swear that you will make him pay.");
        }

        public static string Act2PrologueEvil()
        {
            return ("You jump up and down and smile as you tell him that you want to achieve the same thing. You exclaim that after all that you’ve done, you don’t see why you wouldn’t strive for that." +
            "The man’s grin widens as he picks you up like a spoiled child. \"Well well! That’s the spirit! Would you like to join me? I will have free cookies! Shiny nukes!\"" +
            "You both turn and throw a bomb at the damaged building. The flames and debris fly everywhere as you both walk epically toward the man’s ship." +
            "\"You're gonna love the ship! It’s got more cannons than the flying dutchman!\"" +
            "You both walk towards the ship and start your epic quest to ruin the lives of probably everybody.");
        }

        public static string Act2GoodRoute()
        {
            return ("You chase after him and you see him flying over new york city. He destroys buildings and laughs maniacally as people flee in terror." +
            "Do you?" +
            "\n\n\tA) Defeat him?" +
            "\n\n\tB) Let him go?");
        }

        public static string Act2GoodRouteGood()
        {
            return ("You shoot an energy blast at him and he falls to the ground. The earth is saved!" +
            "You Win!");
        }

        public static string Act2GoodRouteEvil()
        {
            return ("He just keeps destroying the world and you get hit by a blast and fall dead." +
            "You lose. Game Over.");
        }

        public static string Act2EvilRoute()
        {
            return ("As you make your way through the smoke and debris towards More Dread’s ship, you try to catch a glimpse of this mysterious figure's face." +
            "All that you can see inside of his hood are more shadows, however.  After a couple of minutes of walking, you can begin to make out an ominous shape on the horizon." +
            "The smoke begins to clear and you can clearly see the outline of an enormous spaceship." +
            "More Dread turns his face towards you and a horrific stench fills your nostrils. Thinking quickly, you plot your next move." +
            "\n\n\t)Choice A) \"What am I doing?? I can't kill millions of innocents!  I’ve got to make an escape!\"" +
            "\n\n\tChoice B) \"Taking over the world sounds fun!\"");
        }

        public static string Act2EvilRouteGood()
        {
            return ("\"Hey, More Dread…\" you begin, \"I'm really pumped to start our world domination, but I totally spaced and forgot to feed my hedgehog!  I’ll just be right back...\"" +
            "More Dread turns his horrible face towards you and you reach out for a feeble attack. Your attack fails, however, and you hear a shrill cackle coming from the dark folds of his hood." +
            "A pale hand emerges from his clock and he lazily flicks your nose.  You collapse to the ground with the sheer force of the blow, briefly losing consciousness." +
            "You glance up to see More Dream reach back into his cloak and pull out a single playing card." +
            "You suddenly feel an invisible hand clutch your soul and you are irresistibly sucked closer and closer towards the card.  The world around you vanishes into shadows." +
            "\n\nYou have been banished to the shadow realm."
        "Game Over.");
        }

        public static string Act2EvilRouteEvil()
        {
            return ("You go on a glorious, bloody rampage and wreck havoc upon all of humanity.  After a particularly vicious battle, More Dread begins to gloat." +
            "\"I've been waiting for this day for thousands of years!  And finally, today, you awoke and opened up a portal for me.\"" +
            "You suddenly lunge for More Dread’s pocket." +
            "Your hand returns with a small piece of cardboard.  You glance down briefly and see the Queen of Diamonds smiling up at you." +
            "More Dread gives a guttural cry.  You suddenly access memories that you never knew that you had and hold the playing card up to the monster's face like a silver cross." +
            "More Dread screams shrilly as his cloaked figure is sucked into the small card." +
            "Smiling, you pocket the card and return to the console." +
            "\"Now total dominion is mine...\"" +
            "YOU WIN");
        }

    }
}
