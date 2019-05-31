using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Pacebook
{
    public class HardCodedQuestions
    {

        List<QuestionModel> questions;


        public HardCodedQuestions()
        {

            questions = new List<QuestionModel>();
        }

        public void addQuestions()
        {
            clearQuestionList();

            QuestionModel question1 = new QuestionModel(1,
                "You recieve a friend request from this account, is this a fake or a trustable profile?",
                " It’s a very famous person’s photo, so you should be suspicious. There is some wrong information about real Julia Roberts.",
                false,
                "image1",
                10);
            questions.Add(question1);

            QuestionModel question2 = new QuestionModel(2,
                "You see this account on Pacebook, is this a fake or a trustable profile?",
                " Authorized celebrities have blue checkmarks next to their names. Also, they have a lot of followers.",
                true,
                "image2",
                10);
            questions.Add(question2);

            QuestionModel question3 = new QuestionModel(3,
                "You see this account on Pacebook, is this a fake or a trustable profile?",
                " It’s a very famous person’s photo, so you should be suspicious. If there’s no blue marks, this account is not authorized.",
                false,
                "image3",
                10);
            questions.Add(question3);

            QuestionModel question4 = new QuestionModel(4,
                "You see this page on facebook, is this a fake or a trustable page?",
                " Authorized celebrities have a blue checkmark next to their names.",
                true,
                "image4",
                10);
            questions.Add(question4);

            QuestionModel question5 = new QuestionModel(5,
                "You see this page posting this new on Pacebook, can you trust this new?",
                " Authorized pages have a blue checkmark next to their names. Also, they have a lot of followers and likes.",
                true,
                "image5",
                10);
            
            questions.Add(question5);

            QuestionModel question6 = new QuestionModel(6,
                "You see this page posting this new on Pacebook, can you trust this new?",
                " Famous and established news companies are more reliable such as BBC, or Times. Also, they have a lot of followers and likes.",
                true,
                "image6",
                10);
            
            questions.Add(question6);

            QuestionModel question7 = new QuestionModel(7,
                "You see this news posted on Pacebook, can you trust this news?",
                " Some radical and absurd information cannot be true. They are just for drawing attention.",
                true,
                "image7",
                10);
            
            questions.Add(question7);

            QuestionModel question8 = new QuestionModel(8,
                "You see this new posted on Pacebook, can you trust this new?",
                " Some radical and absurd information cannot be true. They are just for drawing attention.",
                false,
                "image8",
                10);
            
            questions.Add(question8);

            QuestionModel question9 = new QuestionModel(9,
                "You see this new posted on Pacebook, can you trust this new?",
                " Some radical and absurd information cannot be true. They are just for drawing attention.",
                false,
                "image9",
                10);
            
            questions.Add(question9);


            QuestionModel question10 = new QuestionModel(10,
                "You recieve this message from an unknown user on Pacebook, can you trust this message?",
                "Links in messages from unknown usually contain virus or steals your information.",
                false,
                "image10",
                10);
            
            questions.Add(question10);
        }

        public void addDutchQuestions()
        {
            clearQuestionList();

            QuestionModel question1 = new QuestionModel(1,
                "Je hebt dit vreindschapverzoek ontvangen, is dit een nep of een betrouwbaar account, denk je?",
                "Het is een profielfoto van een bekende persoon, dus je moet oppassen. Bovendien zijn er foutieve informatie over Julia Roberts",
                false,
                "image1",
                10);
            questions.Add(question1);

            QuestionModel question2 = new QuestionModel(2,
                "Je ziet dit account op Pacebook, is dit een nep of een betrouwbaar account, denk je?",
                "Geautoriseerde accounts hebben meestal een blauw vinkje naast de naam van het account. Bovendien hebben geautoriseerde accounts meer volgers dan normale accounts",
                true,
                "image2",
                10);
            questions.Add(question2);

            QuestionModel question3 = new QuestionModel(3,
                "Je ziet dit account op Pacebook, is dit een nep of een betrouwbaar account, denk je?",
                "De profielfoto is een foto van een bekende persoon, je moet wel oppassen. Als er geen blauw vinkje is naast de naam van het account, is dit account niet geautoriseerd.",
                false,
                "image3",
                10);
            questions.Add(question3);

            QuestionModel question4 = new QuestionModel(4,
                "Je ziet deze pagina op Pacebook, is dit een neppe of een betrouwbare pagina, denk je?",
                "Geautoriseerde paginas hebben een blauw vinkje naast de paginasnaam.",
                true,
                "image4",
                10);

            questions.Add(question4);

            QuestionModel question5 = new QuestionModel(5,
                "Je ziet deze post op Pacebook, kan je het nieuws wat daarin staat vertrouwn?",
                "Geautoriseerde paginas hebben een blauw vinkje naast de paginasnaam, waardoor je kan verwachten dat zo een pagina betrouwbaar niews plaatst.",
                true,
                "image5",
                10);

            questions.Add(question5);

            QuestionModel question6 = new QuestionModel(6,
                "Je ziet deze post op Pacebook, kan je het nieuws wat daarin staat vertrouwn?",
                "Een bekend en gevestigd bedrijf zijn vaak betrouwbaar net als BBC of Times. Bovendien zie je dat zo een pagina genoeg volgers heeft dan normaal.",
                true,
                "image6",
                10);

            questions.Add(question6);

            QuestionModel question7 = new QuestionModel(7,
                "Je ziet deze post op Pacebook, kan je het nieuws wat daarin staat vertrouwn?",
                "Radicale en onzinnige informatie kan niet betrouwbaar zijn. Dit soort posts zijn er vaak om aandacht aan te trekken.",
                true,
                "image7",
                10);

            questions.Add(question7);

            QuestionModel question8 = new QuestionModel(8,
                "Je ziet deze post op Pacebook, kan je het nieuws wat daarin staat vertrouwn?",
                "Radicale en onzinnige informatie kan niet betrouwbaar zijn. Dit soort posts zijn er vaak om aandacht aan te trekken.",
                false,
                "image8",
                10);

            questions.Add(question8);

            QuestionModel question9 = new QuestionModel(9,
                "Je ziet deze post op Pacebook, kan je het nieuws wat daarin staat vertrouwn?",
                "Radicale en onzinnige informatie kan niet betrouwbaar zijn. Dit soort posts zijn er vaak om aandacht aan te trekken.",
                false,
                "image9",
                10);

            questions.Add(question9);

            QuestionModel question10 = new QuestionModel(10,
                "Je hebt dit bericht op Pacebook ontvangen van een onbekende persoon, kan je dit bericht vertrouwen?",
                "Het is verstandig om een link in bericht van een onbekende persoon niet te open, want dit kan virussen inhouden.",
                false,
                "image10",
                10);

            questions.Add(question10);
        }

        public List<QuestionModel> GetQuestions()
        {
            return questions;
        }

        private void clearQuestionList()
        {
            questions.Clear();
        }
    }
}
