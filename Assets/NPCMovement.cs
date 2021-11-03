using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovement : MonoBehaviour
{
    public float NPCSpeed;
    public float startTime;
    public GameObject npcCharacter;
    public GameObject npcCharacterDouble;
    public GameObject npcPosition;
    public GameObject npcPositionDouble;
    public Transform[] movePosition;
    

    private int randomPosition;
    private float waitTime;
    private float x = 82f;
    private float y = 13.5f;
    private float a = 82f;
    private float b = -32.7f;

    private void Start()
    {
        waitTime = startTime;
        //setting random position to a random spot in the the range of 0 to the length of the array
        randomPosition = Random.Range(0, movePosition.Length);
    }
    private void Update()
    {
        
        //moving the npc to that chosen random position from the array
        transform.position = Vector2.MoveTowards(transform.position, movePosition[randomPosition].position, NPCSpeed * Time.deltaTime );

        if (Vector2.Distance(transform.position, movePosition[randomPosition].position) < 0.2f) {

            //checking if its time for the character to move to a new position(random)
            if (waitTime <= 0)
            {

                randomPosition = Random.Range(0, movePosition.Length);
                npcCharacter.SetActive(false);
                npcCharacterDouble.SetActive(true);

                //move to  previous position
                if (npcCharacter.active == false) {

                    Debug.Log("Npc down worked");
                    npcPosition.transform.position = new Vector3(x, y, 0);

                }    
                
                Debug.Log("Npc double set");
                npcPositionDouble.transform.position = new Vector3(a, b, 0);
                waitTime = startTime;
            }
            else
            {
                
                waitTime -= Time.deltaTime; 

            }
        }

    }


}
