using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    

    public void ReturnHome()
    {
        SceneManager.LoadScene("Welcome");
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level2");
    }

    public void LoadLevels()
    {
        SceneManager.LoadScene("Level");
    }

    public void LoadHighscore()
    {
        SceneManager.LoadScene("Highscore");
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Savee()
    {
        SaveManager.Instance.Save();
    
    }

    public void Loadd()
    {
        SaveManager.Instance.Load();
    }
    
}
