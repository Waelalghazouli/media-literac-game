using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IntroductionManager : MonoBehaviour
{
    public Text introText;

    int language;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Score", 0);
        PlayerPrefs.SetInt("XPlayer", -10);

        language = PlayerPrefs.GetInt("Language");
        Debug.Log(language);
        if (language == 0)
        {
            introText.GetComponentInChildren<Text>().text = "Dit is Allen de alien. Allen wilt graag op zijn eerste dag op aarde vrienden maken. " +
                "Hiervoor heeft hij social media nodig, alleen is hij nog niet bekend met de gevaren die social media met zich mee brengen.\n\n" +
                "Daarom willen we graag jouw hulp.\n\n" +
                "Druk op Start om het avontuur van Allen te starten." ;
            
        }

        if(language == 1)
        {
            introText.GetComponentInChildren<Text>().text = "This is the Alien. He wants to go to the earth but he has no friends, " +
                "that is why he thinks it is a good idea to use Social Media to make some friendships. " +
                "The problem is that he is not aware from the dangers while using the any Social Media Platform. That is why your help is needed for this Alien.\n\n" +
                "Click on Start to begin the journey of the Alien.";
        }
    }
}
