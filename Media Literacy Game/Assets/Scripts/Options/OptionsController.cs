using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    public Button quitButton;
    public Button mainButton;
    public Button mainPathButton;
    public Canvas optionsCanvas;

    public Text ensuringQuitText;
    public Text ensuringMenuText;
    public Text ensuringPathText;

    public Button quitNo;
    public Button quitYes;

    public Button menuNo;
    public Button menuYes;

    public Button pathNo;
    public Button pathYes;

    public GameObject ensuringQuitPanel;
    public GameObject ensuringMenuPanel;
    public GameObject ensuringPathPanel;
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
        if (language == 0) //Dutch
        {
            quitButton.GetComponentInChildren<Text>().text = "Beëindigen";
            mainButton.GetComponentInChildren<Text>().text = "Hoofdmenu";
            mainPathButton.GetComponentInChildren<Text>().text = "Hoofdgang";
            quitNo.GetComponentInChildren<Text>().text = "Nee";
            quitYes.GetComponentInChildren<Text>().text = "Ja";
            menuNo.GetComponentInChildren<Text>().text = "Nee";
            menuYes.GetComponentInChildren<Text>().text = "Ja";
            pathNo.GetComponentInChildren<Text>().text = "Nee";
            pathYes.GetComponentInChildren<Text>().text = "Ja";
        }

        if (language == 1) // English
        {
            quitButton.GetComponentInChildren<Text>().text = "End";
            mainButton.GetComponentInChildren<Text>().text = "Main Menu";
            mainPathButton.GetComponentInChildren<Text>().text = "Main Path";
            quitNo.GetComponentInChildren<Text>().text = "No";
            quitYes.GetComponentInChildren<Text>().text = "Yes";
            menuNo.GetComponentInChildren<Text>().text = "No";
            menuYes.GetComponentInChildren<Text>().text = "Yes";
            pathNo.GetComponentInChildren<Text>().text = "No";
            pathYes.GetComponentInChildren<Text>().text = "Yes";
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
            ensuringPathText.GetComponentInChildren<Text>().text = "Als je naar de hoofdgang gaat, verlies je je score!\n\n" +
                "Weet je zeler dat je naar de hoofdgang wilt gaan?";
        }

        if (language == 1) // English
        {
            ensuringQuitText.GetComponentInChildren<Text>().text = "If you end the game, you will lose your score!\n\n" +
                "Are you sure you want to continue?";
            ensuringMenuText.GetComponentInChildren<Text>().text = "If you go to the main menu, you will lose your score!\n\n" +
                "Are you sure you want to continue?";
            ensuringPathText.GetComponentInChildren<Text>().text = "If you go to the main path, you will lose your score!\n\n" +
                "Are you sure you want to continue?";
        }
    }

    public void quitButtonClick()
    {
        ensuringQuitPanel.SetActive(true);
        ensuringMenuPanel.SetActive(false);
        optionsPanel.SetActive(false);
        ensuringPathPanel.SetActive(false);
    }

    public void mainPathButtonClick()
    {
        ensuringPathPanel.SetActive(true);
        ensuringQuitPanel.SetActive(false);
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
        ensuringPathPanel.SetActive(false);
        ensuringMenuPanel.SetActive(false);
        optionsPanel.SetActive(true);
    }

    public void menuButtonClick()
    {
        ensuringQuitPanel.SetActive(false);
        ensuringMenuPanel.SetActive(true);
        optionsPanel.SetActive(false);
        ensuringPathPanel.SetActive(false);
    }

    public void ensuredMenuButtonClick()
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void optionsButtonClick()
    {
        ensuringQuitPanel.SetActive(false);
        ensuringPathPanel.SetActive(false);
        ensuringMenuPanel.SetActive(false);
        optionsPanel.SetActive(true);
        optionsCanvas.gameObject.SetActive(true);
    }
    public void closeButtonClick()
    {
        optionsCanvas.gameObject.SetActive(false);
    }

    public void ensuredPathButtonClick()
    {
        SceneManager.LoadScene("PrototypeScene");
    }
}