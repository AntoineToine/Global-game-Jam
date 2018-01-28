using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandSpawn : MonoBehaviour {
    public Vector3[] positions;
    public GameObject canvas;
    public GameObject scoreCanvas;
    public AudioSource m_MyAudioSource;

    void Start()
    {
        int randomNumber = Random.Range(0, positions.Length);
        transform.position = positions[randomNumber];
    }

    void Update()
    {
        if (Input.GetKey("escape"))
            Application.Quit();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //canvas.SetActive(true);
            //Destroy(gameObject); Debug.log
            //scoreCanvas.SetActive(false);
            //Destroy(other.gameObject);
            //Time.timeScale = 0f;
            //Application.Quit();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (other.tag == "Zic")
        {
            m_MyAudioSource.Play();
        }

        if (other.tag == "Wall")
        {
            int randomNumber = Random.Range(0, positions.Length);
            transform.position = positions[randomNumber];
        }
    }
}