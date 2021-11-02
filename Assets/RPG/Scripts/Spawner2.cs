using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner2 : MonoBehaviour
{

    public GameObject enemyOne;
    public GameObject enemyTwo;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            Debug.Log("enemy is here");
            enemyOne.SetActive(true);
            enemyTwo.SetActive(true);
           
            GetComponent<Collider2D>().enabled = false;


        }
    }
}
