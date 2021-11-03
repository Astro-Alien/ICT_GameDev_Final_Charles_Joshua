using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelLoader : MonoBehaviour
{
    //add game object to trigger later
    //public GameObject levelTrigger
    //write code to check whether level one has been completed with in text file record
    public string SceneToLoad;
    public Animator animationTransition;
    public GameObject txtLevelName;
    //public GameObject triggerEvent;
    public float transitionTime = 1f;
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            LoadNextLevel();
            txtLevelName.SetActive(true);

        }
    }

    public void LoadNextLevel()
    {


        StartCoroutine(LoadLevel(SceneToLoad));

        
    }

    IEnumerator LoadLevel(string LevelName) {

        //play animation
        animationTransition.SetTrigger("Start");

        //wait
        yield return new WaitForSeconds(transitionTime);
        //load Scene
        SceneManager.LoadScene(LevelName);

    }
}
