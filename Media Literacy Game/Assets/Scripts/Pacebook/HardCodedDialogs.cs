using Assets.Scripts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Pacebook
{
    class HardCodedDialogs
    {
        List<DialogModel> dialogs;

        public HardCodedDialogs()
        {
            dialogs = new List<DialogModel>();
        }

        public void addIntroductionDialogs()
        {
            DialogModel dialog1 = new DialogModel(
                1,
                "Hey there, I am here to give you a tour inside this building. " +
                "At the end, I will challenge you with some questions to know if you have learnt well!",
                "introImage1",
                "Mark");
            dialogs.Add(dialog1);

            DialogModel dialog2 = new DialogModel(
                2,
                "Have you ever thought that there are some fake accounts on Pacebook? But how can you know that!",
                "introImage2",
                "Mark");
            dialogs.Add(dialog2);

            DialogModel dialog3 = new DialogModel(
                3,
                "Firstly, you can spot them by looking at the profile picture. Usually, " +
                "when a picture of a famous person is used as a profile picture but the name of the profile is not associated to this picture, " +
                "you can tell that the account is fake!",
                "introImage3",
                "Mark");
            dialogs.Add(dialog3);

            DialogModel dialog4 = new DialogModel(
                4,
                "Secondly, next to the name of the accounts of famous people, there is usually a blue checkmark which " +
                "means that this account is detected as an account of a reliable person, as shown on the picture.",
                "introImage4",
                "Mark");
            dialogs.Add(dialog4);

            DialogModel dialog5 = new DialogModel(
                5,
                "Furthermore, not every message you recieve on Pacebook is safe, it can be an untrusted message, " +
                "that is why you have to be careful when you open a link or a video and ensure that this kind of" +
                " message is correctly sent to you by asking your friend about the content of the link video!" +
                " Those can lead to a virus or an information loss.",
                "introImage5",
                "Mark");
            dialogs.Add(dialog5);

            DialogModel dialog6 = new DialogModel(
                6,
                "Lastly, if the information on the news or posts is too dramatic or absurd, you have to be more patient.",
                "introImage6",
                "Mark");
            dialogs.Add(dialog6);
        }

        public List<DialogModel> getDialogs()
        {
            return dialogs;
        }
    }
}
