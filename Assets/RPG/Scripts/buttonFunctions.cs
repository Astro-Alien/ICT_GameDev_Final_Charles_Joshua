using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonFunctions : MonoBehaviour
{
    private static string LevelReachedOne = @"Assets\CurrentLevel.txt";
    private string[] valueOne = File.ReadAllLines(LevelReachedOne);

    public string levelName;
    public void startGame()
    {
        int currentLevelValueOne = int.Parse(valueOne[0]);

        if (currentLevelValueOne == 1)
        {


            //open story scene in here
            SceneManager.LoadScene(levelName);
            Debug.Log("The start worked");


        }
        else if (currentLevelValueOne == 0)
        {
            //open story scene in here
            SceneManager.LoadScene("StoryIntro");

        }
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
