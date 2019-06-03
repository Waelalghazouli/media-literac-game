using Assets.Scripts.MeTube;
using Assets.Scripts.Models;
using Assets.Scripts.Pacebook;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroductionMeTubeManager : MonoBehaviour
{
    // Dialogue
    public Image speakerImage;
    public Image descImage;
    public Text dialogText;
    public Button nextButton;
    public Button previousButton;

    HardCodedDialogsMeTube dialogs;
    DialogManager dialogManager;
    List<DialogModel> dialogList;
    bool writing;

    // Start Test Canvas
    public Image steveImage;
    public Text startText;

    // Canvases
    public Canvas introductionCanvas;
    public Canvas startTestCanvas;

    int language;

    // Start is called before the first frame update
    void Start()
    {
        language = PlayerPrefs.GetInt("Language");

        startDialog();
    }

    private void startDialog()
    {
        introductionCanvas.gameObject.SetActive(true);
        startTestCanvas.gameObject.SetActive(false);
        getTheRightButtinsLanguage();
        getIntroDialogs();
        previousButton.gameObject.SetActive(false);
        dialogManager = new DialogManager(dialogList);
        loadDialog();

    }

    private List<DialogModel> getIntroDialogs()
    {
        if (language == 1) // English
        {
            dialogs = new HardCodedDialogsMeTube();
            dialogs.addIntroductionDialogs();
            dialogList = dialogs.getDialogs();
        }

        if (language == 0) // Dutch
        {
            dialogs = new HardCodedDialogsMeTube();
            dialogs.addDutchIntroductionDialogs();
            dialogList = dialogs.getDialogs();
        }


        return dialogList;
    }

    public void loadDialog()
    {
        var dialog = dialogManager.loadDialog();

        previousButton.gameObject.SetActive(false);

        StartCoroutine(WriteText(dialog.text));
        descImage.sprite = Resources.Load<Sprite>("MeTube/MeTubeDialogImages/" + dialog.descImage);
        speakerImage.sprite = Resources.Load<Sprite>("MeTube/MeTubeDialogImages/" + dialog.speakerImage);
    }

    IEnumerator WriteText(string text)
    {

        writing = true;
        dialogText.text = "";
        nextButton.gameObject.SetActive(false);
        previousButton.gameObject.SetActive(false);
        foreach (char c in text)
        {
            dialogText.text += c;
            yield return new WaitForSeconds(0.03f);
        }
        nextButton.gameObject.SetActive(true);
        if (dialogManager.currentDialog == 0)
        {
            previousButton.gameObject.SetActive(false);
        }
        else
        {
            previousButton.gameObject.SetActive(true);
        }

        writing = false;

    }

    public void loadNextDialog()
    {
        int next = dialogManager.currentDialog++;
        var nextDialog = dialogManager.nextDialog();
        if (nextDialog != null)
        {
            StartCoroutine(WriteText(nextDialog.text));
            descImage.sprite = Resources.Load<Sprite>("MeTube/MeTubeDialogImages/" + nextDialog.descImage);
            speakerImage.sprite = Resources.Load<Sprite>("MeTube/MeTubeDialogImages/" + nextDialog.speakerImage);
        }

        else
        {
            introductionCanvas.gameObject.SetActive(false);
            steveImage.sprite = Resources.Load<Sprite>("MeTube/MeTubeDialogImages/Steve");
            if (language == 1)
            {
                startText.GetComponent<Text>().text = "Now you have got an idea what MeTube is and what kind of puposes it has, but let's start our challenge by answering some questions about " +
                "the information you have gathered through our tour. Are you ready for it?\n\n" +
                "Click on Start if you are ready!";
            }

            if (language == 0)
            {
                startText.GetComponent<Text>().text = "Nu jij een idee hebt kunnen verwerven over wat je op MeTube kan tegenkomen, wil ik jou uitdagen door een paar vragen te beantwoorden, " +
                    "ben je er klaar voor?\n\n" +
                    "Klik op Start om de uitdaging van MeTube te beginnen!";
            }
            startTestCanvas.gameObject.SetActive(true);
        }
    }

    public void nextDialogButtonClick()
    {
        Debug.Log("Amount of dialogues: " + dialogManager.amountOfDialogs());

        var nextDialog = dialogManager.nextDialog();

        previousButton.gameObject.SetActive(true);

        if (dialogManager.currentDialog < dialogManager.amountOfDialogs())
        {
            loadNextDialog();
        }
    }

    public void previousDialogButtonClick()
    {
        Debug.Log("Amount of dialogues: " + dialogManager.amountOfDialogs());

        var previousDialog = dialogManager.previousDialog();

        if (dialogManager.currentDialog >= 1)
        {
            loadPreviousDialog();
        }
    }

    public void loadPreviousDialog()
    {
        int previous = dialogManager.currentDialog--;
        var previousDialog = dialogManager.previousDialog();
        if (previousDialog != null)
        {
            StartCoroutine(WriteText(previousDialog.text));
            descImage.sprite = Resources.Load<Sprite>("MeTube/MeTubeDialogImages/" + previousDialog.descImage);
            speakerImage.sprite = Resources.Load<Sprite>("MeTube/MeTubeDialogImages/" + previousDialog.speakerImage);
        }
    }

    public void getTheRightButtinsLanguage()
    {
        if (language == 0)  // Dutch
        {
            nextButton.GetComponentInChildren<Text>().text = "Volgende";
            previousButton.GetComponentInChildren<Text>().text = "Vorige";
        }

        if (language == 1)
        {
            nextButton.GetComponentInChildren<Text>().text = "Next";
            previousButton.GetComponentInChildren<Text>().text = "Previous";
        }
    }
}
