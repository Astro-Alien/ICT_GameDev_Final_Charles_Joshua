using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rigid;
    public float speed = 5f;

    private Vector2 playerVec;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        playerVec.x = Input.GetAxisRaw("Horizontal");
        playerVec.y = Input.GetAxisRaw("Vertical");

        if (playerVec.x != 0)
        {
            //right and left
            rigid.MovePosition(rigid.position + playerVec * speed * Time.deltaTime);
            animator.SetFloat("HorizontalMovement", playerVec.x);
            animator.SetFloat("VerticalMovement", 0);
            animator.SetBool("Moving", true);
        }
        if (playerVec.y != 0)
        {
            //right and left
            rigid.MovePosition(rigid.position + playerVec * speed * Time.deltaTime);
            animator.SetFloat("HorizontalMovement", 0);
            animator.SetFloat("VerticalMovement", playerVec.y);
            animator.SetBool("Moving", true);

        }

        /**
        if (Input.GetButton("Fire3")) {
            speed += 10;
        }
        **/
    }
}
