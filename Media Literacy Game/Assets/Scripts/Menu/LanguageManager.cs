using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanguageManager : MonoBehaviour
{
    public Button playButton;
    public Button optionsButton;
    public Button quitButton;

    int language = 0;

    // Start is called before the first frame update
    void Start()
    {
        // it's English on default
        englishButtonClick();
    }

    // Update is called once per frame
    public void dutchButtonClick()
    {
        PlayerPrefs.SetInt("Language", 0);
        language = PlayerPrefs.GetInt("Language");
        Debug.Log(language);
        playButton.GetComponentInChildren<Text>().text = "Spelen";
        optionsButton.GetComponentInChildren<Text>().text = "Instellingen";
        quitButton.GetComponentInChildren<Text>().text = "Beëindigen";

    }

    public void englishButtonClick()
    {
        PlayerPrefs.SetInt("Language", 1);
        language = PlayerPrefs.GetInt("Language");
        Debug.Log(language);
        playButton.GetComponentInChildren<Text>().text = "Play";
        optionsButton.GetComponentInChildren<Text>().text = "Options";
        quitButton.GetComponentInChildren<Text>().text = "Quit";
    }
}
