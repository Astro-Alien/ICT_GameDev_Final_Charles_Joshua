using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelOneTrigger : MonoBehaviour
{
    public Animator animate;
    public string nextLevel;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            animate.SetBool("playOut", true);
            

        }

    } private void OnTriggerExit2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            animate.SetBool("playOut", false);
            SceneManager.LoadScene(nextLevel);

        }

    }

}
