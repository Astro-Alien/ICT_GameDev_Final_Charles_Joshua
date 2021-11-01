using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static  bool gamePaused = false;
    public string OpenScene;
    public GameObject pausedGameMenu;

    public void FreezeGame()
    {
       

           if (gamePaused)
            {

                ResumeGame();


            }
            else {

                PauseGame();
            
            
            }

        
    }

    public void ResumeGame()
    {

        pausedGameMenu.SetActive(false);
        Time.timeScale = 1f;
        gamePaused = false;



    }
    private void PauseGame() {

        pausedGameMenu.SetActive(true);
        Time.timeScale = 0f;
        gamePaused = true;
    
    }

    public void OpenMenu() {
        Time.timeScale = 1f;
        SceneManager.LoadScene(OpenScene);
    
    }
    public void EndGame() {
        Debug.Log("Quit Game");

        Application.Quit();


    }

}
