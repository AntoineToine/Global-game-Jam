using UnityEngine;
using System.Collections;

[System.Serializable]

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    void start ()
    {
        rb = GetComponent<Rigidbody>();
    }
    public float speed;

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce (movement * speed);
    }
}