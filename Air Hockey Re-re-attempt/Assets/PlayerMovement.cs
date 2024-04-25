using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

using UnityEngine.UIElements;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float movementSpeed;
    [SerializeField]
    private bool isAI;
    [SerializeField]
    private GameObject ball;
    public float boundaryX = -0.024f;
    private Rigidbody2D rb2d;
    private Vector2 playerMove;



    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isAI)
        {
            AIControl();
        }
        else
        {
            PlayerControl();
        }
    }

    private void PlayerControl()
    {
        playerMove = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        transform.Translate(Vector3.right * playerMove * movementSpeed * Time.deltaTime);

        //  if (transform.position.x > boundaryX)
        // {
        //transform.position = new Vector3(boundaryX, transform.position.y, transform.position.z);
        //}
    }


private void AIControl()
{
    //To move up
    if (ball.transform.position.y > transform.position.y + 0.5f)
    {
        playerMove = new Vector2(0, 1);
    }
    //To move down
    else if (ball.transform.position.y < transform.position.y - 0.5f)
    {
        playerMove = new Vector2(0, -1);
    }
    else if (ball.transform.position.x < transform.position.x + 0.5f)
    {
        playerMove = new Vector2(-1, 0);
    }
    //To move right
    else if (ball.transform.position.x > transform.position.x - 0.5f)
    {
        playerMove = new Vector2(1, 0);
    }
    else
    {
        playerMove = new Vector2(0, 0);
    }

}
    //Unity Function 
    //Happens in an even amount of time over the course of a second! not dependant on frame rate
    private void FixedUpdate()
{
    rb2d.velocity = playerMove * movementSpeed;
}
    public LogicB1 LogicB1;
    public ScoreReduction scoreReduction;

    
}



