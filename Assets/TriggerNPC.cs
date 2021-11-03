using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerNPC : MonoBehaviour
{
    public GameObject npc;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("NPC"))
        {
            Debug.Log("Trigger hit by NPC");
            npc.SetActive(false);
        }
    }
}