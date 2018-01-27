using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandSpawn : MonoBehaviour {

    public Vector3 positions;

    void Start()
    {
        int randomNumber = Random.Range(-8, 8);
        positions.x = randomNumber;
        transform.position = positions;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            int randomNumber = Random.Range(-8, 8);
            positions.x = randomNumber;
            positions.z = 529;
            transform.position = positions;
 //           gameController.GameOver();
        }
        if (other.tag == "Wall")
        {
            int randomNumber = Random.Range(-8, 8);
            positions.x = randomNumber;
            positions.z = 529;
            transform.position = positions;
//            gameController.GameOver();
        }
    }
}
