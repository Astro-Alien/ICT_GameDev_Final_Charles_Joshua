using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private BoxCollider2D boxCollider;
    private Vector3 deltaMovement;
    public float x;
    public float y;
    public float runspeed = 20f;
    public Animator animator;

    private void Start()
    {
        boxCollider  = GetComponent<BoxCollider2D>();
    }
    private void FixedUpdate()
    {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");

        deltaMovement = new Vector3(x,y,0);
        animator.SetFloat("Speed", Mathf.Abs(x));
        
        if (deltaMovement.x > 0)
            transform.localScale = new Vector3(7, 6, 1);

        else if (deltaMovement.x < 0)
            transform.localScale = new Vector3(-7,6,1);

        transform.Translate(deltaMovement * Time.deltaTime);

        
    }


}
