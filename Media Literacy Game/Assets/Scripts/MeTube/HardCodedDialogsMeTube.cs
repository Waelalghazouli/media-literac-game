using Assets.Scripts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.MeTube
{
    class HardCodedDialogsMeTube
    {
        List<DialogModel> dialogs;

        public HardCodedDialogsMeTube()
        {
            dialogs = new List<DialogModel>();
        }

        public void addDutchIntroductionDialogs()
        {
            dialogs.Clear();
            
            DialogModel dialog1 = new DialogModel(
                1,
                "Hoi, ik ben Steve Chen, een van de MeTube eigenaren. Ik ben hier om je een rondleiding te geven over wat dit gebouw inhoudt. " +
                "Aan het eind van deze rondleiding wil ik jou uitdagen met een paar vragen om te kijken hoe je ervaring is met het gebruik van MeTube. " +
                "Laten we nu beginnen!",
                "introMeTube1",
                "Steve");

            dialogs.Add(dialog1);

            
            DialogModel dialog2 = new DialogModel(
                2,
                "MeTube is een website of een applicatie op je mobiel die je kan gebruiken om MeTube video's volgens je benodigdheid te bekijken. " +
                "Ik denk dat je hiet wel bekend mee bent, maar soms moet je wel opletten tijden het gebruik maken van MeTube.",
                "introMeTube2",
                "Steve");

            dialogs.Add(dialog2);

            
            DialogModel dialog3 = new DialogModel(
                3,
                "MeTube heeft interessante en gezellige video's, maar sommige video's zijn ongeschikt om bekeken te worden door de " +
                "gebruikers in jouw leeftijdcategorie",
                "introMeTube3",
                "Steve");

            dialogs.Add(dialog3);
            
            DialogModel dialog4 = new DialogModel(
                4,
                "Vieos die te maken hebben met geweld, mensen pesten en pronografie moeten geen plaats op MeTube vinden, maar toch kan je zulke video's op MeTube tegenkomen, " +
                "daarom is het belangrijk om dit soort filmpjes te vermijden en desnoods MeTube daarover te melde.",
                "introMeTube4",
                "Steve");

            dialogs.Add(dialog4);

            DialogModel dialog5 = new DialogModel(
                5,
                "Natuurlijk heeft MeTube genoeg handige aspecten om erover te weten, net als de tutorial die jou iets kunnen leren, denk aan programmeren bijvoorbeeld.",
                "introMeTube5",
                "Steve");

            dialogs.Add(dialog5);

            DialogModel dialog6 = new DialogModel(
                6,
                "Nu jij een idee hebt kunnen verwerven over wat je op MeTube kan tegenkomen, wil ik jou uitdagen door een paar vragen te beantwoorden, ben je er klaar voor?",
                "introMeTube6",
                "Steve");

            dialogs.Add(dialog6);
        }

        public void addIntroductionDialogs()
        {
            dialogs.Clear();

            DialogModel dialog1 = new DialogModel(
                1,
                "Hello, I am Steve Chen, one of the MeTube owners. I am here to give you a tour inside this building. " +
                "At the end of the tour, I want to challenge you with some questions to know if you have learnt well! " +
                "Let me introduce you to the world of MeTube.",
                "introMeTube1",
                "Steve");

            dialogs.Add(dialog1);

            DialogModel dialog2 = new DialogModel(
                2,
                "MeTube is a website or an application on your mobile phone which you can use to watch videos according to " +
                "Your purposes. I think you are familiar with this, are not you? But sometimes you have to be carful while using it.",
                "introMeTube2",
                "Steve");

            dialogs.Add(dialog2);

            DialogModel dialog3 = new DialogModel(
                3,
                "MeTube has many interesting and funny videos but some of them should be not watched by the audience in your age.",
                "introMeTube3",
                "Steve");

            dialogs.Add(dialog3);

            DialogModel dialog4 = new DialogModel(
                4,
                "You should not watch anything connected to pornography, anything brutal, or harming people in different ways.",
                "introMeTube4",
                "Steve");

            dialogs.Add(dialog4);

            DialogModel dialog5 = new DialogModel(
                5,
                "Of course MeTube has much handy aspects to use, such as MeTube tutorials which can teach you something you want such as programming!",
                "introMeTube5",
                "Steve");

            dialogs.Add(dialog5);

            //DialogModel dialog6 = new DialogModel(
            //    6,
            //    "Now you have got an idea what MeTube is and what kind of puposes it has, but let's start our challenge by answering some questions about " +
            //    "the information you have gathered through our tour. Are you ready for it?",
            //    "introMeTube6",
            //    "Steve");

            //dialogs.Add(dialog6);
        }

        public List<DialogModel> getDialogs()
        {
            return dialogs;
        }
    }
}
