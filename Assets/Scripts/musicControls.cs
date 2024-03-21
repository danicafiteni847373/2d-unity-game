using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicControls : MonoBehaviour
{
    public static musicControls instance;

    private void Awake(){
        DontDestroyOnLoad(this.gameObject);
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
