using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegularEnemyDamage : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;

    private float counter;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire3"))
        {
            counter += 1;
        }
    }

    private void Counter()
    {
        if (counter == 3)
        {
            enemy.layer = 0;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && Input.GetButtonDown("Fire3"))
        {
            Counter();
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && Input.GetButtonDown("Fire3"))
        {
            Counter();
        }
    }
}
