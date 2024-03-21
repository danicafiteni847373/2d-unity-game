using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ButtonManagerr : MonoBehaviour
{
    [SerializeField]Button m_start_btn, m_highsore_btn, m_level_btn;
    // Start is called before the first frame update

    void Start()
    {
        m_start_btn.onClick.AddListener(StartGame);
        m_highsore_btn.onClick.AddListener(Highscoree);
        m_level_btn.onClick.AddListener(level);
    }

    void StartGame()
    {
        Debug.Log("Game Started");
        SceneManager.LoadScene("Level1");
        
    }

    void Highscoree()
    {
        Debug.Log("Game Started");
        SceneManager.LoadScene("Highscore");
        
    }

    void level()
    {
        Debug.Log("Game Started");
        SceneManager.LoadScene("Level");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
