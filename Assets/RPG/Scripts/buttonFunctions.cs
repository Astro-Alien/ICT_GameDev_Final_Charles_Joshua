using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonFunctions : MonoBehaviour
{
    public void startGame()
    {
        //open story scene in here
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void optionMenu()
    {
        //open option menu in here
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    public void Back() {


        

    }
    public void exitGame()
    {

        //close or end game code in here
        Application.Quit();
     

    }
   
}
