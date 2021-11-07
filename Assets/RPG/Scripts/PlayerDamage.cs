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
    public Image halfHealth4;
    public Image fullHealth4;
    public Image halfHealth5;
    public Image fullHealth5;
    public Canvas gameOver;

    public GameObject boss;

    public GameObject flameLashAttack;
    public GameObject midnightAttack;
    public GameObject freezingAttack;

    public Image enemyHealthBar1;

    private int counter;
    private bool colliding;

    private float start = 0f;
    private float end = 20f;
	private int rand;
    private int randMagic;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rand = Random.RandomRange(1, 10);
        randMagic = Random.RandomRange(1, 3);


        Vector2 pos = new Vector2();
        pos = player.transform.position;

        if (enemyHealthBar1.enabled == false)
        {
            if (Time.time > rand)
            {

                flameLashAttack.transform.position = pos;
                flameLashAttack.GetComponent<Animator>().SetBool("Attacking", true);
                flameLashAttack.GetComponent<SpriteRenderer>().enabled = true;

                midnightAttack.transform.position = pos;
                midnightAttack.GetComponent<Animator>().SetBool("Attacking", true);
                midnightAttack.GetComponent<SpriteRenderer>().enabled = true;

                freezingAttack.transform.position = pos;
                freezingAttack.GetComponent<Animator>().SetBool("Attacking", true);
                freezingAttack.GetComponent<SpriteRenderer>().enabled = true;
            }
        }

        /**
        if(Input.GetButton("Fire3")){
            counter += 1;
        }
        **/
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && Input.GetButton("Fire3"))
        {
            CounterCheck();

        }
    }

    public void CounterCheck() {
        if (counter == 2)
        {
            fullHealth5.enabled = false;
            halfHealth5.enabled = true;
        }
        if (counter == 4)
        {
            fullHealth5.enabled = false;
            halfHealth5.enabled = false;
        }
        if (counter == 6)
        {
            fullHealth4.enabled = false;
            halfHealth4.enabled = true;
        }
        if (counter == 8)
        {
            fullHealth4.enabled = false;
            halfHealth4.enabled = false;
        }
        if (counter == 10)
        {
            fullHealth3.enabled = false;
            halfHealth3.enabled = true;
        }
        if (counter == 12)
        {
            fullHealth3.enabled = false;
            halfHealth3.enabled = false;
        }
        if (counter == 14)
        {
            fullHealth2.enabled = false;
            halfHealth2.enabled = true;
        }
        if (counter == 16)
        {
            fullHealth2.enabled = false;
            halfHealth2.enabled = false;
        }
        if (counter == 18)
        {
            fullHealth1.enabled = false;
            halfHealth1.enabled = true;
        }
        if (counter == 20)
        {
            fullHealth1.enabled = false;
            halfHealth1.enabled = false;
        }

        if (boss.gameObject.CompareTag("EvilKing"))
        {
            if (counter == 12 || counter > 12)
            {
                DestroyObject(player);

                gameOver.enabled = true;
            }
        }

        if (boss.gameObject.CompareTag("DarkSage"))
        {
            if (counter == 16 || counter > 16)
            {
                DestroyObject(player);

                gameOver.enabled = true;
            }
        }

        if (boss.gameObject.CompareTag("Atropos"))
        {
            if (counter == 20 || counter > 20)
            {
                DestroyObject(player);

                gameOver.enabled = true;
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && Input.GetButton("Fire3")) {
            //CounterCheck();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            flameLashAttack.GetComponent<SpriteRenderer>().enabled = false;
            midnightAttack.GetComponent<SpriteRenderer>().enabled = false;
            freezingAttack.GetComponent<SpriteRenderer>().enabled = false;
        } 
    }
}
