using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TreasureItem : MonoBehaviour
{
    public GameObject chest;
    public GameObject player;
    public GameObject healthPotion;
    public GameObject secondBossKey;
    public Animator anim;

    public Image enemyHealth6;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyHealth6.enabled == false) {
            chest.GetComponent<SpriteRenderer>().enabled = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (Input.GetButton("Jump"))
            {
                anim.SetBool("Open", true);

                DestroyObject(chest);

                healthPotion.GetComponent<SpriteRenderer>().enabled = true;
                secondBossKey.GetComponent<SpriteRenderer>().enabled = true;
            }
        }
    }
}
