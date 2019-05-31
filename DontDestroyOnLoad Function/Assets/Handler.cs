using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Handler : MonoBehaviour
{
    public Text scoreTxt;
    private int scort = 10;

    void Start()
    {
        scort = PlayerPrefs.GetInt("b");
        scoreTxt.text = scort.ToString();
    }
    public void goTo2()
    {
        
        scort++;
        PlayerPrefs.SetInt("b", scort);
        scoreTxt.text = scort.ToString();
        SceneManager.LoadScene("Scene2");
    }

    public void goTo1()
    {
        
        scort++;
        PlayerPrefs.SetInt("b", scort);
        scoreTxt.text = scort.ToString();
        SceneManager.LoadScene("Scene1");
    }
}
