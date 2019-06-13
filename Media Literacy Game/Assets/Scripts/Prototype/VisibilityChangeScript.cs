using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VisibilityChangeScript : MonoBehaviour
{

    public Button EnterButton;
    public GameObject door;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("niet uitgevoerd");
        EnterButton.gameObject.SetActive(false);
        Debug.Log("wel uitgevoerd");


    }

    // Update is called once per frame
    void Update()
    {
        foreach (Transform child in this.transform)
        {
            if (player.gameObject.transform.position.x > door.gameObject.transform.position.x - 1 &&
                player.gameObject.transform.position.x < door.gameObject.transform.position.x + 1)
            {
                child.gameObject.SetActive(true);
            }
            else
            {
                child.gameObject.SetActive(false);
            }
        }

        if (player.gameObject.transform.position.x > door.gameObject.transform.position.x - 1 &&
                player.gameObject.transform.position.x < door.gameObject.transform.position.x + 1)
        {
            EnterButton.gameObject.SetActive(true);
        }
        else
        {
            EnterButton.gameObject.SetActive(false);
        }
    }
}