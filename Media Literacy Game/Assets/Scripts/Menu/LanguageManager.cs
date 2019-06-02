using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanguageManager : MonoBehaviour
{
    public Button playButton;
    public Button optionsButton;
    public Button quitButton;

    public Button DutchFlag;
    public Button BritishFlag;

    int language = 0;

    // Start is called before the first frame update
    void Start()
    {
        language = PlayerPrefs.GetInt("Language");

        if (language == 0) // Dutch
        {
            englishButtonClick();
        }
        else // Englsih
        {
            dutchButtonClick();
        }

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

        // Handle the darkness of the flag
        BritishFlag.image.color = Color.white;
        DutchFlag.image.color = Color.grey;
    }

    public void englishButtonClick()
    {
        PlayerPrefs.SetInt("Language", 1);
        language = PlayerPrefs.GetInt("Language");
        Debug.Log(language);
        playButton.GetComponentInChildren<Text>().text = "Play";
        optionsButton.GetComponentInChildren<Text>().text = "Options";
        quitButton.GetComponentInChildren<Text>().text = "Quit";

        // Handle the darkness of the flag
        DutchFlag.image.color = Color.white;
        BritishFlag.image.color = Color.grey;
    }
}
