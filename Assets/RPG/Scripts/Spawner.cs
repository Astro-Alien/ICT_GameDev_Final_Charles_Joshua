using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            Debug.Log("enemy is here");
            enemy.SetActive(true);
            GetComponent<Collider2D>().enabled = false;

        }
    }



}
