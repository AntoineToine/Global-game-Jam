using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandSpawn : MonoBehaviour {
    public Vector3[] positions;
    public GameObject canvas;
    public GameObject scoreCanvas;

    void Start()
    {
        int randomNumber = Random.Range(0, positions.Length);
        transform.position = positions[randomNumber];
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            canvas.SetActive(true);
            //Destroy(gameObject); Debug.log
            scoreCanvas.SetActive(false);
            Destroy(other.gameObject);
            Time.timeScale = 0f;
        }
        if (other.tag == "Wall")
        {
            int randomNumber = Random.Range(0, positions.Length);
            transform.position = positions[randomNumber];
        }
    }
}