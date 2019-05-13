using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TraverScene : MonoBehaviour
{
    public void SceneTraverser(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}