using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StoryText : MonoBehaviour
{
    public GameObject Text;
    public GameObject Text2;
    public GameObject Text3;
    public GameObject Text4;
    public Text continueText;
    public string loadingScene;
    private int source;
    private float seconds = 5f;
    private bool mustWait;

    // Start is called before the first frame update
    void Start()
    {
        Text.GetComponent<Text>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButton("Submit"))
        {
            Text.GetComponent<Text>().enabled = false;
            Text2.GetComponent<Text>().enabled = false;
            Text3.GetComponent<Text>().enabled = false;
            Text4.GetComponent<Text>().enabled = false;
            source += 1;
        }

        SourceCheck();

        if (source > 5) {
            SceneManager.LoadScene(loadingScene);
        }
    }

    private void SourceCheck() {
        if (source == 1)
        {
            Text.GetComponent<Text>().enabled = true;
        }
        if (source == 2)
        {
            Text2.GetComponent<Text>().enabled = true;
        }
        if (source == 3)
        {
            Text3.GetComponent<Text>().enabled = true;
        }
        if (source == 4)
        {
            Text4.GetComponent<Text>().enabled = true;
        }
    }
}
