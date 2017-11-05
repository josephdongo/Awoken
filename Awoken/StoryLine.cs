using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Awoken
{
    public class StoryLine
    {
        public static string GameOver()
        {
            return ("YOU HAVE DIED...for reals.\n\nSorry, better luck next time.\n\nWant to try your luck again?");
        }

        public static string YouWin()
        {
            return ("YOU WON...wait, you won?\n\nWe thought the choices were harder than this.\n\nWell, do you want to try your luck again?");
        }

        public static string PrologueHallway()
        {
            return ("After a long day bagging groceries and faking smiles, you come home smelling like a checkout stand." +
                    " Tiredly you look at your watch and check the time. 10:55pm." +
                    " You yawn, take a shower, and lie down in your own bed as you feel the sleep " +
                    "wash over you like a flash flood warning.\nIn the dream, you walk down a long hallway.  You come to a fork in the road." +
                    "Do you..." +
                    "\n\n\tChoice A) Walk to the left, where you sense raw power and energy?" +
                    "\n\n\tChoice B) Walk to the right, where you can sense untold secrets of the universe?");
        }

        public static string PrologueHallwayLeft()
        {
            return ("You reach the end of the hallways and see two doors.  Which do you choose?" +
                "\n\n\tChoice A) The first door looks that has the head of a wolf mounted on it." +
                "\n\tIt looks as if the wolf could still bite into your flesh." +
                "\n\tIts doorknob is completely covered in some sort of saliva." +
                "\n\n\tChoice B) The second door appears to have dried blood staining the oak." +
                "\n\tThe crusty old doorknob looks as if it could probably give you something if you are not careful."

        }


        public static string WakeUpWolf()
        {
            return ("You wake in your bed to find that your sheets have been ripped into the shape of a W." +
                    " You failed art class twice in college, so this masterpiece of texture work couldn’t have been you. Could it?" +
                    " After screaming in shock and fear you run to the mirror to check yourself over for injury." +
                    " To your surprise, you do not see any injuries done, however you notice that your hair seems to have much more length and volume than before." +
                    " You don’t remember using any special hair conditioner. Must be your genetics?" +
                    " You hear a knock at your front door. You scurry over to the living room to check and see who it is." +
                    " It is your neighbor asking for a cup of sugar." +
                    " You slowly open the door as your neighbor looks at you with a shocked face. \"What happened to you?" +
                    " You look like you had one too many on a Halloween night!\" You glance at the person and their measuring cup and you start to mull on your next option." +
                    "\n\n\tChoice A)  Its all good, I'll just play it cool and give them a cup of sugar." +
                    "\n\n\tChoice B) I WILL SLAUGHTER YOU WHERE YOU STAND!");
        }

        public static string WakeUpVamp()
        {
            return ("You wake in your bed to find that your sheets have been untouched and there’s blood all over the head of the bed." +
                    " Unless you had a gash on your head that you can’t feel, you wonder what could have caused there." +
                    " After screaming in shock and fear you run to the mirror to check yourself over for injury." +
                    " To your surprise, you do not see any injuries done, however you notice that your canine teeth live up to their name. They look to be much bigger than any other teeth." +
                    " You hear a knock at your front door. You scurry over to the living room to check and see who it is." +
                    " It is your neighbor asking for a cup of sugar." +
                    " You slowly open the door as your neighbor looks at you with a shocked face. \"What happened to you?" +
                    " You look like you had one too many on a Halloween night!\" You glance at the person and their measuring cup and you start to mull on your next option." +
                    "\n\n\tChoice A)  Its all good, I'll just play it cool and give them a cup of sugar." +
                    "\n\n\tChoice B) I WILL SLAUGHTER YOU WHERE YOU STAND!");
        }


        public static string PrologueHallwayRight()
        {
            return ("You reach the end of the hallways and see two doors.  Which do you choose?" +
                    "\n\n\tChoice A) The third door sounds magical and appears to be in the shape of a portal and randomly gyrating lightning." +
                    "\n\tThere is a suspicious orb that looks as if it could be a doorknob." +
                    "\n\n\tChoice B) The last door is just a normal door." +
                    "\n\nWhich door will you pick?");
        }


        public static string WakeUpMage()
        {
            return ("You wake in your bed to find that your sheets have been stolen. As you look around the room you see that there are archaic books laid out across the floor." +
                    " They’re all named spell tomes with different authors, all with strange names you’ve never heard before. Unless you somehow learned how perform the transportation spell from the book laid out, you better go report stolen sheets A.S.A.P." +
                    " After screaming in shock and fear you run to the mirror to check yourself over for injury." +
                    " To your surprise, you do not see any injuries done, however you notice that you see a sparkle in your eye. Could it be the sparkle that your ex from college lied about?" +
                    " Did Taylor Smith have a bigger sparkle? What did they have that you didn’t? Could it be..." +
                    " You hear a knock at your front door. You scurry over to the living room to check and see who it is." +
                    " It is your neighbor asking for a cup of sugar." +
                    " You slowly open the door as your neighbor looks at you with a shocked face. \"What happened to you?" +
                    " You look like you had one too many on a Halloween night!\" You glance at the person and their measuring cup and you start to mull on your next option." +
                    "\n\n\tChoice A)  Its all good, I'll just play it cool and give them a cup of sugar." +
                    "\n\n\tChoice B) I WILL SLAUGHTER YOU WHERE YOU STAND!");
        }

        public static string WakeUpWoke()
        {
            return ("You wake in your bed to find that your sheets have been there all along. You could always rely on your pillow being there at the end of the day.\n\n?(^?^)?" +
                    "\n\nAfter screaming in shock and fear you run to the mirror to check yourself over for injury." +
                    " To your surprise, you do not see any injuries done, however you notice that nothing seems to be different except you seem to feel empathy towards the mirror." +
                    " You hear slight whisper-like sounds coming from the mirror. Co...Could the mirror be telling you it’s secrets? You move your ear closer to the mirror, but before you hear anything," +
                    " You hear a knock at your front door. You scurry over to the living room to check and see who it is." +
                    " It is your neighbor asking for a cup of sugar." +
                    " You slowly open the door as your neighbor looks at you with a shocked face. \"What happened to you?" +
                    " You look like you had one too many on a Halloween night!\" You glance at the person and their measuring cup and you start to mull on your next option." +
                    "\n\n\tChoice A)  Its all good, I'll just play it cool and give them a cup of sugar." +
                    "\n\n\tChoice B) I WILL SLAUGHTER YOU WHERE YOU STAND!");
        }

        public static string GiveSugarWolf()
        {
            return ("\n\nYou smile at them and greet them with a friendly greeting. You place 5 cups of sugar in the measuring cup and hand it back to your neighbor." +
                    " They hesitantly accepted the cup with shivering hands. You can tell that they're scared." +
                    " Why shouldn’t they be? If looks could kill, I’m basically a murderer with this voluminous hair." +
                    " After waving goodbye, you seem to gather a slight idea." +
                    " It seems like with all the clues from this morning, you come to the conclusion that you’re a wolf-human hybrid. A werewolf? Really...?" +
                    " You run outside and look for anyone that you can help.");
        }

        public static string GiveSugarVamp()
        {
            return ("\n\nYou smile at them and greet them with a friendly greeting. You place 5 cups of sugar in the measuring cup and hand it back to your neighbor." +
                    " They hesitantly accepted the cup with shivering hands. You can tell that they're scared." +
                    " Could it be that they thought about the possibility of having an AB- blood type?" +
                    " After waving goodbye, you seem to gather a slight idea." +
                    " Your fascination with blood, and the blood from the bed lead to only one conclusion." +
                    " You’re either a murderer or a vampire. But there doesn’t seem to be much of a difference between the two options." +
                    " You run outside and look for anyone that you can help.");
        }

        public static string GiveSugarMage()
        {
            return ("\n\nYou smile at them and greet them with a friendly greeting. You place 5 cups of sugar in the measuring cup and hand it back to your neighbor." +
                    " They hesitantly accepted the cup with shivering hands. You can tell that they're scared. Would they disappear like your sheets too?" +
                    " After waving goodbye, you seem to gather a slight idea." +
                    " Those books appeared from somewhere and you don’t know where. What could have brought them here? You are the only one with access to your house, " +
                    "so where they came from, your brought them. They all happen to be spell books. It’s like you’re that really strange guy, from that one movie you saw." +
                    " You run outside and look for anyone that you can help.");
        }

        public static string GiveSugarWoke()
        {
            return ("\n\nYou smile at them and greet them with a friendly greeting. You place 5 cups of sugar in the measuring cup and hand it back to your neighbor." +
                    " They hesitantly accepted the cup with shivering hands. You can tell that they're scared." +
                    " You think that being scared is such a pisces thing to be. They really brought out their pisces. But, how did you know they were a pisces." +
                    " After waving goodbye, you seem to gather a slight idea." +
                    " You seem to be extremely self-aware, and aware overall. You have the knowledge of things you’ve never cared about before." +
                    " The mirror speaking to you could be that you’ve advance to a level of mental capacity unachieved before in the history of mankind. You must be... awakened. Dare you say W O K E." +
                    " You run outside and look for anyone that you can help.");
        }

        public static string ScareSugarWolf()
        {
            return ("\n\nWith a mighty roar you slap the measuring cup out of their hand, making them scream and run to their apartment." +
                    " You smile as you bask in the aftermath of your carnage. An idea flashes across your mind as you" +
                    " inspect the claws in your paw? Do wolves have paws? Are there paws on werewolves?" +
                    " You find yourself wanting to Google this but unfortunately you couldn’t because your claws would destroy your keyboard by the time you got Google up." +
                    " With this new power I can make the world bend at its knees. Its time they start bagging my groceries for once!" +
                    " You run off into the streets, flailing your arms rapidly, in search of your next victim.");
        }

        public static string ScareSugarVamp()
        {
            return ("\n\nWith a mighty roar you slap the measuring cup out of their hand, making them scream and run to their apartment." +
                    " You smile as you bask in the aftermath of your carnage. An idea flashes across your mind as you feel yourself thirsting for blood. Would you satisfy this thirst?" +
                    " With this new power I can make the world bend at its knees. Its time they start bagging my groceries for once!" +
                    " You run off into the streets, flailing your arms rapidly, in search of your next victim.");
        }

        public static string ScareSugarMage()
        {
            return ("\n\nWith a mighty roar you slap the measuring cup out of their hand, making them scream and run to their apartment." +
                    " You smile as you bask in the aftermath of your carnage. An idea flashes across your mind as you feel your hands become lighter." +
                    " They seem to also be absorbing the very “energy” around you. It kind of tickles a little.\n\n???\n\n" +
                    " With this new power I can make the world bend at its knees. Its time they start bagging my groceries for once!" +
                    " You run off into the streets, flailing your arms rapidly, in search of your next victim.");
        }

        public static string ScareSugarWoke()
        {
            return ("\n\nWith a mighty roar you slap the measuring cup out of their hand, making them scream and run to their apartment." +
                    " You smile as you bask in the aftermath of your carnage. An idea flashes across your mind as you stare into the sky." +
                    " You think to yourself what this new feeling could amount to." +
                    " With this new power I can make the world bend at its knees. Its time they start bagging my groceries for once!" +
                    " You run off into the streets, flailing your arms rapidly, in search of your next victim.");
        }

        //things change after this point
        public static string TwoBlocks()
        {
            return ("After making it down two blocks you notice that there are battle tanks driving past as they seem to be heading toward the other end of the city." +
                    " You decide to ask what happened but get captured by some of the armed guard and hauled away by an armed car. Inside the moving vehicle, you are chained up and locked in a cage." +
                    " You ask why they have captured you. \"That's need to know, and you don't need to know.\" You can feel the intense stares of the other guards in the vehicle." +
                    "\n\nWhat will you do?" +
                    "\n\n\tChoice A) Seems like things are bad, might want to convince them I'm a good guy." +
                    "\n\n\tChoice B) No chains can hold me down. LET’S DO THIS!!");
        }

        public static string TwoBlocksGoodWolf()
        {
            return ("\n\nYou look at the guard and ask if you can talk to the leader. You insist that you will not do anything wrong." +
                    " However, the man just grunts at you and stays rigid. In the interest of making him your ally you show him the claws on your paw." +
                    " (As you remember, you still haven’t checked if it’s considered a paw). Saying that you know that you’re different but you want to find out why just as much as they do." +
                    " Impressed by your skills, they take a liking to you and bring in their commanding officer to speak with you." +
                    " He looks at you with a skeptical eye as he hears what you have done and proceeds to ask you some questions.");
        }

        public static string TwoBlocksGoodVamp()
        {
            return ("\n\nYou look at the guard and ask if you can talk to the leader. You insist that you will not do anything wrong." +
                    " However, the man just grunts at you and stays rigid. In the interest of making him your ally you show him your sharp canines." +
                    " Tell him you feel the thirst for blood take over you, but you don’t want to act upon it." +
                    " Impressed by your skills, they take a liking to you and bring in their commanding officer to speak with you." +
                    " He looks at you with a skeptical eye as he hears what you have done and proceeds to ask you some questions.");
        }

        public static string TwoBlocksGoodMage()
        {
            return ("\n\nYou look at the guard and ask if you can talk to the leader. You insist that you will not do anything wrong." +
                    " However, the man just grunts at you and stays rigid. In the interest of making him your ally you focus the energy that you can feel in your hands and try to force off the locks." +
                    " You successfully do so, but you also successfully put them back on. You do this to show them that you have the power to escape but choose not to. You want to find out what’s going on with you to." +
                    " Impressed by your skills, they take a liking to you and bring in their commanding officer to speak with you." +
                    " He looks at you with a skeptical eye as he hears what you have done and proceeds to ask you some questions.");
        }

        public static string TwoBlocksGoodWoke()
        {
            return ("\n\nYou look at the guard and ask if you can talk to the leader. You insist that you will not do anything wrong." +
                    " However, the man just grunts at you and stays rigid. In the interest of making him your ally you tell him things about him that only he would know," +
                    " but tell him that the only thing he doesn’t know is how you can know this and you want to find out." +
                    " Impressed by your skills, they take a liking to you and bring in their commanding officer to speak with you." +
                    " He looks at you with a skeptical eye as he hears what you have done and proceeds to ask you some questions.");
        }

        public static string TwoBlocksEvil()
        {
            return ("You stand up and cause the guards in the vehicle to draw their weapons on you." +
                    "One of the guards immediately strikes you with the end of their rifle, knocking you unconscious.  You wake up in an unfamiliar place only to hear...");

        }

        public static string ConvinceGeneral()
        {
            return ("You attempt to the convince the general that you’re on his side.The general turns back to his guards and starts deliberating with them." +
                    "To you, they look like they are carrying out a silent python skit. The general then turns around and presses the button again." +
                    "\"If you really believe you are capable of helping us, then we will put you to the test.\"" +
                    "They load up a board of shooting range dummies and you hear a short beep before they start moving left and right." +
                    "\n\n\tChoice A) I'm trying to show you that I'm on your side. " +
                    "\n\n\tChoice B) I'm going to recruit new minions for cannon fodder.");
        }

        public static string ConvinceGeneralGood()
        {
            return ("With a questionable look on his face, the general gets an idea and asks you to demonstrate for him what you did for his men." +
                    "He watches you closely, as he fumbles his gun holster. After completing the task, he stares at you and asks you this." +
                    "\"You seem to have a lot of power. I cannot let you go just yet, but I will allow you to speak with my superior at the rendezvous point.\"");
        }

        public static string ConvinceGeneralEvil()
        {
            return ("\n\nThe general draws his gun and points it straight for your head. You smirk evilly and try to reach for the general’s gun, however, the general's men move in and shoot you repeatedly." +
                    " (°?°) In an act of desperation, you try to move out of the way in time to find out that a bullet has lodged its way into your brain stem. Funny, it kinda tickles.\n\nGame Over.");
        }

        //both lead into Act 2 Prologue
    }
}
