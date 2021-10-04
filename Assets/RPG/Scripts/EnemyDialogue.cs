using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyDialogue : MonoBehaviour
{
    public Canvas canvas;
    public CircleCollider2D collider;
    public Rigidbody2D player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (collider.CompareTag("Player")) {
            canvas.GetComponent<Canvas>().enabled = true;
        }
    }
}
