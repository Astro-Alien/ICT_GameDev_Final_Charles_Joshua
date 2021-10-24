using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public Animator animate;
    public string nextLevel;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) {

            TransitionCompleted("TownMap");
        
        }
    }
    public void TransitionCompleted(string nameOfLevel) {
        nextLevel = nameOfLevel;

        animate.SetTrigger("FadeOut");

        
    
    }

    public void FadeComplete()
    {

        SceneManager.LoadScene(nextLevel);

    }
}
