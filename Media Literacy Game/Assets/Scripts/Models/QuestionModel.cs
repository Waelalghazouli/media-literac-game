using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionModel
{

    public int questionId { get; set; }
    public string question { get; set; }
    public string feedback { get; set; }
    public bool rightAnswer { get; set; }
    public int score { get; set; }

    // for later if we need to analyse the right answers
    public int goodAnswers;
    public int faultAnswer;

    public QuestionModel(int questionId, string question, string feedback, bool rightAnswer, int score)
    {
        this.questionId = questionId;
        this.question = question;
        this.feedback = feedback;
        this.rightAnswer = rightAnswer;
        this.score = score;
    }
}