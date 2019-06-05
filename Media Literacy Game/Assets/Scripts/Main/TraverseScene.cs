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
}