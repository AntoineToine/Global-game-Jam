using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPause : MonoBehaviour {

    public KeyCode input;
    private bool isPaused = false;
    public GameObject canvas;
    public GameObject scoreCanvas;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(input))
            isPaused = !isPaused;
        if (isPaused)
        {
            Time.timeScale = 0f;
            canvas.SetActive(true);
            scoreCanvas.SetActive(false);
        }
        else
        {
            Time.timeScale = 1.0f;
            canvas.SetActive(false);
            scoreCanvas.SetActive(true);
        }
	}
}
