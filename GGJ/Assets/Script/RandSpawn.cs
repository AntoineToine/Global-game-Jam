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

    void update()
    {
        
    }
}
