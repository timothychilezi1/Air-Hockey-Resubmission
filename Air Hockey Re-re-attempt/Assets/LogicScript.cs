using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public LogicScript LogicManager;
    public int PlayerScore;
    public int AIScore;
    public GameObject WinScreen;
    public GameObject LoseScreen;
    public bool PlayerWins = true;
    public Text PlayerScoreText;
    public Text AIScoreText;
    public Text scoreText;
    public GameObject Player;
    public GameObject AI;
    private int PlayerTouches;
    private int AITouches;
    public bool AItouched = false;
    public bool Playertouched = false;

    [ContextMenu("IncreaseScorePlayerScore")]

    public void addScore()
    {
        PlayerScore = PlayerScore ++;
        scoreText.text = PlayerScore.ToString();

        Debug.Log("Player Score is" + PlayerScore);
    }

    public void MinusScore()
    {
        PlayerScore = PlayerScore--;
        scoreText.text = PlayerScore.ToString();

        Debug.Log("Player Score is" + PlayerScore);
    }
     


    //public void minusPlayerScore()
    //{ 
      //  if (PlayerScore > 0)
        //{ 
          //  PlayerScore = PlayerScore - 1;
            //PlayerScoreText.text = PlayerScore.ToString("0");
            //return;
        //}
    //}

    //public void minusAIScore()
    //{
      //  if (AIScore > 0)
        //{
            //AIScore = AIScore - 1;
          //  AIScoreText.text = AIScore.ToString("0");
            //return;
        //}
    //}
    //public void Update()
    //{

    //if (PlayerScore >= 5)
    //{
    //WinScreen.SetActive(true);
    //LoseScreen.SetActive(false);
    //gameOver();
    //Player.SetActive(false);
    //AI.SetActive(false);
    //}


    //if (AIScore >= 5)
    //{
    //WinScreen.SetActive(false);
    //LoseScreen.SetActive(true);
    //gameOver();
    //Player.SetActive(true);
    //AI.SetActive(true);
    //}

    //}

    //public void restartGame()
    //{
    //SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    //}

    //[ContextMenu("Increase Score")]



    //public void gameOver()
    //{



    //}

    public void Update()
    {

        if (PlayerScore >= 5)
        {
            WinScreen.SetActive(true);
            LoseScreen.SetActive(false);
            gameOver();
            Player.SetActive(false);
            AI.SetActive(false);
        }


        if (AIScore >= 5)
        {
            WinScreen.SetActive(false);
            LoseScreen.SetActive(true);
            gameOver();
            Player.SetActive(true);
            AI.SetActive(true);
        }

    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    [ContextMenu("Increase Score")]



    public void gameOver()
    {



    }

    


}