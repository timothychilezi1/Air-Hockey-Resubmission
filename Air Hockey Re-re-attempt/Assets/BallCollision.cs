using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuckController : MonoBehaviour
{
    public float speed = 5f; // Speed of puck movement

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the puck collided with a paddle (or any other desired object)
        if (collision.gameObject.CompareTag("Paddle"))
        {
            // Calculate direction towards the center of the paddle
            Vector2 direction = (collision.gameObject.transform.position - transform.position).normalized;

            // Apply force to the puck to make it move in the calculated direction
            GetComponent<Rigidbody2D>().velocity = direction * speed;
        }
    }
}
