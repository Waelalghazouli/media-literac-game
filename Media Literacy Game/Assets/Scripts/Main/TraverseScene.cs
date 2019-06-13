using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TraverseScene : MonoBehaviour
{
    public void SceneTraverser(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public void goToPrototype()
    {
        SceneManager.LoadScene("PrototypeScene");

    }

    public void goToMeTube()
    {
        SceneManager.LoadScene("MeTube");

    }

    public void goToOnstagram()
    {
        SceneManager.LoadScene("Onstagram");
    }

    public void goToDoodle()
    {
        SceneManager.LoadScene("DoogleQuiz");
    }

    public void goToMainGame(int xCoordinate)
    {
        SceneManager.LoadScene("PrototypeScene");
        PlayerPrefs.SetInt("XPlayer", xCoordinate);
    }
}