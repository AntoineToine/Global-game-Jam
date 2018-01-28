using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


    public class GameController : MonoBehaviour
    {
        public TextMesh restartText;
        public TextMesh gameOverText;

        private bool gameOver;
        private bool restart;

        void Start()
        {
            gameOver = false;
            restart = false;
            restartText.text = "";
            gameOverText.text = "";
        }

        void Update()
        {
            if (restart)
            {
                if (Input.GetKeyDown(KeyCode.R))
                { 
                    SceneManager.LoadScene ("GGJ game");
                }
            }
        }

        void FixedUpdate()
        {
            if (gameOver)
            {
                restartText.text = "Press 'R' for Restart";
                restart = true;
            }
        }

        public void GameOver()
        {
            gameOverText.text = "Game Over!";
            gameOver = true;
        }
    }
