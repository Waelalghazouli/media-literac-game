using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TraverseScene : MonoBehaviour
{
    public void SceneTraverser(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
        Debug.Log("CLICK!");
    }
}
