using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Pacebook
{
    public class HardCodedOnstagramQuestions
    {
        List<QuestionModel> questions;

        public HardCodedOnstagramQuestions()
        {
            questions = new List<QuestionModel>();
        }

        public void addQuestions()
        {
            clearQuestionList();          

            QuestionModel question1 = new QuestionModel(1,
                "Which one is NOT a personal account?",
                "Fake accounts usually have little followers, but follow many other accounts.",
                true, 1,
                "image6",
                10);

            questions.Add(question1);

            QuestionModel question2 = new QuestionModel(2,
                "Which one is NOT a personal account?",
                " Non-personal accounts such as advertising accounts are full of posts that promote",
                true, 3,
                "image7",
                10);

            questions.Add(question2);

            QuestionModel question3 = new QuestionModel(3,
                "Which one is NOT a personal account?",
                " Non-personal accounts have some informations such as URLs, telephone number, and location on their profile.",
                true, 2,
                "image8",
                10);

            questions.Add(question3);           
        }

        public void addDutchQuestions()
        {
            clearQuestionList();

            QuestionModel question1 = new QuestionModel(1,
                "Welke account is hier een niet-persoonlijke account?",
                "Nep-accounts hebben meestal weinig volgers maar volgen wel heel veel mensen.",
                true, 1,
                "image6",
                10);

            questions.Add(question1);

            QuestionModel question2 = new QuestionModel(2,
                "Welke account is hier een niet-persoonlijke account?",
                "niet persoonlijke accounts hebben meestal veel reclame en/of shoutouts naar andere Onstagram paginas",
                true, 3,
                "image7",
                10);

            questions.Add(question2);

            QuestionModel question3 = new QuestionModel(3,
                "Welke account is hier een niet-persoonlijke account?",
                "niet persoonlijke accounts hebben meestal informatie zoals URLs, telefoon nummer of locatie op hun profiel.",
                true, 2,
                "image8",
                10);

            questions.Add(question3);     
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
