using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyDialogue : MonoBehaviour
{
    public Canvas canvas;
    public CircleCollider2D collider;
    public Rigidbody2D player;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    public GameObject text5;
    public GameObject text6;
    public GameObject text7;
    public GameObject text8;

    private bool stopMoving;
    private int source;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Submit") && stopMoving == true) {
            text1.GetComponent<Text>().enabled = false;
            text2.GetComponent<Text>().enabled = false;
            text3.GetComponent<Text>().enabled = false;
            text4.GetComponent<Text>().enabled = false;
            text5.GetComponent<Text>().enabled = false;
            text6.GetComponent<Text>().enabled = false;
            text7.GetComponent<Text>().enabled = false;
            text8.GetComponent<Text>().enabled = false;
            source += 1;
        }

        SourceControl();

        if (source > 8) {
            stopMoving = false;
        }
    }

    private void SourceControl() {
        if (source == 1) {
            text1.GetComponent<Text>().enabled = false;
        }
        if (source == 2)
        {
            text2.GetComponent<Text>().enabled = false;
        }
        if (source == 3)
        {
            text3.GetComponent<Text>().enabled = false;
        }
        if (source == 4)
        {
            text4.GetComponent<Text>().enabled = false;
        }
        if (source == 5)
        {
            text5.GetComponent<Text>().enabled = false;
        }
        if (source == 6)
        {
            text6.GetComponent<Text>().enabled = false;
        }
        if (source == 7)
        {
            text7.GetComponent<Text>().enabled = false;
        }
        if (source == 8)
        {
            text8.GetComponent<Text>().enabled = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            stopMoving = true;
            canvas.GetComponent<Canvas>().enabled = true;

            if (stopMoving == true) {
                player.MovePosition(player.position);
            }
        }
    }
}
