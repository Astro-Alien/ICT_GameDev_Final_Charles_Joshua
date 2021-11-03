using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class LevelCheck : MonoBehaviour
{
    public GameObject LevelOpen;
    public int levelComplete;
    private static string LevelReached = @"Assets\CurrentLevel.txt";
    private string[] value = File.ReadAllLines(LevelReached);
    private string values;

    //trigger event to check text file value to see whether to activate the level two trigger
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {

            Debug.Log("Trigger hit");
            
            //To update just replace this method in levels with the updateTextFile method();
            checkTextFile();
            

        }
    }

    public void UpdateTextFile(int completedLevel) {

        levelComplete = completedLevel;
     

        values = levelComplete.ToString();
        value[0] = values;
        File.WriteAllLines(LevelReached, value);
        Debug.Log("Changed Text File value to: " +values);
        

    }
    public void checkTextFile()
    {
        int currentLevelValue = int.Parse(value[0]);

        switch(currentLevelValue){
            case 1:
            case 2:
                   LevelOpen.SetActive(true);
                   break;  
            default:
                Debug.Log("Failed");
                break;
        }
        Debug.Log("Current Value in the Text File is: "+ currentLevelValue);

    }
}
