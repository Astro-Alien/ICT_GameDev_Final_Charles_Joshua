using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalChoices : MonoBehaviour
{
    public static bool gameChoice = false;
    public string EndingScene;
    public GameObject pausedGameMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FreezeGame() {
        if (gameChoice == true)
        {

            Continue();


        }
        else
        {

            Leave();


        }
    }

    public void Continue() {
        pausedGameMenu.SetActive(false);
        Time.timeScale = 1f;
        gameChoice = false;
    }

    public void Leave() {
        pausedGameMenu.SetActive(true);
        Time.timeScale = 0f;
        gameChoice = true;
    }

    public void ContinueMenu() {
        pausedGameMenu.SetActive(false);
        Time.timeScale = 1f;
        gameChoice = false;
    }

    public void LeaveMenu()
    {
        pausedGameMenu.SetActive(false);
        SceneManager.LoadScene(EndingScene);
        Time.timeScale = 1f;
        gameChoice = false;
        
    }
}
