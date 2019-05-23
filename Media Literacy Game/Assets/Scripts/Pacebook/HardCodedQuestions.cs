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
                "You recieve a friend request from this account, is this a fake profile or trustable profile?",
                "It’s a very famous person’s photo,so you should be suspicious. There are some wrong information about real Julia Roberts.",
                false,
                "image1",
                10);
            //questions.Add(question1);
            questions[0] = question1;

            QuestionModel question2 = new QuestionModel(2,
                "You see this account on Pacebook, is this a fake profile or trustable profile?",
                "Authorized celebrities have blue checkmark next to their names. Also, they have a lot of followers",
                true,
                "image2",
                10);
            questions[1] = question2;

            QuestionModel question3 = new QuestionModel(3,
                "You see this account on Pacebook, is this a fake profile or trustable profile?",
                "It’s a very famous person’s photo,so you should be suspicious. If there’s no blue mark, this account is not authorized.",
                false,
                "image3",
                10);
            questions[2] = question3;

            QuestionModel question4 = new QuestionModel(4,
                "You see this page on facebook, is this a fake page or trustable page?",
                "Authorized celebrities have blue checkmark next to their names.",
                true,
                "image4",
                10);

            questions[3] = question4;

            QuestionModel question5 = new QuestionModel(5,
                "You see this page posting this news poston Pacebook, can you trust this news?",
                "Authorized pages have blue checkmark on their names. Also they have a lot of followers and likes.",
                true,
                "image5",
                10);

            questions[4] = question5;

            QuestionModel question6 = new QuestionModel(6,
                "You see this page posting this news post on Pacebook, can you trust this news?",
                "Famous and established news companies are more reliable such as BBC, or Times. Also they have a lot of followers and likes.",
                true,
                "image6",
                10);

            questions[5] = question6;

            QuestionModel question7 = new QuestionModel(7,
                "You see this news post on Pacebook, can you trust this news?",
                "Some radical and absurd informations cannot be true. They are just for drawing attention.",
                true,
                "image7",
                10);

            questions[6] = question7;

            QuestionModel question8 = new QuestionModel(8,
                "You see this news post on Pacebook, can you trust this news?",
                "Some radical and absurd informations cannot be true. They are just for drawing attention.",
                false,
                "image8",
                10);

            questions[7] = question8;

            QuestionModel question9 = new QuestionModel(9,
                "You see this news post on Pacebook, can you trust this news?",
                "Some radical and absurd informations cannot be true. They are just for drawing attention.",
                false,
                "image9",
                10);

            questions[8] = question9;

            QuestionModel question10 = new QuestionModel(10,
                "You recieve this message from unknow person on Pacebook, can you trust this message?",
                "Some radical and absurd informations cannot be true. They are just for drawing attention.",
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
