using Assets.Scripts.Models;
using System;
using System.Collections;
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
        // Score manager
        ScoreManager scoreManager;

        // Question Canvas
        public Image newsImage;
        public Text questionText;
        public Text amountOfQuestionsText;

        // Feedback Canvas
        public Text feedbackText;
        

        // Start test Canvase
        public Text startText;
        public Image startImage;

        // Introduction Dialog Canvas
        public Image speakerImage;
        public Image descImage;
        public Text dialogText;
        bool writing;
        public Button nextDialogButton;
        public Button previousDialogButton;

        // Canvases
        public Canvas questionCanvas;
        public Canvas feedbackCanvas;
        public Canvas startTestCanvas;
        public Canvas introductionCanvas;

        HardCodedQuestions questions;
        QuizManager quizManager;
        QuestionModel[] questionList;

        HardCodedDialogs dialogs;
        DialogManager dialogManager;
        List<DialogModel> dialogList;

        // Use this for initialization
        void Start()
        {
            getQuestions();
            getIntroDialogs();

            // At the start of the scene
            introductionCanvas.gameObject.SetActive(false);
            questionCanvas.gameObject.SetActive(true);
            feedbackCanvas.gameObject.SetActive(false);
            startTestCanvas.gameObject.SetActive(false);

            previousDialogButton.gameObject.SetActive(false);
            dialogManager = new DialogManager(dialogList);
            loadDialog();

            quizManager = new QuizManager(questionList);
            loadNextQuestion();

            scoreManager = new ScoreManager();
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
                scoreManager.updateScore();
                feedbackText.text = "Your answer is correct. " + quizManager.currentFeedback;
            }
            else
            {
                feedbackText.text = "Your answer is incorrect. " + quizManager.currentFeedback;
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
                feedbackText.text = "Your answer is correct. " + quizManager.currentFeedback;
            }
            else
            {
                feedbackText.text = "Your answer is incorrect. " + quizManager.currentFeedback;
            }
            feedbackCanvas.gameObject.SetActive(true);
        }

        public void nextQuestionButtonClick()
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

        public void nextDialogButtonClick()
        {
            Debug.Log("Amount of dialogues: " + dialogManager.amountOfDialogs());

            var nextDialog = dialogManager.nextDialog();

            previousDialogButton.gameObject.SetActive(true);

            if (dialogManager.currentDialog < dialogManager.amountOfDialogs())
            {
                loadNextDialog();
            }
        }

        public void previousDialogButtonClick()
        {
            Debug.Log("Amount of dialogues: " + dialogManager.amountOfDialogs());

            var previousDialog = dialogManager.previousDialog();

            if (dialogManager.currentDialog >= 1)
            {
                loadPreviousDialog();
            }
        }

        private QuestionModel[] getQuestions()
        {
            questions = new HardCodedQuestions();
            questions.addQuestions();
            questionList = questions.GetQuestions();

            return questionList;
        }

        private List<DialogModel> getIntroDialogs()
        {
            dialogs = new HardCodedDialogs();
            dialogs.addIntroductionDialogs();
            dialogList = dialogs.getDialogs();

            return dialogList;
        }

        // For loading the quetion

        public void loadNextQuestion()
        {
            var nextQuestion = quizManager.nextQuestion();
            if (nextQuestion != null)
            {
                questionText.GetComponent<Text>().text = nextQuestion.question;
                newsImage.sprite = Resources.Load<Sprite>("PaceBookImages/" + nextQuestion.image); //+ nextQuestion.image
            }
            else
            {
                // dO NoThInG BrO
            }
        }

        IEnumerator WriteText(string text)
        {

            writing = true;
            dialogText.text = "";
            nextDialogButton.gameObject.SetActive(false);
            previousDialogButton.gameObject.SetActive(false);
            foreach (char c in text)
            {
                dialogText.text += c;
                yield return new WaitForSeconds(0.03f);
            }
            nextDialogButton.gameObject.SetActive(true);
            if (dialogManager.currentDialog == 0)
            {
                previousDialogButton.gameObject.SetActive(false);
            }
            else {
                previousDialogButton.gameObject.SetActive(true);
            }

            writing = false;

        }

        public void loadDialog()
        {
            var dialog = dialogManager.loadDialog();

            StartCoroutine(WriteText(dialog.text));
            descImage.sprite = Resources.Load<Sprite>("PacebookImages/introductionDialog/" + dialog.descImage);
            speakerImage.sprite = Resources.Load<Sprite>("PacebookImages/introductionDialog/" + dialog.speakerImage);
        }

        public void loadNextDialog()
        {
            int next = dialogManager.currentDialog++;
            var nextDialog = dialogManager.nextDialog();
            if (nextDialog != null)
            {
                StartCoroutine(WriteText(nextDialog.text));
                descImage.sprite = Resources.Load<Sprite>("PacebookImages/introductionDialog/" + nextDialog.descImage);
                speakerImage.sprite = Resources.Load<Sprite>("PacebookImages/introductionDialog/" + nextDialog.speakerImage);
            }

            else
            {
                introductionCanvas.gameObject.SetActive(false);
                startImage.sprite = Resources.Load<Sprite>("PacebookImages/introductionDialog/Mark");
                startText.GetComponent<Text>().text = "Now you have seen what you can face while you use Pacebook, but let’s start our challenge by answering some questions about the information you have gathered.\n\n" +
                    "Press Start to begin the Pacebook’s quiz!";
                startTestCanvas.gameObject.SetActive(true);
            }
        }

        public void loadPreviousDialog()
        {
            int previous = dialogManager.currentDialog--;
            var previousDialog = dialogManager.previousDialog();
            if (previousDialog != null)
            {
                StartCoroutine(WriteText(previousDialog.text));
                descImage.sprite = Resources.Load<Sprite>("PacebookImages/introductionDialog/" + previousDialog.descImage);
                speakerImage.sprite = Resources.Load<Sprite>("PacebookImages/introductionDialog/" + previousDialog.speakerImage);
            }
        }
    }
}