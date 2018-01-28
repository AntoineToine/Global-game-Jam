using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {

	public Material matofobject;
	public KeyCode colo1;
	public KeyCode colo2;
	public KeyCode colo3;
	public KeyCode colo4;
	
	void Update () {
		if (Input.GetKeyDown (colo3)) {
			matofobject.color = Color.blue;
		} else if (Input.GetKeyDown (colo1)) {
			matofobject.color = Color.green;
		} else if (Input.GetKeyDown (colo4)) {
			matofobject.color = Color.yellow;
		} else if (Input.GetKeyDown (colo2)) {
			matofobject.color = Color.red;
		}
	}
}
