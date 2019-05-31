using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IntroductionManager : MonoBehaviour
{
    public Text introText;
    public Button quitButton;
    public Button mainButton;
    public Button optionsButton;
    public Canvas optionsCanvas;

    int language;

    // Start is called before the first frame update
    void Start()
    {
        optionsCanvas.gameObject.SetActive(false);

        language = PlayerPrefs.GetInt("Language");
        Debug.Log(language);
        if (language == 0)
        {
            introText.GetComponentInChildren<Text>().text = "Dit is Allen de alien. Allen wilt graag op zijn eerste dag op aarde vrienden maken. " +
                "Hiervoor heeft hij social media nodig, alleen is hij nog niet bekend met de gevaren die social media met zich mee brengen.\n\n" +
                "Daarom willen we graag jouw hulp.\n\n" +
                "Druk op Start om het avontuur van Allen te starten." ;

            quitButton.GetComponentInChildren<Text>().text = "Beëindigen";
            mainButton.GetComponentInChildren<Text>().text = "Hoofdmenu";
            optionsButton.GetComponentInChildren<Text>().text = "Instellingen";
        }

        if(language == 1)
        {
            introText.GetComponentInChildren<Text>().text = "This is the Alien. He wants to go to the earth but he has no friends, " +
                "that is why he thinks it is a good idea to use Social Media to make some friendships. " +
                "The problem is that he is not aware from the dangers while using the any Social Media Platform. That is why your help is needed for this Alien.\n\n" +
                "Click on Start to begin the journey of the Alien.";

            quitButton.GetComponentInChildren<Text>().text = "End";
            mainButton.GetComponentInChildren<Text>().text = "Main Menu";
            optionsButton.GetComponentInChildren<Text>().text = "Options";
        }
    }

   public void quitButtonClick()
    {
        Application.Quit();
    }

    public void menuButtonClick()
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void optionsButtonClick()
    {
        optionsCanvas.gameObject.SetActive(true);
    }
}
