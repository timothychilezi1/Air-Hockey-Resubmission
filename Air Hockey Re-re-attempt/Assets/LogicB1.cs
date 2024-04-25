using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicB1 : MonoBehaviour
{
    public LogicB1 LogicManagerB1;
    public int AIScore;
    public int PlayerScore;
    public Text scoreText;
    public Text PlayerScoreText;
    public Text AIScoreText;
    public int PlayerTouches;
    public int AITouches;
    public GameObject WinScreen;
    public GameObject LoseScreen;
    public GameObject Player;
    public GameObject AI;
    public bool AItouched = false;
    public bool Playertouched = false;




    public void Update()
    {

  

    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    
}

