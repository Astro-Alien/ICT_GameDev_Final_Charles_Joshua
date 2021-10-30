using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChange : MonoBehaviour
{
    public string sceneName;
    public Animator animate;


    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger) {

            animate.SetBool("playOut", true);
            SceneManager.LoadScene(sceneName);
            
        }
    }
}
