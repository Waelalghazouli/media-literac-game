using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeTubeScriptManager : MonoBehaviour
{
    public Canvas introductionCanvas;
    // Start is called before the first frame update
    void Start()
    {
        introductionCanvas.gameObject.SetActive(true);
    }
}
