using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VisibilityChangeScript : MonoBehaviour
{

    public Button MeTubeButton;
    public GameObject door;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {

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
            MeTubeButton.gameObject.SetActive(true);
        }
        else
        {
            MeTubeButton.gameObject.SetActive(false);
        }
    }
}