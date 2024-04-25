using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallResetScriptB : MonoBehaviour
{
    private Rigidbody2D rb2d;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "PlayerGoal")
        {
            transform.position = new Vector3(2.79f, 0, 0);
        }

        if (collision.gameObject.tag == "PlayerGoal")
        {
            rb2d.velocity = Vector3.zero;
        }


    }
}
