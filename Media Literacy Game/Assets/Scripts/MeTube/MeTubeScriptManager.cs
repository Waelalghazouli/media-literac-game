using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeTubeScriptManager : MonoBehaviour
{
    public Canvas introductionCanvas;
    public Canvas questionCanvas;
    public Canvas startQuizCanvas;
    public Canvas quizFinishedCanvas;

    // Start is called before the first frame update
    void Start()
    {
        introductionCanvas.gameObject.SetActive(false);
        questionCanvas.gameObject.SetActive(true);
        startQuizCanvas.gameObject.SetActive(false);
        quizFinishedCanvas.gameObject.SetActive(false);
    }
}
