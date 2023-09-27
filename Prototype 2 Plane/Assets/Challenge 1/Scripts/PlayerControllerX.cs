using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float speed = 20f;
    private float rotationSpeed = 50f;
    private float verticalInput;
    private bool isColliding = false;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        verticalInput = Input.GetAxis("Vertical");

        if (isColliding == false)
        {
        // moves the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        // tilts the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.left, rotationSpeed * verticalInput * Time.deltaTime);

    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision occurred");
        isColliding = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        isColliding = false; 
    }
}
