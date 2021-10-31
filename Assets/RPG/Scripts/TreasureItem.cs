using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureItem : MonoBehaviour
{
    public GameObject chest;
    public GameObject player;
    public GameObject healthPotion;
    public GameObject secondBossKey;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
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
