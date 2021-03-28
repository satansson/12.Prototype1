using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 25.0f;
    private float turnSpeed = 25f;
    private float horizontalInput;
    private float verticalInput;

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        if (verticalInput == 0)
            horizontalInput = 0;
        if (verticalInput < 0)
            horizontalInput *= -1;

        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
        
    }
}
