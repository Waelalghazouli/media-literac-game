using Assets.Scripts.MeTube;
using Assets.Scripts.Models;
using Assets.Scripts.Pacebook;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionManager : MonoBehaviour
{
    // Question Panel
    public Image newsImage;
    public Text questionText;
    public Text amountOfQuestionsText;
    public Button trueButton;
    public Button falseButton;

    // Feedback Panel
    public Text feedbackText;
    public Button feedbackButton;

    // Panels
    public GameObject questionPanel;
    public GameObject feedbackPanel;

    // Questions with Feedbacks
    HardCodedQuestionsMeTube questions;
    QuizManager quizManager;
    List<QuestionModel> questionList;

    // Score manager
    ScoreManager scoreManager;
    public Text score;
    int latestScort;

    // Canvases
    public Canvas questionCanvas;
    public Canvas startTestCanvas;

    int language;

    // Start is called before the first frame update
    void Start()
    {
        language = PlayerPrefs.GetInt("Language");
        startQuiz();
    }

    private void startQuiz()
    {
        questionPanel.SetActive(true);
        feedbackPanel.SetActive(false);
        getQuestions();
        quizManager = new QuizManager(questionList);
        loadNextQuestion();

    }

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

        }
    }

    public void trueButtonClick()
    {
        bool answeredCorrectly = false;

        answeredCorrectly = quizManager.answerQuestion(true);
        questionPanel.gameObject.SetActive(false);

        if (answeredCorrectly)
        {
            scoreManager.latestScore = quizManager.score;
            this.latestScort = quizManager.score;
            score.GetComponentInChildren<Text>().text = "Score: " + scoreManager.latestScore.ToString();

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
        feedbackPanel.gameObject.SetActive(true);
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
            }
            if (language == 1) // English
            {
                amountOfQuestionsText.GetComponentInChildren<Text>().text = "Question: " + (quizManager.currentQuestion + 1).ToString() + "/" + quizManager.amountOfQuestions.ToString();
            }

            feedbackPanel.gameObject.SetActive(false);
            questionPanel.gameObject.SetActive(true);
        }


        //else
        //{
        //    qf_speakerImage.sprite = Resources.Load<Sprite>("PacebookImages/introductionDialog/Mark");
        //    if (quizManager.score >= 60)
        //    {
        //        if (language == 0) // Dutch
        //        {
        //            qf_text.GetComponentInChildren<Text>().text = "Goed gedaan! Jouw behaalde score voor de Pacebook uitdaging is: " + scoreManager.latestScore.ToString() +
        //            ". Het is absoluut mogelijk om de uitdaging weer te maken.";
        //        }
        //        if (language == 1) // English
        //        {
        //            qf_text.GetComponentInChildren<Text>().text = "Well done! Your score for the Pacebook's challenge is: " + scoreManager.latestScore.ToString() +
        //                ". It is also possible to retry the challenge again.";
        //        }

        //    }
        //    else
        //    {
        //        if (language == 0) // Dutch
        //        {
        //            qf_text.GetComponentInChildren<Text>().text = "Goed gedaan! Jouw behaalde score voor de Pacebook uitdaging is: " + scoreManager.latestScore.ToString() +
        //                ". Het kan absoluut beter zijn in de volgende keer\n\n" +
        //                "Je kan nu durkken op Next om door te gaan naar het andere niveau of op Retry om deze uitdaging nog een keer te maken.";
        //        }

        //        if (language == 1) // English
        //        {
        //            qf_text.GetComponentInChildren<Text>().text = "Well done! Your score for the Pacebook's challenge is: " + scoreManager.latestScore.ToString() +
        //                ". It can absolutley be better in the next time\n\n" +
        //                "You can now continue to the next level or retry this challenge!";
        //        }
        //    }
        //    feedbackCanvas.gameObject.SetActive(false);
        //    quizFinishedCanvas.gameObject.SetActive(true);
        //}
    }

    public void falseButtonClick()
    {
        bool answeredCorrectly = false;

        answeredCorrectly = quizManager.answerQuestion(false);
        questionPanel.gameObject.SetActive(false);

        if (answeredCorrectly)
        {
            scoreManager.latestScore = quizManager.score;
            this.latestScort = quizManager.score;
            score.GetComponentInChildren<Text>().text = "Score: " + scoreManager.latestScore.ToString();

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
        feedbackPanel.gameObject.SetActive(true);
    }



    public List<QuestionModel> getQuestions()
    {
        if (language == 1)
        {
            questions = new HardCodedQuestionsMeTube();
            questions.addQuestions();
            questionList = questions.GetQuestions();
        }

        if (language == 0)
        {
            questions = new HardCodedQuestionsMeTube();
            questions.addDutchQuestions();
            questionList = questions.GetQuestions();
        }

        return questionList;
    }

    public void startButtonClick()
    {
        questionPanel.SetActive(true);
        feedbackPanel.SetActive(false);
        questionCanvas.gameObject.SetActive(true);
        startTestCanvas.gameObject.SetActive(false);
        if (language == 0)
        {
            // Dutch
            amountOfQuestionsText.GetComponentInChildren<Text>().text = "Vragen: " + (quizManager.currentQuestion + 1).ToString() + "/" + quizManager.amountOfQuestions.ToString();
        }
        if (language == 1)
        {
            // English
            amountOfQuestionsText.GetComponentInChildren<Text>().text = "Question: " + (quizManager.currentQuestion + 1).ToString() + "/" + quizManager.amountOfQuestions.ToString();
        }
        loadNextQuestion();
    }
}