using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Vector3 = UnityEngine.Vector3;

public class PlayerGoal : MonoBehaviour
{
    [SerializeField]
    Vector3 ballVector;
    Rigidbody2D rb2d;

    public LogicScript logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.layer == 3)
        {
            logic.addScore();

            ballVector = new Vector3(0.0f, 0.0f, 0.0f);

        }

    }
}
