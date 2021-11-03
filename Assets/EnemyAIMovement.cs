using UnityEngine;

public class EnemyAIMovement : MonoBehaviour
{
    public float enemySpeed;
    public float RadiusCheck;
    public float RadiusAttack;
    public bool mustRotate;
    public LayerMask PlayerLayer;
    public Vector3 direction;

    private Transform target;
    private Rigidbody2D rigid;
    private Animator animator;
    private Vector2 vcmovement;
    
    private bool isInRange;
    private bool isInAttackRange;

    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        target = GameObject.FindWithTag("Player").transform;
    }
    private void Update()
    {
        //Checking every frame refrences from animator and animator and target
        animator.SetBool("isReady", isInRange);

        isInRange = Physics2D.OverlapCircle(transform.position, RadiusCheck, PlayerLayer);
        isInAttackRange = Physics2D.OverlapCircle(transform.position, RadiusAttack, PlayerLayer);

        direction = target.position - transform.position;
        float angle = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg;
        direction.Normalize();
        vcmovement = direction;

        if (mustRotate) {

            animator.SetFloat("X", direction.x);
            animator.SetFloat("Y", direction.y);
        
        }
        

    }
    private void FixedUpdate()
    {
        if (isInRange && !isInAttackRange) {

            MoveEnemy(vcmovement);
        
        
        }
        if (isInAttackRange) {

            rigid.velocity = Vector2.zero;
        
        
        }
    }
    public void MoveEnemy(Vector2 direction) {

        rigid.MovePosition((Vector2)transform.position + (direction * enemySpeed * Time.deltaTime));
    
    
    }



}
