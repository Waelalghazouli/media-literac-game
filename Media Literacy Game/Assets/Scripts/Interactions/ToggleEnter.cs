using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleEnter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Renderer render = gameObject.GetComponent<Renderer>();

        Vector3 position = transform.position;
        var player = GameObject.Find("player");

        if (player.gameObject.transform.position.x > position.x -1 && player.gameObject.transform.position.x < position.x + 1)
        {
            render.enabled = true;
        }
        else
        {
            render.enabled = false;
        }

        Debug.Log("button pos" + position.x);
        Debug.Log("player pos" + player.gameObject.transform.position.x);
    }
}
