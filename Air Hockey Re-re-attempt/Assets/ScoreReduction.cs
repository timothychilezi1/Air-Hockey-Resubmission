using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ScoreReduction : MonoBehaviour
{ 
    
    public bool PlayerTouched = false;
    public bool AITouched = false;

    private int playertouches;
    private int AItouches;

    public Text AIScoreText;
    public Text PlayerScoretext;

    public int PlayerScore;
    public int AIScore;

    public GameObject winscreen;
    public GameObject losescreen;

    public GameObject Player;
    public GameObject AI;
    public GameObject Puck;

    public Transform AIside;
    public Transform Playerside;

    public float Minx, Maxx, Miny, Maxy;


    void Start()
    {
        winscreen.SetActive(false);
        losescreen.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        Rigidbody2D rb = GetComponent<Rigidbody2D>();


        if (collision.gameObject.CompareTag("PlayerGoal"))
        {
            AIScore++;
            transform.position = Playerside.position;

            if (rb!=null)
            {
                rb.velocity = Vector3.zero;
            }

        }

        if (collision.gameObject.CompareTag("AIGoal"))
        {
            PlayerScore++;
            transform.position = AIside.position;

            if (rb != null)
            {
                rb.velocity = Vector3.zero;
            }

           
        }

        UpdateScore();






        if (collision.gameObject.CompareTag("AI"))
        {
            AITouched = true;
            
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerTouched = true;
            
        }
        


        if (collision.gameObject.CompareTag("Player"))
        {
            playertouches++;
            if (playertouches ==1)
            {
               if (AITouched == true)
                {
                    
                    playertouches = 0;
                    AITouched = false;
                    PlayerTouched = false;

                    Debug.Log("Resest");
                }
            }

            else if (playertouches >= 2)
            {
                
                    PlayerScore --;
                    playertouches = 0;
                    AITouched=false;
                    PlayerTouched = false;
                    Debug.Log("Playertouched 2 times");
                if (playertouches < 0)
                {
                    PlayerScore = 0;
                }
                UpdateScore();
                
            }
        }


        if (collision.gameObject.CompareTag("AI"))
        {
            AItouches++;
            if (AItouches == 1)
            {
                if (PlayerTouched == true)
                {

                    AItouches = 0;
                    PlayerTouched = false;
                    AITouched = false;

                    Debug.Log("bitch");
                }
            }

            else if (AItouches >= 2)
            {

                AIScore--;
                AItouches = 0;
                PlayerTouched = false;
                AITouched = false;
                Debug.Log("Playertouched 2 times");
                if (AIScore < 0)
                {
                    AIScore = 0;
                }
                UpdateScore();

            }
        }

        if (PlayerScore == 5)
        {
            winscreen.SetActive(true);
            Player.SetActive(false);
            AI.SetActive(false);
            Puck.SetActive(false);
           

        }

        if (PlayerScore <= 0)
        {
            PlayerScore = 0;
        }
        UpdateScore();

        if (AIScore == 5)
        {
            losescreen.SetActive(true);
            Player.SetActive(false);
            AI.SetActive(false);
            Puck.SetActive(false);


        }

        if (collision.gameObject.CompareTag("Portal"))
        {
            Vector3 randomposition = new Vector3(Random.Range(Minx, Maxx), Random.Range(Miny, Maxy), 0f);
            transform.position = randomposition;
        }


    }

    private void UpdateScore()
    {
        PlayerScoretext.text = "" + PlayerScore;
        AIScoreText.text = "" + AIScore;
    }

    

}
