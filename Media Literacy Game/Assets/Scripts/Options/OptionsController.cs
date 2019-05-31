using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    public Button quitButton;
    public Button mainButton;
    public Button optionsButton;
    public Canvas optionsCanvas;

    public Text ensuringQuitText;
    public Text ensuringMenuText;

    public Button quitNo;
    public Button quitYes;

    public Button menuNo;
    public Button menuYes;

    public GameObject ensuringQuitPanel;
    public GameObject ensuringMenuPanel;
    public GameObject optionsPanel;

    int language;

    // Start is called before the first frame update
    void Start()
    {
        language = PlayerPrefs.GetInt("Language");
        optionsCanvas.gameObject.SetActive(false);
        getTheRightButtonLanguage();
        setTheRightTextLanguage();

    }

    public void getTheRightButtonLanguage()
    {
        if (language == 0)
        {
            quitButton.GetComponentInChildren<Text>().text = "Beëindigen";
            mainButton.GetComponentInChildren<Text>().text = "Hoofdmenu";
            optionsButton.GetComponentInChildren<Text>().text = "Instellingen";
            quitNo.GetComponentInChildren<Text>().text = "Nee";
            quitYes.GetComponentInChildren<Text>().text = "Ja";
            menuNo.GetComponentInChildren<Text>().text = "Nee";
            menuYes.GetComponentInChildren<Text>().text = "Ja";
        }

        if (language == 1)
        {
            quitButton.GetComponentInChildren<Text>().text = "End";
            mainButton.GetComponentInChildren<Text>().text = "Main Menu";
            optionsButton.GetComponentInChildren<Text>().text = "Options";
            quitNo.GetComponentInChildren<Text>().text = "No";
            quitYes.GetComponentInChildren<Text>().text = "Yes";
            menuNo.GetComponentInChildren<Text>().text = "No";
            menuYes.GetComponentInChildren<Text>().text = "Yes";
        }
    }

    public void setTheRightTextLanguage()
    {
        if (language == 0) //Dutch
        {
            ensuringQuitText.GetComponentInChildren<Text>().text = "Als je het spel beëindigt, verlies je je score!\n\n" +
                "Weet je zeker dat je het spel wilt beëindigen?";
            ensuringMenuText.GetComponentInChildren<Text>().text = "Als je naar het hoofdmenu gaat, verlies je je score!\n\n" +
                "Weet je zeker dat je het spel wilt beëindigen?";
        }

        if (language == 1) // English
        {
            ensuringQuitText.GetComponentInChildren<Text>().text = "If you end the game, you will lose your score!\n\n" +
                "Are you sure you want to continue?";
            ensuringMenuText.GetComponentInChildren<Text>().text = "If you go to the main menu, you will lose your score!\n\n" +
                "Are you sure you want to continue?";
        }
    }

    public void quitButtonClick()
    {
        ensuringQuitPanel.SetActive(true);
        ensuringMenuPanel.SetActive(false);
        optionsPanel.SetActive(false);
    }

    public void ensuredQuitButtonClick()
    {
        Application.Quit();
    }

    public void noButtonClick()
    {
        ensuringQuitPanel.SetActive(false);
        optionsPanel.SetActive(true);
    }

    public void menuButtonClick()
    {
        ensuringQuitPanel.SetActive(false);
        ensuringMenuPanel.SetActive(true);
        optionsPanel.SetActive(false);
    }

    public void ensuredMenuButtonClick()
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void optionsButtonClick()
    {
        ensuringQuitPanel.SetActive(false);
        optionsPanel.SetActive(true);
        optionsCanvas.gameObject.SetActive(true);
    }
    public void closeButtonClick()
    {
        optionsCanvas.gameObject.SetActive(false);

    }
}
