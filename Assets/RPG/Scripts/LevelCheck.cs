using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCheck : MonoBehaviour
{
    public GameObject LevelOpen;
    public string levelComplete;
    //trigger event to check text file value to see whether to activate the level two trigger
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {

            Debug.Log("Trigger hit");
            

        }
    }

    public void checkTextFile(string completedLevel) {

        levelComplete = completedLevel;


    
    
    
    
    
    
    }
}
