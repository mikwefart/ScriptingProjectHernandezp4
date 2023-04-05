using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BB8Toy : MonoBehaviour
{
    public float speed = 10.0f;     // The speed at which the BB8 toy moves
    public float rotationSpeed = 100.0f;   // The speed at which the BB8 toy rotates

    // Update is called once per frame
    void Update()
    {
        // Get the horizontal and vertical input axes
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Move the BB8 toy in the direction of the input axes
        transform.Translate(new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime);

        // Rotate the BB8 toy based on the input axes
        transform.Rotate(Vector3.up, horizontal * rotationSpeed * Time.deltaTime);
    }
}
