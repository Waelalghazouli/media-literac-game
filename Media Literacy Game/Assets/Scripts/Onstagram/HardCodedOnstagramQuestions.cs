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
                "Is this account fake or real?",
                "Authorized pages have blue checkmark on their names. Also they have a lot of followers and likes.",
                false,
                "image1",
                10);
            questions.Add(question1);

            QuestionModel question2 = new QuestionModel(2,
                "Is this account fake or real?",
                "Some fake accounts have similar names to real account and posts similar pictures. But they don’t have blue mark.",
                true,
                "image2",
                10);
            questions.Add(question2);

            QuestionModel question3 = new QuestionModel(3,
                "Is this account fake or real?",
                "Authorized pages have blue checkmark on their names. Also they have a lot of followers and likes",
                false,
                "image3",
                10);
            questions.Add(question3);

            QuestionModel question4 = new QuestionModel(4,
                "Is this account fake or real?",
                "Authorized pages have blue checkmark on their names. Also they have a lot of followers and likes",
                true,
                "image4",
                10);
            questions.Add(question4);

            QuestionModel question5 = new QuestionModel(5,
                "Is this account fake or real?",
                "Some fake accounts have same profile picture, similar names to real account, and same posts. But they don’t have blue mark.",
                true,
                "image5",
                10);
            
            questions.Add(question5);

            QuestionModel question6 = new QuestionModel(6,
                "Which account is fake?",
                "Fake accounts usually have little followers, but follow many other accounts.",
                true,
                "image6",
                10);
            
            questions.Add(question6);

            QuestionModel question7 = new QuestionModel(7,
                "Which one is NOT a personal account?",
                " Non-personal accounts such as advertising accounts are full of posts that promote",
                true,
                "image7",
                10);
            
            questions.Add(question7);

            QuestionModel question8 = new QuestionModel(8,
                "Which one is NOT a personal account?",
                " Non-personal accounts have some informations such as URLs, telephone number, and location on their profile.",
                false,
                "image8",
                10);
            
            questions.Add(question8);           
        }

        public void addDutchQuestions()
        {
            clearQuestionList();

            QuestionModel question1 = new QuestionModel(1,
                "Is dit een nep account?",
                "Geatoriseerde paginas hebben een blauwe vinkje naast de naam en veel volgers en likes.",
                false,
                "image1",
                10);
            questions.Add(question1);

            QuestionModel question2 = new QuestionModel(2,
                "Is dit een nep account?",
                "Sommige nep-accounts hebben dezelfde naam, posts en fotos als het echte account, maar niet het blauwe vinkje",
                true,
                "image2",
                10);
            questions.Add(question2);

            QuestionModel question3 = new QuestionModel(3,
                "Is dit een nep account?",
                " Geatoriseerde paginas hebben een blauwe vinkje naast de naam en veel volgers.",
                false,
                "image3",
                10);
            questions.Add(question3);

            QuestionModel question4 = new QuestionModel(4,
                "Is dit een nep account?",
                "geautoriseerde accounts hebben een blauwe vinkje en hebben heel veel volgers en likes.",
                true,
                "image4",
                10);

            questions.Add(question4);

            QuestionModel question5 = new QuestionModel(5,
                "Is dit een nep account?",
                "Sommige nep-accounts hebben dezelfde foto, dezelfde namen en dezelfde posts maar hebben geen blauwe vinkje en niet het zelfde aantal volgers als de echte account.",
                true,
                "image5",
                10);

            questions.Add(question5);

            QuestionModel question6 = new QuestionModel(6,
                "Welke account is hier een nep-account?",
                "Nep-accounts hebben meestal weinig volgers maar volgen wel heel veel mensen.",
                true,
                "image6",
                10);

            questions.Add(question6);

            QuestionModel question7 = new QuestionModel(7,
                "Welke account is hier een nep-account?",
                "niet persoonlijke accounts hebben meestal veel reclame en/of shoutouts naar andere Onstagram paginas",
                true,
                "image7",
                10);

            questions.Add(question7);

            QuestionModel question8 = new QuestionModel(8,
                "Welke account is hier een nep-account?",
                "niet persoonlijke accounts hebben meestal informatie zoals URLs, telefoon nummer of locatie op hun profiel.",
                false,
                "image8",
                10);

            questions.Add(question8);     
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
