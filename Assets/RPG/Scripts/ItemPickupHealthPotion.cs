using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemPickup : MonoBehaviour
{
    public GameObject health;
    public Image healthBar4;
    public Image fullHealth4;
    public Image halfHealth4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) {
            Destroy(health);

            fullHealth4.GetComponent<Image>().enabled = true;
            halfHealth4.GetComponent<Image>().enabled = true;
        }
    }
}
