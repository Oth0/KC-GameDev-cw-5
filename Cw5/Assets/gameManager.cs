using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gameManager : MonoBehaviour
{
    public static gameManager instance;
    public Text scoreText;
    public Text highscoreText;

    int score = 0;
    int highscore = 0;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString() +  " Score ";
        highscoreText.text = " High Score: " + highscore.ToString();
    }

    public void AddPoint()
    {
        score += 1;
        scoreText.text = score.ToString() + " Score ";
    }
}
