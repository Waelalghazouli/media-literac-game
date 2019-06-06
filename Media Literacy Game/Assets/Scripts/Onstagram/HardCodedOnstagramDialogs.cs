using Assets.Scripts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Pacebook
{
    class HardCodedOnstagramDialogs
    {
        List<DialogModel> dialogs;

        public HardCodedOnstagramDialogs()
        {
            dialogs = new List<DialogModel>();
        }

        public void addDutchIntroductionDialogs()
        {
            DialogModel dialog1 = new DialogModel(
                1,
                "Hoi, ik ben hier om jou rond te leiden door dit gebouw. " +
                "Aan het einde van deze introductie zal ik jou toetsen met een aantal vragen!",
                "introImage1",
                "Mark");



            dialogs.Add(dialog1);
            

            DialogModel dialog2 = new DialogModel(
                2,
                "Meestal kan je al aan de naam van de profiel zien of het profiel nep is. " +
                "Sommige accounts hebben bijna dezelfde naam en dezelfde posts maar niet hetzelfde aantal volgers. " +
                " Daarnaast hebben nep accounts ook geen blauwe vinkje. ",
                "image2",
                "Mark");


            dialogs.Add(dialog2);


            DialogModel dialog4 = new DialogModel(
                4,
                "Naast het feit dat je op de naam moet letten moet je ook letten op het aantal volgers. " +
                "veel bekende mensen hebben meestal heel veel volgers. " +
                " Daarnaast moeten we weer letten op het blauwe vinkje.  ",
                "image5",
                "Mark");

            dialogs.Add(dialog4);

            DialogModel dialog6 = new DialogModel(
                6,
                "Tenslotte, is hier een goede voorbeeld van een echte account. Let op het aantal volgers en het blauwe vinkje. ",
                "image3",
                "Mark");

            dialogs.Add(dialog6);
        }

        public void addIntroductionDialogs()
        {
            DialogModel dialog1 = new DialogModel(
                1,
                "Hey there, I am here to give you a tour inside this building. " +
                "At the end, I will challenge you with some questions to know if you have learned well!",
                "introImage1",
                "Mark");


            dialogs.Add(dialog1);

            DialogModel dialog3 = new DialogModel(
                3,
                "Firstly, you can spot a fake account by looking at the profile name. " +
                "Some fake accounts have similar names to real account and post similar pictures. It’s not blackpinkofficial, but it’s blackpink’C’official. And they don’t have blue mark. " +
                "You can tell that this account is fake!",
                "image2",
                "Mark");

            dialogs.Add(dialog3);

            DialogModel dialog5 = new DialogModel(
                5,
                "Furthermore, you can also spot a fake account by its amount of followers, " +
                "This person is a really famous person so the little amount of followers does not make any sense." +
                " You can also notice that he is missing a blue checkmark.",
                "image5",
                "Mark");


            dialogs.Add(dialog5);

            DialogModel dialog6 = new DialogModel(
                6,
                "Lastly, here is an example of a real account, notice the followers and the blue checkmark.",
                "image3",
                "Mark");


            dialogs.Add(dialog6);
        }

        public List<DialogModel> getDialogs()
        {
            return dialogs;
        }
    }
}
