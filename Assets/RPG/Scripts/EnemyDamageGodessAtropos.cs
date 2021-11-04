using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.RPG.Scripts
{
    public class EnemyDamageGodessAtropos : MonoBehaviour
    {
        public GameObject player;
        public GameObject evilKing;
        public Canvas enemyHealthBar;
        public Image enemyhealth1;
        public Image enemyhealth2;
        public Image enemyhealth3;
        public Image enemyhealth4;
        public Image enemyhealth5;
        public Image enemyhealth6;

        private float counter;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetButton("Fire3"))
            {
                counter += 1;
            }
        }

        private void Counter()
        {
            if (counter == 1)
            {
                enemyhealth2.enabled = false;
            }
            else if (counter == 2)
            {
                enemyhealth3.enabled = false;
            }
            else if (counter == 3)
            {
                enemyhealth4.enabled = false;
            }
            else if (counter == 4)
            {
                enemyhealth5.enabled = false;
            }
            else if (counter == 5)
            {
                enemyhealth6.enabled = false;
            }

        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player") && Input.GetButton("Fire3"))
            {
                enemyhealth1.enabled = false;

                //counter += 1;

                //Counter();
            }
        }

        private void OnTriggerStay2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {
                //counter += 1;

                Counter();
            }
        }
    }
}