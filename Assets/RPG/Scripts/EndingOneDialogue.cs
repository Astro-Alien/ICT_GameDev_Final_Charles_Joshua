using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.RPG.Scripts
{
    public class EndingOneDialogue : MonoBehaviour
    {
        public Canvas canvas;
        public CircleCollider2D collider;
        public GameObject text1;
        public GameObject text2;
        public GameObject text3;
        public GameObject text4;
        public GameObject text5;
        public GameObject text6;
        public GameObject text7;

        public GameObject script;

        public Text tip;

        public string Credits = "Credits";

        private bool stopMoving;
        private int source = 0;

        private float start = 0f;
        private float pause = 25f;
        private bool wait;

        // Start is called before the first frame update
        void Start()
        {
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            if (Time.time - start < pause)
            {
                canvas.GetComponent<Canvas>().enabled = true;
            }

            if (Time.time - start > pause)
            {
                text1.GetComponent<Text>().enabled = false;
                text2.GetComponent<Text>().enabled = false;
                text3.GetComponent<Text>().enabled = false;
                text4.GetComponent<Text>().enabled = false;
                text5.GetComponent<Text>().enabled = false;
                text6.GetComponent<Text>().enabled = false;
                text7.GetComponent<Text>().enabled = false;
                source += 1;

                SourceControl();

                start += 5;
            }

            if (source > 6)
            {
                canvas.GetComponent<Canvas>().enabled = false;
                stopMoving = false;

                script.GetComponent<MonoBehaviour>().enabled = true;
                script.GetComponent<Animator>().enabled = true;

                SceneManager.LoadScene(Credits);
            }
        }

        private void SourceControl()
        {
            if (source == 1)
            {
                text2.GetComponent<Text>().enabled = true;
            }
            else if (source == 2)
            {
                text3.GetComponent<Text>().enabled = true;
            }
            else if (source == 3)
            {
                text4.GetComponent<Text>().enabled = true;
            }
            else if (source == 4)
            {
                text5.GetComponent<Text>().enabled = true;
            }
            else if (source == 5)
            {
                text6.GetComponent<Text>().enabled = true;
            }
            else if (source == 6)
            {
                text7.GetComponent<Text>().enabled = true;
            }
            else if (text2.activeSelf == false)
            {
                source = 6;
            }
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {
                stopMoving = true;
                canvas.GetComponent<Canvas>().enabled = true;
                
                text1.GetComponent<Text>().enabled = true;
            }
        }

        private void OnTriggerStay2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {

                if (stopMoving == true)
                {
                    script.GetComponent<MonoBehaviour>().enabled = false;
                    script.GetComponent<Animator>().enabled = false;
                }
                if (stopMoving == false)
                {
                    script.GetComponent<MonoBehaviour>().enabled = true;
                    script.GetComponent<Animator>().enabled = true;
                }
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            //start the script that starts the first battle
            if (collision.CompareTag("Player"))
            {
                tip.enabled = false;
            }
        }
    }
}
