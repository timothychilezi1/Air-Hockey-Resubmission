using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallResetScript : MonoBehaviour
{
    public Transform returnPosition;
    public GameObject specificObject;
    Vector3 ballVector;


    private Rigidbody2D rb2d;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Reset")
        {
            transform.position = new Vector3(-2.79f, 0, 0);


        }

        if (collision.gameObject.tag == "Reset")
        {
            rb2d.velocity = Vector3.zero;          }

    }



}
