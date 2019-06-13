﻿using Assets.Scripts.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts.Pacebook
{
    public class OnstagramScriptManager : MonoBehaviour
    {
        // Player
        public GameObject player;

        // Score manager
        ScoreManager scoreManager;
        public Text scoreText;
        int onstagramScore;
        int latestScore;

        // Question Canvas
        public Image newsImage;
        public Text questionText;
        public Text amountOfQuestionsText;

        // MultiQuestion Canvas
        public Image multiNewsImage;
        public Text multiQuestionText;
        public Text multiAmountOfQuestionsText;

        // Feedback Canvas
        public Text feedbackText;
        public Button feedbackButton;

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

        // Quiz Finished Canvas
        public Image qf_speakerImage;
        public Text qf_text;
        public Button qf_retry;
        public Button qf_nextLevel;

        // Canvases
        public Canvas questionCanvas;
        public Canvas feedbackCanvas;
        public Canvas startTestCanvas;
        public Canvas introductionCanvas;
        public Canvas quizFinishedCanvas;
        public Canvas multipleChoiceCanvas;

        HardCodedOnstagramQuestions questions;
        QuizManager quizManager;
        List<QuestionModel> questionList;

        HardCodedOnstagramDialogs dialogs;
        DialogManager dialogManager;
        List<DialogModel> dialogList;
     
        // Language
        int language;

        // Use this for initialization
        void Start()
        {
            //multiAmountOfQuestionsText = amountOfQuestionsText;

            startOnstagram();
        }

        private void startOnstagram()
        {

            PlayerPrefs.SetInt("XPlayer", 175);

            // Score manageing

            latestScore = PlayerPrefs.GetInt("Score");
            onstagramScore = PlayerPrefs.GetInt("OnstagramScore"); // hhh
            PlayerPrefs.SetInt("Score", latestScore - onstagramScore);
            PlayerPrefs.SetInt("OnstagramScore", 0); // hhh
            latestScore = PlayerPrefs.GetInt("Score");
            onstagramScore = PlayerPrefs.GetInt("OnstagramScore");
            
            scoreText.GetComponentInChildren<Text>().text = "Score: " + latestScore.ToString();

            language = PlayerPrefs.GetInt("Language");

            getQuestions();
            getIntroDialogs();
            getTheRightButtinsLanguage();

            // At the start of the scene
            introductionCanvas.gameObject.SetActive(true);
            questionCanvas.gameObject.SetActive(false);
            feedbackCanvas.gameObject.SetActive(false);
            startTestCanvas.gameObject.SetActive(false);
            quizFinishedCanvas.gameObject.SetActive(false);
            multipleChoiceCanvas.gameObject.SetActive(false);

            previousDialogButton.gameObject.SetActive(false);
            dialogManager = new DialogManager(dialogList);
            loadDialog();

            quizManager = new QuizManager(questionList);
            loadNextQuestion();

            scoreManager = new ScoreManager();
        }

        public void startButtonClick()
        {
            if (language == 0)
            {
                // Dutch
                amountOfQuestionsText.GetComponentInChildren<Text>().text = "Vragen: " + (quizManager.currentQuestion + 1).ToString() + "/" + quizManager.amountOfQuestions.ToString();
                multiAmountOfQuestionsText.GetComponentInChildren<Text>().text = "Vragen: " + (quizManager.currentQuestion + 1).ToString() + "/" + quizManager.amountOfQuestions.ToString();
            }
            if (language == 1)
            {
                // English
                amountOfQuestionsText.GetComponentInChildren<Text>().text = "Question: " + (quizManager.currentQuestion + 1).ToString() + "/" + quizManager.amountOfQuestions.ToString();
                multiAmountOfQuestionsText.GetComponentInChildren<Text>().text = "Question: " + (quizManager.currentQuestion + 1).ToString() + "/" + quizManager.amountOfQuestions.ToString();

            }

            loadNextQuestion();

            startTestCanvas.gameObject.SetActive(false);
            feedbackCanvas.gameObject.SetActive(false);
            questionCanvas.gameObject.SetActive(false);
            multipleChoiceCanvas.gameObject.SetActive(true);

        }

        public void firstButtonClick()
        {
            bool answeredCorrectly = false;
            int choice = 1;
            var feedback = questionList[quizManager.currentQuestion].feedback;

            if (questionList[quizManager.currentQuestion].choice == choice)
            {
                answeredCorrectly = true;
                quizManager.score = quizManager.score + questionList[quizManager.currentQuestion].score;
                quizManager.currentQuestion++;
                quizManager.currentAnswer++;
            }
            else
            {
                answeredCorrectly = false;
                quizManager.currentQuestion++;
            }
            multipleChoiceCanvas.gameObject.SetActive(false);

            if (answeredCorrectly)
            {
                scoreManager.latestScore = quizManager.score;
                onstagramScore = PlayerPrefs.GetInt("OnstagramScore");
                this.onstagramScore = quizManager.score;
                scoreText.GetComponentInChildren<Text>().text = "Score: " + (latestScore + scoreManager.latestScore).ToString();
                PlayerPrefs.SetInt("OnstagramScore", scoreManager.latestScore);
                onstagramScore = PlayerPrefs.GetInt("OnstagramScore");

                if (language == 0)
                {
                    // Dutch
                    feedbackText.text = "Jouw antwoord is goed. " + feedback;
                }

                if (language == 1)
                {
                    // English
                    feedbackText.text = "Your answer is correct. " + feedback;
                }
            }
            else
            {
                if (language == 0)
                {
                    // Dutch
                    feedbackText.text = "Jouw antwoord is niet goed. " + feedback;

                }

                if (language == 1)
                {
                    // English
                    feedbackText.text = "Your answer is incorrect. " + feedback;
                }
            }
            feedbackCanvas.gameObject.SetActive(true);
        }

        public void secondButtonClick()
        {
            bool answeredCorrectly = false;
            int choice = 2;
            var feedback = questionList[quizManager.currentQuestion].feedback;

            if (questionList[quizManager.currentQuestion].choice == choice)
            {
                answeredCorrectly = true;
                quizManager.score = quizManager.score + questionList[quizManager.currentQuestion].score;
                quizManager.currentQuestion++;
                quizManager.currentAnswer++;
            }
            else
            {
                answeredCorrectly = false;
                quizManager.currentQuestion++;
            }
            multipleChoiceCanvas.gameObject.SetActive(false);

            if (answeredCorrectly)
            {
                scoreManager.latestScore = quizManager.score;
                onstagramScore = PlayerPrefs.GetInt("OnstagramScore");
                this.onstagramScore = quizManager.score;
                scoreText.GetComponentInChildren<Text>().text = "Score: " + (latestScore + scoreManager.latestScore).ToString();
                PlayerPrefs.SetInt("OnstagramScore", scoreManager.latestScore);
                onstagramScore = PlayerPrefs.GetInt("OnstagramScore");

                if (language == 0)
                {
                    // Dutch
                    feedbackText.text = "Jouw antwoord is goed. " + feedback;

                }

                if (language == 1)
                {
                    // English
                    feedbackText.text = "Your answer is correct. " + feedback;
                }
            }
            else
            {
                if (language == 0)
                {
                    // Dutch
                    feedbackText.text = "Jouw antwoord is niet goed. " + feedback;

                }

                if (language == 1)
                {
                    // English
                    feedbackText.text = "Your answer is incorrect. " + feedback;
                }
            }
            feedbackCanvas.gameObject.SetActive(true);
        }

        public void thirdButtonClick()
        {
            bool answeredCorrectly = false;
            int choice = 3;
            var feedback = questionList[quizManager.currentQuestion].feedback;


            if (questionList[quizManager.currentQuestion].choice == choice)
            {
                answeredCorrectly = true;
                quizManager.score = quizManager.score + questionList[quizManager.currentQuestion].score;
                quizManager.currentQuestion++;
                quizManager.currentAnswer++;
            }
            else
            {
                answeredCorrectly = false;
                quizManager.currentQuestion++;
            }
            multipleChoiceCanvas.gameObject.SetActive(false);

            if (answeredCorrectly)
            {
                scoreManager.latestScore = quizManager.score;
                onstagramScore = PlayerPrefs.GetInt("OnstagramScore");
                this.onstagramScore = quizManager.score;
                scoreText.GetComponentInChildren<Text>().text = "Score: " + (latestScore + scoreManager.latestScore).ToString();
                PlayerPrefs.SetInt("OnstagramScore", scoreManager.latestScore);
                onstagramScore = PlayerPrefs.GetInt("OnstagramScore");

                if (language == 0)
                {
                    // Dutch
                    feedbackText.text = "Jouw antwoord is goed. " + feedback;

                }

                if (language == 1)
                {
                    // English
                    feedbackText.text = "Your answer is correct. " + feedback;
                }
            }
            else
            {
                if (language == 0)
                {
                    // Dutch
                    feedbackText.text = "Jouw antwoord is niet goed. " + feedback;

                }

                if (language == 1)
                {
                    // English
                    feedbackText.text = "Your answer is incorrect. " + feedback;
                }
            }
            feedbackCanvas.gameObject.SetActive(true);
        }

        public void rightButtonClick()
        {
            bool answeredCorrectly = false;

            answeredCorrectly = quizManager.answerQuestion(true);
            questionCanvas.gameObject.SetActive(false);

            if (answeredCorrectly)
            {
                scoreManager.latestScore = quizManager.score;
                onstagramScore = PlayerPrefs.GetInt("OnstagramScore");
                this.onstagramScore = quizManager.score;
                scoreText.GetComponentInChildren<Text>().text = "Score: " + (latestScore + scoreManager.latestScore).ToString();
                PlayerPrefs.SetInt("OnstagramScore", scoreManager.latestScore);
                onstagramScore = PlayerPrefs.GetInt("OnstagramScore");


                if (language == 0)
                {
                    // Dutch
                    feedbackText.text = "Jouw antwoord is goed. " + quizManager.currentFeedback;

                }

                if (language == 1)
                {
                    // English
                    feedbackText.text = "Your answer is correct. " + quizManager.currentFeedback;
                }
            }
            else
            {
                if (language == 0)
                {
                    // Dutch
                    feedbackText.text = "Jouw antwoord is niet goed. " + quizManager.currentFeedback;

                }

                if (language == 1)
                {
                    // English
                    feedbackText.text = "Your answer is incorrect. " + quizManager.currentFeedback;
                }
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
                scoreManager.latestScore = quizManager.score;
                onstagramScore = PlayerPrefs.GetInt("OnstagramScore");
                this.onstagramScore = quizManager.score;
                scoreText.GetComponentInChildren<Text>().text = "Score: " + (latestScore + scoreManager.latestScore).ToString();
                PlayerPrefs.SetInt("OnstagramScore", scoreManager.latestScore);
                onstagramScore = PlayerPrefs.GetInt("OnstagramScore");

                if (language == 0)
                {
                    // Dutch
                    feedbackText.text = "Jouw antwoord is goed. " + quizManager.currentFeedback;

                }

                if (language == 1)
                {
                    // English
                    feedbackText.text = "Your answer is correct. " + quizManager.currentFeedback;
                }
            }
            else
            {
                if (language == 0)
                {
                    // Dutch
                    feedbackText.text = "Jouw antwoord is niet goed. " + quizManager.currentFeedback;

                }

                if (language == 1)
                {
                    // English
                    feedbackText.text = "Your answer is incorrect. " + quizManager.currentFeedback;
                }
            }
            feedbackCanvas.gameObject.SetActive(true);
        }

        public void nextQuestionButtonClick()
        {
            var nextQuestion = quizManager.nextQuestion();


            if (quizManager.currentQuestion < quizManager.amountOfQuestions)
            {
                loadNextQuestion();
                if (language == 0) // Dutch
                {
                    amountOfQuestionsText.GetComponentInChildren<Text>().text = "Vragen: " + (quizManager.currentQuestion + 1).ToString() + "/" + quizManager.amountOfQuestions.ToString();
                    multiAmountOfQuestionsText.GetComponentInChildren<Text>().text = "Vragen: " + (quizManager.currentQuestion + 1).ToString() + "/" + quizManager.amountOfQuestions.ToString();
                }
                if (language == 1) // English
                {
                    amountOfQuestionsText.GetComponentInChildren<Text>().text = "Question: " + (quizManager.currentQuestion + 1).ToString() + "/" + quizManager.amountOfQuestions.ToString();
                    multiAmountOfQuestionsText.GetComponentInChildren<Text>().text = "Vragen: " + (quizManager.currentQuestion + 1).ToString() + "/" + quizManager.amountOfQuestions.ToString();
                }

                feedbackCanvas.gameObject.SetActive(false);

                if (questionList[quizManager.currentQuestion].choice == 0)
                {
                    questionCanvas.gameObject.SetActive(true);
                }
                else
                {
                    multipleChoiceCanvas.gameObject.SetActive(true);
                }

            }

            else
            {
                qf_speakerImage.sprite = Resources.Load<Sprite>("PacebookImages/introductionDialog/Mark");
                if (quizManager.score >= 60)
                {
                    if (language == 0) // Dutch
                    {
                        qf_text.GetComponentInChildren<Text>().text = "Goed gedaan! Jouw behaalde score voor de Pacebook uitdaging is: " + scoreManager.latestScore.ToString() +
                        ". Het is absoluut mogelijk om de uitdaging weer te maken.";
                    }
                    if (language == 1) // English
                    {
                        qf_text.GetComponentInChildren<Text>().text = "Well done! Your score for the Pacebook's challenge is: " + scoreManager.latestScore.ToString() +
                            ". It is also possible to retry the challenge again.";
                    }

                }
                else
                {
                    if (language == 0) // Dutch
                    {
                        qf_text.GetComponentInChildren<Text>().text = "Goed gedaan! Jouw behaalde score voor de Pacebook uitdaging is: " + scoreManager.latestScore.ToString() +
                            ". Het kan absoluut beter zijn in de volgende keer\n\n" +
                            "Je kan nu durkken op Next om door te gaan naar het andere niveau of op Retry om deze uitdaging nog een keer te maken.";
                    }

                    if (language == 1) // English
                    {
                        qf_text.GetComponentInChildren<Text>().text = "Well done! Your score for the Pacebook's challenge is: " + scoreManager.latestScore.ToString() +
                            ". It can absolutley be better in the next time\n\n" +
                            "You can now continue to the next level or retry this challenge!";
                    }
                }
                feedbackCanvas.gameObject.SetActive(false);
                quizFinishedCanvas.gameObject.SetActive(true);
            }
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

        private List<QuestionModel> getQuestions()
        {
            if (language == 1)
            {
                questions = new HardCodedOnstagramQuestions();
                questions.addQuestions();
                questionList = questions.GetQuestions();
            }

            if (language == 0)
            {
                questions = new HardCodedOnstagramQuestions();
                questions.addDutchQuestions();
                questionList = questions.GetQuestions();
            }

            return questionList;
        }

        private List<DialogModel> getIntroDialogs()
        {
            if (language == 1) // English
            {
                dialogs = new HardCodedOnstagramDialogs();
                dialogs.addIntroductionDialogs();
                dialogList = dialogs.getDialogs();
            }

            if (language == 0) // Dutch
            {
                dialogs = new HardCodedOnstagramDialogs();
                dialogs.addDutchIntroductionDialogs();
                dialogList = dialogs.getDialogs();
            }


            return dialogList;
        }

        // For loading the question

        public void loadNextQuestion()
        {
            var nextQuestion = quizManager.nextQuestion();
            if (nextQuestion != null)
            {
                if (questionList[quizManager.currentQuestion].choice != 0)
                {
                    multiQuestionText.GetComponent<Text>().text = nextQuestion.question;
                    multiNewsImage.sprite = Resources.Load<Sprite>("OnstagramImages/" + nextQuestion.image);
                    Debug.Log(nextQuestion.image);
                    Debug.Log(multiNewsImage.sprite);
                }
                else
                {
                    questionText.GetComponent<Text>().text = nextQuestion.question;
                    newsImage.sprite = Resources.Load<Sprite>("OnstagramImages/" + nextQuestion.image);
                }


            }
        }

        public void retryQuizeChallengeClickButton()
        {
            quizManager.score = 0;
            quizManager.startQuiz();
  
            quizFinishedCanvas.gameObject.SetActive(false);
            questionCanvas.gameObject.SetActive(false);
            multipleChoiceCanvas.gameObject.SetActive(true);



        }

        public void backToPrototypeClickButton()
        {
            PlayerPrefs.SetInt("Score", onstagramScore + latestScore);
            SceneManager.LoadScene("PrototypeScene");
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
            else
            {
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
                if (language == 1)
                {
                    startText.GetComponent<Text>().text = "Now you have seen what you can face while you use Onstagram, but let’s start our challenge by answering some questions about the information you have gathered.\n\n" +
                       "Press Start to begin the Onstagram’s quiz!";
                }

                if (language == 0)
                {
                    startText.GetComponent<Text>().text = "Je hebt nu gezien wat je kan verwachten om tegen te komen op Onstagram, maar nu is het de tijd om een uitdaging te beginnen door een paar vragen te " +
                        "beantwoorden gebaseerd op de verworven informatie.\n\n" +
                        "Klik op Start om de toets van Onstagram te beginnen!";
                }

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

        public void getTheRightButtinsLanguage()
        {
            if (language == 0)  // Dutch
            {
                feedbackButton.GetComponentInChildren<Text>().text = "Volgende";
                qf_retry.GetComponentInChildren<Text>().text = "Toets Hermaken";
                qf_nextLevel.GetComponentInChildren<Text>().text = "Toets verlaten";
                nextDialogButton.GetComponentInChildren<Text>().text = "Volgende";
                previousDialogButton.GetComponentInChildren<Text>().text = "Vorige";
            }

            if (language == 1)
            {
                feedbackButton.GetComponentInChildren<Text>().text = "Next";
                qf_retry.GetComponentInChildren<Text>().text = "Retry";
                qf_nextLevel.GetComponentInChildren<Text>().text = "Next Level";
                nextDialogButton.GetComponentInChildren<Text>().text = "Next";
                previousDialogButton.GetComponentInChildren<Text>().text = "Previous";
            }
        }
    }
}