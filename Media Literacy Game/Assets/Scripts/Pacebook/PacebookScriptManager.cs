using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Pacebook
{
    public class PacebookScriptManager : MonoBehaviour
    {
        // Question Canvas
        public Button rightButton;
        public Button fakeButton;
        public Image newsImage;
        public Text questionText;
        public Text amountOfQuestionsText;

        // Feedback Canvas
        public Text feedbackText;
        public Button nextBtn;

        // Start test Canvase
        public Button startButtom;

        // Canvases
        public Canvas questionCanvas;
        public Canvas feedbackCanvas;
        public Canvas startTestCanvas;

        HardCodedQuestions questions;

        QuizManager quizManager;

        QuestionModel[] questionList;

        // Use this for initialization
        void Start()
        {
            getQuestions();

            // At the start of the scene
            questionCanvas.gameObject.SetActive(false);
            feedbackCanvas.gameObject.SetActive(false);
            startTestCanvas.gameObject.SetActive(true);


            quizManager = new QuizManager(questionList);
            loadNextQuestion();
        }

        public void startButtonClick()
        {
            amountOfQuestionsText.GetComponentInChildren<Text>().text = "Question: " + (quizManager.currentQuestion + 1).ToString() + "/" + quizManager.amountOfQuestions.ToString();
            loadNextQuestion();

            startTestCanvas.gameObject.SetActive(false);
            feedbackCanvas.gameObject.SetActive(false);
            questionCanvas.gameObject.SetActive(true);
            
        }

        public void rightButtonClick()
        {
            bool answeredCorrectly = false;

            answeredCorrectly = quizManager.answerQuestion(true);
            questionCanvas.gameObject.SetActive(false);

            if (answeredCorrectly)
            {
                feedbackText.text = "Your answer is good, " + quizManager.currentFeedback;
            }
            else
            {
                feedbackText.text = "Your answer is not good, " + quizManager.currentFeedback;
            }
            feedbackCanvas.gameObject.SetActive(true);
        }

        public void fakeButtonClick()
        {
            bool answeredCorrectly = false;

            answeredCorrectly = quizManager.answerQuestion(false);
            questionCanvas.gameObject.SetActive(false);

            if (answeredCorrectly)
            {
                feedbackText.text = "Your answer is good, " + quizManager.currentFeedback;
            }
            else
            {
                feedbackText.text = "Your answer is not good, " + quizManager.currentFeedback;
            }
            feedbackCanvas.gameObject.SetActive(true);
        }

        public void nextButtonClick()
        {
            var nextQuestion = quizManager.nextQuestion();

            
            if (quizManager.currentQuestion < quizManager.amountOfQuestions)
            {
                loadNextQuestion();
                amountOfQuestionsText.GetComponentInChildren<Text>().text = "Question: " + (quizManager.currentQuestion + 1).ToString() + "/" + quizManager.amountOfQuestions.ToString();
            }
            feedbackCanvas.gameObject.SetActive(false);
            questionCanvas.gameObject.SetActive(true);
        }

        private QuestionModel[] getQuestions()
        {
            questions = new HardCodedQuestions();
            questions.addQuestions();
            questionList = questions.GetQuestions();
            return questionList;
        }

        // For loading the quetion

        public void loadNextQuestion()
        {
            var nextQuestion = quizManager.nextQuestion();
            int numQuestion = nextQuestion.questionId;
            if (nextQuestion != null)
            {
                questionText.GetComponent<Text>().text = nextQuestion.question;
                newsImage.sprite = Resources.Load<Sprite>("PaceBookImages/" + nextQuestion.image); //+ nextQuestion.image
            }
            else
            {
                // Do NOTHING BRO
            }
        }
    }
}