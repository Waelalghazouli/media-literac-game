using System.Collections;
using System.Collections.Generic;


public class IntroductionManager
{
    public List<string> dialogText;

    public IntroductionManager()
    {
        dialogText = new List<string>();
    }


    public void addDialogsForIntroduction(string dialog)
    {
        dialogText.Add(dialog);
    }

}
