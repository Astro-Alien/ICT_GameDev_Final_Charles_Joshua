using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{

    public float enemySpeed;
    public float mindistance;
    private Transform targetPlayer;
    private Transform secondEnemy;

    private void Start()
    {
        targetPlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        secondEnemy = GameObject.FindGameObjectWithTag("Boss").GetComponent<Transform>();
    }
    private void Update()
    {

        //Checking the distance between the enemy and the playerTarget
        if (Vector2.Distance(transform.position, targetPlayer.position) > mindistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetPlayer.position, enemySpeed * Time.deltaTime);
        }
        
        
    }

}
