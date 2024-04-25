using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallPhysics : MonoBehaviour
{
    [SerializeField]
    private float initialSpeed = 10f;
    [SerializeField]
    private float speedIncrease = 0.5f;
    [SerializeField]
    private Text AIScore;
    [SerializeField]
    private Text PlayerScore;

    private int hitCounter;
    private Rigidbody2D rb2d;
    public LogicScript logic;
    public bool hitsFiveTimes = true;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Invoke("StartBall", 2f);

    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        rb2d.velocity = Vector2.ClampMagnitude(rb2d.velocity, initialSpeed + (speedIncrease * hitCounter));
    }

    private void StartBall()
    {
        rb2d.velocity = new Vector2(-1, 0) * (initialSpeed + (speedIncrease * hitCounter));
    }

    private void ResetBall()
    {
        rb2d.velocity = new Vector2(0, 0);
        transform.position = new Vector2(0, 0);
        hitCounter = 0;
        //Call the StartBall function 2 seconds after the line of code has been run
        Invoke("StartBall", 2f);

        float x = Random.value < 0.5f ? -1.0f : 1.0f;

        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) :
            Random.Range(0.5f, 1.0f);

        Vector2 direction = new Vector2(x, y);

        rb2d.AddForce(direction * this.speedIncrease);

    }

    private void PlayerBounce(Transform myObject)
    {
        hitCounter++;

        Vector2 ballPos = transform.position;
        Vector2 playerPos = myObject.position;

        float xDirection, yDirection;
        if (transform.position.x > 0)
        {
            xDirection = -1;
        }
        else
        {
            xDirection = 1;
        }
        //xDirection = (ballPos.x - playerPos.x) / myObject.GetComponent<Collider2D>().bounds.size.x;
        //if (xDirection == 0)
        //{
        //xDirection = 0.25f;
        //}   

        yDirection = (ballPos.y - playerPos.y) / myObject.GetComponent<Collider2D>().bounds.size.y;

        if (yDirection == 0)
        {
            yDirection = 0.25f;
        }
        rb2d.velocity = new Vector2(xDirection, yDirection) * (initialSpeed - (speedIncrease * hitCounter));

    }


}
