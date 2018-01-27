using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandSpawn : MonoBehaviour {
    public Vector3 position;
	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        int rand = Random.Range(-20, 20);
        position.x = rand;
        transform.position = position;
    }
}
