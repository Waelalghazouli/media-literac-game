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
        introductionCanvas.gameObject.SetActive(true);
        questionCanvas.gameObject.SetActive(false);
        startQuizCanvas.gameObject.SetActive(false);
        quizFinishedCanvas.gameObject.SetActive(false);
    }
}
