using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player;

    private Vector3 playerVec;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        playerVec = new Vector3(player.position.x, player.position.y, transform.position.z);
        transform.position = playerVec;    
    }
}
