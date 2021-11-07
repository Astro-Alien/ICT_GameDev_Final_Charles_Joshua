using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class ItemPickupKey : MonoBehaviour
{
    public GameObject key;
    public Text text;
    public GameObject boss;

    private StreamWriter writer = new StreamWriter(@"Assets\CurrentLevelThree.txt");
    private Text textFile;
    private string line;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Player")) {
            Destroy(key);

            if (boss.CompareTag("EvilKing"))
            {
                writer.Write(text.text);
            }
            if (boss.CompareTag("DarkSage"))
            {
                writer.Write(text.text);
            }

        }
    }
}
