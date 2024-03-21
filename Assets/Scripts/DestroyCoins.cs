using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCoins : MonoBehaviour
{
    void OnTriggerEnter2D (Collider2D other)
     {
         if (other.gameObject.tag == "coin") 
         {
            Debug.Log ("coin is collected");
            Destroy(other.gameObject);
            GameManager.instance.AddPoints();
            SoundManager.instance.PlaySound();
            Timer.instance.AddTime();
           
         }

         if (other.gameObject.tag == "coin2") 
         {
            Debug.Log ("Health -1");
            Destroy(other.gameObject);
            GameManager.instance.TakeDamge();
            Timer.instance.SubtractTime();
         }
     }
}
