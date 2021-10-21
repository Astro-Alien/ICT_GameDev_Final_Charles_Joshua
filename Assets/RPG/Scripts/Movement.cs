using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rigid;
    public float speed = 5f;

    private int attack = 0;
    private int movement = 0;
    private bool fire;
    private Vector2 playerVec;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        playerVec.x = Input.GetAxisRaw("Horizontal");
        playerVec.y = Input.GetAxisRaw("Vertical");

        //fire3 is one of the fire buttons, and makes use of the shift and the alternative left mouse button
        fire = Input.GetButton("Fire3");

        /**
        if (moving == true)
        {
            rigid.MovePosition(rigid.position + playerVec * speed * Time.deltaTime);
            animator.SetFloat("MovementHorizontal", playerVec.x);
            animator.SetFloat("MovementVerical", playerVec.y);

            //make the player attack false
            animator.SetFloat("AttackHorizontal", 0);
            animator.SetFloat("AttackVertical", 0);
        }
        else if(moving != true || playerVec.x == 0 || playerVec.y == 0){
            rigid.MovePosition(rigid.position);
            animator.SetFloat("MovementHorizontal", 0);
            animator.SetFloat("MovementVerical", 0);
            animator.SetBool("Moving", false);
        }
        **/

        if (playerVec.y != 0)
        {
            rigid.MovePosition(rigid.position + playerVec * speed * Time.deltaTime);
            animator.SetFloat("MovementHorizontal", 0);
            animator.SetFloat("MovementVerical", playerVec.y);
            animator.SetBool("Moving", true);
        }
        
        if (playerVec.x != 0)
        {
            rigid.MovePosition(rigid.position + playerVec * speed * Time.deltaTime);
            animator.SetFloat("MovementHorizontal", playerVec.x);
            animator.SetFloat("MovementVerical", 0);
            animator.SetBool("Moving", true);
        }
        
        if(playerVec.x == 0 && playerVec.y == 0){
            rigid.MovePosition(rigid.position);
            animator.SetBool("Moving", false);
            animator.SetFloat("MovementHorizontal", 0);
            animator.SetFloat("MovementVerical", 0);
        }

        /**
        if (attacking == true)
        {
            animator.SetFloat("AttackHorizontal", playerVec.x);
            animator.SetFloat("AttackVertical", playerVec.y);

            //make the player movement false
            rigid.MovePosition(rigid.position);
            animator.SetFloat("MovementHorizontal", 0);
            animator.SetFloat("MovementVerical", 0);
        }
        else if (attacking == false) {
            animator.SetFloat("AttackHorizontal", 0);
            animator.SetFloat("AttackVertical", 0);
        }
        **/
    }
}
