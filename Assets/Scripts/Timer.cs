using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public static Timer instance;
   

    float currentTime = 0f;
    float startingtime = 30f;
    [SerializeField]Text timer;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
        currentTime = startingtime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -=1 * Time.deltaTime;
        timer.text = currentTime.ToString("0");

        
        
        if(currentTime <= 0)
        {
            GameManager.instance.highscore();
            SceneManager.LoadScene("Highscore");
        }
    }

    public void AddTime()
    {
        currentTime +=2;
        timer.text = currentTime.ToString("0");
    }

    public void SubtractTime()
    {
        currentTime -=2;
        timer.text = currentTime.ToString("0");
    }
}
