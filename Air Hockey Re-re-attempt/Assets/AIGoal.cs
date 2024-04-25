using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiGoal : MonoBehaviour
{
    [SerializeField]
    Vector3 ballVector;
    public LogicB1 logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Bro").GetComponent<LogicB1>();
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
                

            ballVector = new Vector3(0.0f, 0.0f, 0.0f);
        }
    }
}
