using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Pacebook
{
    public class HardCodedQuestions
    {
        QuestionModel[] questions;


        public HardCodedQuestions()
        {

            questions = new QuestionModel[10];
        }

        public void addQuestions()
        {
            QuestionModel question1 = new QuestionModel(1,
                // English
                //"You recieve a friend request from this account, is this a fake or a trustable profile?",
                //" It’s a very famous person’s photo, so you should be suspicious. There is some wrong information about real Julia Roberts.",

                // Dutch
                "Je hebt dit vreindschapverzoek ontvangen, is dit een nep of een betrouwbaar account, denk je?",
                "Het is een profielfoto van een bekende persoon, dus je moet oppassen. Bovendien zijn er foutieve informatie over Julia Roberts",
                false,
                "image1",
                10);
            //questions.Add(question1);
            questions[0] = question1;

            QuestionModel question2 = new QuestionModel(2,
                //English
                //"You see this account on Pacebook, is this a fake or a trustable profile?",
                //" Authorized celebrities have blue checkmarks next to their names. Also, they have a lot of followers.",

                // Dutch
                "Je ziet dit account op Pacebook, is dit een nep of een betrouwbaar account, denk je?",
                "Geautoriseerde accounts hebben meestal een blauw vinkje naast de naam van het account. Bovendien hebben geautoriseerde accounts meer volgers dan normale accounts",
                true,
                "image2",
                10);
            questions[1] = question2;

            QuestionModel question3 = new QuestionModel(3,
                // English
                //"You see this account on Pacebook, is this a fake or a trustable profile?",
                //" It’s a very famous person’s photo, so you should be suspicious. If there’s no blue marks, this account is not authorized.",

                // Dutch
                "Je ziet dit account op Pacebook, is dit een nep of een betrouwbaar account, denk je?",
                "De profielfoto is een foto van een bekende persoon, je moet wel oppassen. Als er geen blauw vinkje is naast de naam van het account, is dit account niet geautoriseerd.",
                false,
                "image3",
                10);
            questions[2] = question3;

            QuestionModel question4 = new QuestionModel(4,
                // English
                //"You see this page on facebook, is this a fake or a trustable page?",
                //" Authorized celebrities have a blue checkmark next to their names.",

                // Dutch
                "Je ziet deze pagina op Pacebook, is dit een neppe of een betrouwbare pagina, denk je?",
                "Geautoriseerde paginas hebben een blauw vinkje naast de paginasnaam.",
                true,
                "image4",
                10);

            questions[3] = question4;

            QuestionModel question5 = new QuestionModel(5,
                // English
                //"You see this page posting this new on Pacebook, can you trust this new?",
                //" Authorized pages have a blue checkmark next to their names. Also, they have a lot of followers and likes.",

                // Ducth
                "Je ziet deze post op Pacebook, kan je het nieuws wat daarin staat vertrouwn?",
                "Geautoriseerde paginas hebben een blauw vinkje naast de paginasnaam, waardoor je kan verwachten dat zo een pagina betrouwbaar niews plaatst.",
                true,
                "image5",
                10);

            questions[4] = question5;

            QuestionModel question6 = new QuestionModel(6,
                // English
                //"You see this page posting this new on Pacebook, can you trust this new?",
                //" Famous and established news companies are more reliable such as BBC, or Times. Also, they have a lot of followers and likes.",

                // Dutch
                "Je ziet deze post op Pacebook, kan je het nieuws wat daarin staat vertrouwn?",
                "Een bekend en gevestigd bedrijf zijn vaak betrouwbaar net als BBC of Times. Bovendien zie je dat zo een pagina genoeg volgers heeft dan normaal.",
                true,
                "image6",
                10);

            questions[5] = question6;

            QuestionModel question7 = new QuestionModel(7,
                // Engish
                //"You see this news posted on Pacebook, can you trust this news?",
                //" Some radical and absurd information cannot be true. They are just for drawing attention.",

                // Ducth
                "Je ziet deze post op Pacebook, kan je het nieuws wat daarin staat vertrouwn?",
                "Radicale en onzinnige informatie kan niet betrouwbaar zijn. Dit soort posts zijn er vaak om aandacht aan te trekken.",
                true,
                "image7",
                10);

            questions[6] = question7;

            QuestionModel question8 = new QuestionModel(8,
                // English
                //"You see this new posted on Pacebook, can you trust this new?",
                //" Some radical and absurd information cannot be true. They are just for drawing attention.",

                // Dutch
                "Je ziet deze post op Pacebook, kan je het nieuws wat daarin staat vertrouwn?",
                "Radicale en onzinnige informatie kan niet betrouwbaar zijn. Dit soort posts zijn er vaak om aandacht aan te trekken.",
                false,
                "image8",
                10);

            questions[7] = question8;

            QuestionModel question9 = new QuestionModel(9,
                // English
                //"You see this new posted on Pacebook, can you trust this new?",
                //" Some radical and absurd information cannot be true. They are just for drawing attention.",

                // Dutch
                "Je ziet deze post op Pacebook, kan je het nieuws wat daarin staat vertrouwn?",
                "Radicale en onzinnige informatie kan niet betrouwbaar zijn. Dit soort posts zijn er vaak om aandacht aan te trekken.",
                false,
                "image9",
                10);

            questions[8] = question9;

            QuestionModel question10 = new QuestionModel(10,
                // English
                //"You recieve this message from an unknown user on Pacebook, can you trust this message?",
                //"Links in messages from unknown usually contain virus or steals your information.",

                // Dutch
                "Je hebt dit bericht op Pacebook ontvangen van een onbekende persoon, kan je dit bericht vertrouwen?",
                "Het is verstandig om een link in bericht van een onbekende persoon niet te open, want dit kan virussen inhouden.",
                false,
                "image10",
                10);

            questions[9] = question10;
        }



        public QuestionModel[] GetQuestions()
        {
            return questions;
        }
    }
}
