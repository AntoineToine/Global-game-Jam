using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, zMin, zMax;
}

public class PlayerController : MonoBehaviour
{
    public float horizontalspeed;
    public Boundary boundary;
    public Rigidbody rb;
    public Rigidbody rv;
    public float tilt;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rv = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float h = horizontalspeed * Input.GetAxis("Horizontal");
        
        Vector3 currentRotation = transform.localRotation.eulerAngles;
        currentRotation.x = Mathf.Clamp(currentRotation.x, boundary.zMin, boundary.zMax);
        transform.localRotation = Quaternion.Euler(currentRotation);
        transform.Rotate(h, 0, 0);
        rv.rotation = Quaternion.Euler(0.0f, 0.0f, rv.velocity.x * -tilt);
    }

}