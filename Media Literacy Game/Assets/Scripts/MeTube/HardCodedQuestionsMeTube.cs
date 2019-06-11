using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.MeTube
{
    class HardCodedQuestionsMeTube
    {
        List<QuestionModel> questions;


        public HardCodedQuestionsMeTube()
        {

            questions = new List<QuestionModel>();
        }

        public void addQuestions()
        {
            clearQuestionList();

            QuestionModel question1 = new QuestionModel(
                1,
                "Is this video interesting to watch?",
                "Tutorials are absolutely to watch and this is an interesting topic but you should not do it at home and get influenced by that.",
                false,
                "image1",
                10);

            questions.Add(question1);

            QuestionModel question2 = new QuestionModel(
                2,
                "Do you think it is appropriate to watch this video on MeTube?",
                "You are not sure what will happen there, it might be disgusting.",
                false,
                "image2",
                10);

            questions.Add(question2);

            QuestionModel question3 = new QuestionModel(
                3,
                "Do you think this video is nice to watch?",
                "There is nothing harmful in a lifestyle vlog.",
                true,
                "image3",
                10);

            questions.Add(question3);

            QuestionModel question4 = new QuestionModel(
                4,
                "Do you think it is good to watch this video?",
                "There is nothing harmful in watching cute animals and gathering information about them.",
                true,
                "image4",
                10);

            questions.Add(question4);

            QuestionModel question5 = new QuestionModel(
                5,
                "Do you think it is a good video to watch on MeTube?",
                "This video is weird and may cause fear or anxiety.",
                false,
                "image5",
                10);

            questions.Add(question5);

            QuestionModel question6 = new QuestionModel(
                6,
                "Is this an interesting video to watch on MeTube?",
                "Cooking videos can be very interesting and are not harmful at all.",
                true,
                "image6",
                10);

            questions.Add(question6);

            QuestionModel question7 = new QuestionModel(
                7,
                "Is this a peaceful video to watch on MeTube?",
                "Videos like this can show very brutal situations and may scare you.",
                false,
                "image7",
                10);

            questions.Add(question7);

            QuestionModel question8 = new QuestionModel(
                8,
                "Is it appropriate to watch videos about fails?",
                "Usually fails have no harmful content inside, but if they can cause anxiety, do not watch them. Also please do not do those things at home",
                true,
                "image8",
                10);

            questions.Add(question8);

            QuestionModel question9 = new QuestionModel(
                9,
                "Is it a good idea to watch people's journey on MeTube?",
                "There is nothing wrong with travel videos as long as they do not show anything brutal, in addition some people like to share their journey with the others!",
                true,
                "image9",
                10);
            questions.Add(question9);

            QuestionModel question10 = new QuestionModel(
                10,
                "Do you think all prank videos are appropriate to watch on MeTube?",
                "Pranks can make you laugh as long as they do not harm anybody and you won’t recreate those things at home",
                true,
                "image10",
                10);

            questions.Add(question10);

        }

        public void addDutchQuestions()
        {
            clearQuestionList();

            QuestionModel question1 = new QuestionModel(
                1,
                "Is dit een interessante video om te kijken, denk je?",
                "Tutorials zijn goed om te kijken, maar dit soort tutorial kunnen gevaarlijk voor je zijn!",
                false,
                "image1",
                10);

            questions.Add(question1);

            QuestionModel question2 = new QuestionModel(
                2,
                "Denk je dat dit een geschikte video is om te kijken?",
                "Je weet niet zeker wat er gaat gebeuren, bovendien kan dit soort filmpjes geweld opwekken bij de kijkers!",
                false,
                "image2",
                10);

            questions.Add(question2);

            QuestionModel question3 = new QuestionModel(
                3,
                "Is het goed om zo een video te kijken?",
                "Een vlog kan meestal interessant zijn om te kijken, bovendien vinden sommige mensen het leuk om hen leven met anderen te delen, " +
                "daarom is er niks mis mee als je zo een video op MeTube kijkt.",
                true,
                "image3",
                10);

            questions.Add(question3);

            QuestionModel question4 = new QuestionModel(
               4,
               "Denk je dat het leuk is om zo een video te kijken?",
               "Dit is een soort van tutorial waarmee je over een bepaald dier informatie kan verwerven, daarom is er niks mis mee" +
               " om zo een video te bekijken.",
               true,
               "image4",
               10);

            questions.Add(question4);

            QuestionModel question5 = new QuestionModel(
                5,
                "Is het verstandig om dit filmpje te kijken op MeTube?",
                "Door de foto zie je mensen die messen gebruiken in onhandige manier die wellicht geweld opwekt, dat is dan genoeg om dit soort video te vermijden.",
                false,
                "image5",
                10);

            questions.Add(question5);

            QuestionModel question6 = new QuestionModel(
                6,
                "Denk je dat het interessant is om dit filmpje te bekijken?",
                "Video's die over koken gaan zijn meestal leuk om te kijken aangezien je daar waarschijnlijk wat van kan leren. Dit soort filmpjes behoren ook " +
                "tot tutorials.",
                true,
                "image6",
                10);

            questions.Add(question6);

            QuestionModel question7 = new QuestionModel(
                7,
                "Is dit een veilige video om te kijken, denk je?",
                "Zo een video kan tot angst leiden, waardoor het onhandig lijkt om dit soort filmpjes te bekijken!",
                false,
                "image7",
                10);

            questions.Add(question7);

            QuestionModel question8 = new QuestionModel(
                8,
                "Is het goed om videos over falen te bekijken?",
                "Video's over falen zijn wel interessant om te kijken, maar soms kan dit soort viedo's angst verwoorzaken waardoor het niet hanig lijkt te zijn om " +
                "dit soort video's te kijken.",
                true,
                "image8",
                10);

            questions.Add(question8);

            QuestionModel question9 = new QuestionModel(
                9,
                "Is het een goed idee om video's van een reiziger op MeTube te bekijken?",
                "Er is niks mis met het kijken van een reis van een vlogger, bovendien vinden sommige mensen het leuk om hun leven met anderen te delen.",
                true,
                "image9",
                10);
            questions.Add(question9);

            QuestionModel question10 = new QuestionModel(
                10,
                "Denk je dat alle pranks (grap video's) leuk zijn om te kijken?",
                "Dit soort filmpjes kunnen we gezellig zijn zo lang het geen kwaadaardige akties inhoudt.",
                true,
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
