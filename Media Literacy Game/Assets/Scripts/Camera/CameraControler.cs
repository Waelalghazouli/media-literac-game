using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour
{

    public Transform player;

    // Update is called once per frame
    void Update()
    {
        // transform with a lower 't' is assigning 
        // to the Transform of the maircamera

        transform.position = new Vector3(player.position.x , player.position.y + 1, player.position.z -10);
    }
}
