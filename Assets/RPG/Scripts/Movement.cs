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
            animator.SetFloat("Horizontal", playerVec.x);
        }
        else if (playerVec.y != 0)
        {
            //right and left
            rigid.MovePosition(rigid.position + playerVec * speed * Time.deltaTime);
            animator.SetFloat("Horizontal", playerVec.y);
        }

        if (Input.GetButton("Fire3")) {
            speed += 10;
        }
    }
}
