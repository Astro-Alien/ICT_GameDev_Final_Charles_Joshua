using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class ItemPickupKey : MonoBehaviour
{
    public GameObject key;

    private StreamWriter writer = new StreamWriter("SecondBossKey.txt");
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

            writer.WriteLine("second boss key");
            writer.Close();
        }
    }
}
