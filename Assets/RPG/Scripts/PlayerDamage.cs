using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDamage : MonoBehaviour
{
    public GameObject player;
    public Image halfHealth1;
    public Image fullHealth1;
    public Image halfHealth2;
    public Image fullHealth2;
    public Image halfHealth3;
    public Image fullHealth3;

    private int counter;
    private bool colliding;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            colliding = true;
            counter += 1;

            if (counter == 1)
            {
                fullHealth3.enabled = false;
                halfHealth3.enabled = true;
            }
            if (counter == 2)
            {
                fullHealth3.enabled = false;
                halfHealth3.enabled = false;
            }
            if (counter == 3)
            {
                fullHealth2.enabled = false;
                halfHealth2.enabled = true;
            }
            if (counter == 4)
            {
                fullHealth2.enabled = false;
                halfHealth2.enabled = false;
            }
            if (counter == 5)
            {
                fullHealth1.enabled = false;
                halfHealth1.enabled = true;
            }
            if (counter == 6)
            {
                fullHealth1.enabled = false;
                halfHealth1.enabled = false;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            colliding = false;
        }
    }
}
