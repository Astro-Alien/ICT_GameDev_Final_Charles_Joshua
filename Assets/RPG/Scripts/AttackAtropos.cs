using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackAtropos : MonoBehaviour
{
    public GameObject flameLash;
    public GameObject midnight;
    public GameObject freezing;
    public Animator flamelashAnim;
    public Animator midnightAnim;
    public Animator freezingAnim;

    public Image halfHealth1;
    public Image fullHealth1;
    public Image halfHealth2;
    public Image fullHealth2;
    public Image halfHealth3;
    public Image fullHealth3;
    public Image halfHealth4;
    public Image fullHealth4;
    public Image halfHealth5;
    public Image fullHealth5;
    public GameObject player;

    public Canvas gameOver;

    private int counter = 0;

    private float time = 0f;
    private float wait = 20f;
    private int rand;

    // Start is called before the first frame update
    void Start()
    {
        flamelashAnim = GetComponent<Animator>();
        midnightAnim = GetComponent<Animator>();
        freezingAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - time > wait) {
            rand = Random.Range(1, 4);
            counter += 1;

            if (rand == 1) {
                //flamelash attack
                flameLash.GetComponent<SpriteRenderer>().enabled = true;
                flameLash.transform.position = player.transform.position;
                flamelashAnim.SetBool("Attacking", true);
                Destroy(flameLash);
            }
            if (rand == 2)
            {
                //flamelash attack
                midnight.GetComponent<SpriteRenderer>().enabled = true;
                midnight.transform.position = player.transform.position;
                midnightAnim.SetBool("Attacking", true);
                Destroy(midnight);
            }
            if (rand == 3)
            {
                //flamelash attack
                midnight.GetComponent<SpriteRenderer>().enabled = true;
                freezing.transform.position = player.transform.position;
                freezingAnim.SetBool("Attacking", true);
                Destroy(freezing);
            }

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

            if (counter == 6 || counter > 6)
            {
                DestroyObject(player);

                gameOver.enabled = true;
            }
        }
    }


}
