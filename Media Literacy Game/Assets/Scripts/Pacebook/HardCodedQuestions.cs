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
            QuestionModel question1 = new QuestionModel(1,
                "Is this fake profile or trustable profile?",
                "Because the name contains numbers, the account can be seen as a fake account!",
                false,
                10);
            questions.Add(question1);

            QuestionModel question2 = new QuestionModel(1,
                "Is this fake message or turstable message?",
                "This message contains a link which seems untrustable.",
                false,
                10);
            questions.Add(question2);

            QuestionModel question3 = new QuestionModel(1,
                "Is this fake profile or turstable profile?",
                "The name of the account is a name for a famous person, " +
                "but it seems that the account does not have enough friends " +
                "or followers and that makes it an untrustable account.",
                false,
                10);
            questions.Add(question3);
        }

        public List<QuestionModel> GetQuestions()
        {
            return questions;
        }
    }
}
