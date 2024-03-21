using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

[System.Serializable]
public class SaveState 
{
    public GameManager highscore{set; get;}
    
    public DateTime AddPoints{set; get;}
}
