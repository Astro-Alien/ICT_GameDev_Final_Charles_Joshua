using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StoryTextWriter : MonoBehaviour
{
    public float textSpeed = 3f;
    public GameObject Text;
    public GameObject Text2;
    public GameObject Text3;
    public GameObject Text4;
    public TextAsset textSource;
    public TextAsset textSource2;
    public TextAsset textSource3;
    public TextAsset textSource4;
    public Text continueText;
    public string loadingScene;

    private ArrayList wordList;
    private ArrayList wordList2;
    private ArrayList wordList3;
    private ArrayList wordList4;
    private string[] letterarr;
    private int source = 1;

    // Start is called before the first frame update
    void Start()
    {
        wordList = new ArrayList();
        Text.GetComponent<Text>().text = "";

        //SourceText();

        WriteText();
    }

    public void WriteText() {
        if (source == 1)
        {
            foreach(string letter in wordList)
        {
                letterarr = letter.Split(' ');
            }
        }
        if (source == 2)
        {
            foreach (string letter in wordList2)
            {
                letterarr = letter.Split(' ');
            }
        }
        if (source == 3)
        {
            foreach (string letter in wordList3)
            {
                letterarr = letter.Split(' ');
            }
        }
        if (source == 4)
        {
            foreach (string letter in wordList4)
            {
                letterarr = letter.Split(' ');
            }
        }

        foreach (var letters in letterarr)
        {
            if (source == 1)
            {
                Text.GetComponent<Text>().text += letters;

                if (letters.Contains("."))
                {
                    Text.GetComponent<Text>().text += "\n";
                    continueText.enabled = true;
                }
                else
                {
                    Text.GetComponent<Text>().text += " ";
                }

                if (source > 4)
                {
                    SceneManager.LoadScene(loadingScene);
                }
            }
            if (source == 2)
            {
                Text.GetComponent<Text>().text += letters;

                if (letters.Contains("."))
                {
                    Text.GetComponent<Text>().text += "\n";
                    continueText.enabled = true;
                }
                else
                {
                    Text.GetComponent<Text>().text += " ";
                }

                if (source > 4)
                {
                    SceneManager.LoadScene(loadingScene);
                }
            }
            if (source == 3)
            {
                Text.GetComponent<Text>().text += letters;

                if (letters.Contains("."))
                {
                    Text.GetComponent<Text>().text += "\n";
                    continueText.enabled = true;
                }
                else
                {
                    Text.GetComponent<Text>().text += " ";
                }

                if (source > 4)
                {
                    SceneManager.LoadScene(loadingScene);
                }
            }
            if (source == 4)
            {
                Text.GetComponent<Text>().text += letters;

                if (letters.Contains("."))
                {
                    Text.GetComponent<Text>().text += "\n";
                    continueText.enabled = true;
                }
                else
                {
                    Text.GetComponent<Text>().text += " ";
                }

                if (source > 4)
                {
                    SceneManager.LoadScene(loadingScene);
                }
            }
        }
        
    }

    public void Reader(TextAsset sourceTxt) {
        //string textfilepath = "Assets/RPG/Text/StoryLine.txt";
        string filepath = AssetDatabase.GetAssetPath(sourceTxt);
        StreamReader reader = new StreamReader(filepath);

        if (source == 1)
        {
            while (!reader.EndOfStream)
            {
                wordList.Add(reader.ReadToEnd());
            }
        }
        if (source == 2)
        {
            while (!reader.EndOfStream)
            {
                wordList2.Add(reader.ReadToEnd());
            }
        }
        if (source == 3)
        {
            while (!reader.EndOfStream)
            {
                wordList3.Add(reader.ReadToEnd());
            }
        }
        if (source == 4)
        {
            while (!reader.EndOfStream)
            {
                wordList4.Add(reader.ReadToEnd());
            }
        }

        reader.Close();
    }

    private void Update()
    {
        SourceText();

        if (Input.GetButton("Submit")) {
            Text.GetComponent<Text>().text = "";
            continueText.enabled = false;
            source += 1;
        }
    }

    private void SourceText() {
        if (source == 1)
        {
            Reader(textSource);
            Text.GetComponent<Text>().enabled = true;
        }
        if (source == 2)
        {
            Reader(textSource2);
            Text2.GetComponent<Text>().enabled = true;
        }
        if (source == 3)
        {
            Reader(textSource3);
            Text3.GetComponent<Text>().enabled = true;
        }
        if (source == 4)
        {
            Reader(textSource4);
            Text4.GetComponent<Text>().enabled = true;
        }
    }

}
