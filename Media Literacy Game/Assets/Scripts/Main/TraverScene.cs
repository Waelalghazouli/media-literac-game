using Assets.Scripts.Pacebook;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TraverScene : MonoBehaviour
{
    PacebookScriptManager pm;

    public void SceneTraverser(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
        
    }
    
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        pm = GameObject.FindObjectOfType<PacebookScriptManager>();
    }
}