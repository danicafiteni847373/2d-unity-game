using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Text scoreText;
    public Text liveText;
    //public Text highscoreText;

    public int score = 0;
    public int lives = 3;
    
    // Start is called before the first frame update

    
    
    private void Awake()
    {
        

        instance = this;
    }

    void Start()
    {
        
        scoreText.text = score.ToString();
        liveText.text = lives.ToString();
        //highscoreText.text = "HighScore :" + highscore.ToString();
       
    }


    // Update is called once per frame
    public void AddPoints()
    {
        score += 1;
        scoreText.text = score.ToString();
    }

    public void TakeDamge()
    {
        lives -= 1;
        liveText.text = lives.ToString();
        SoundManager.instance.PlayRedCoinSound();
        if(lives == 0)
        {
            
            SceneManager.LoadScene("GameOver");
        }
    }

    public void highscore()
    {
        
        if(score > PlayerPrefs.GetInt("highscore"))
        {
            
            PlayerPrefs.SetInt("highscore",score);
           
        }
        
    }
}
