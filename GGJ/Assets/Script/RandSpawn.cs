using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandSpawn : MonoBehaviour {

    public Vector3[] positions;
    public GameController gameController;

    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
        if (gameController == null)
        {
            Debug.Log("Cannot find 'GameController' script");
        }
        int randomNumber = Random.Range(0, positions.Length);
        transform.position = positions[randomNumber];
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            gameController.GameOver();
        }
        if (other.tag == "Wall")
        {
            int randomNumber = Random.Range(0, positions.Length);
            transform.position = positions[randomNumber];
        }
    }
}
