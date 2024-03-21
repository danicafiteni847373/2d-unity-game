using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    public static AudioClip coinSound;
    public static AudioClip gameoverSound;
    static AudioSource audioSrc;
    static AudioSource audioSrc2;
    // Start is called before the first frame update

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        coinSound = Resources.Load<AudioClip>("foley_creations1");
        gameoverSound = Resources.Load<AudioClip>("redcoin");
        audioSrc = GetComponent<AudioSource>();
        audioSrc2 = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySound()
    {
        audioSrc.PlayOneShot(coinSound);
    }

    public void PlayRedCoinSound()
    {
        audioSrc2.PlayOneShot(gameoverSound);
    }
}
