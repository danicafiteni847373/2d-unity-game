using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System;
using System.IO;

public class SaveManager : MonoBehaviour
{

    
    private static SaveManager instance;

    public static SaveManager Instance
    {
        get{
            if(instance == null)
            {
                instance = FindObjectOfType<SaveManager>();
                if(instance == null)
                {
                    instance = new GameObject("Spawned SaveManger", typeof(SaveManager)).GetComponent<SaveManager>();

                }
            }
            return instance;
        }
        set
        {
            instance = value;
        }
    }

    private void Awake()
    {
        

        instance = this;
    }
    [Header("Logic")]
    [SerializeField] private string savefileName = "data.ss";
    [SerializeField] private bool loadOnStart = true;
    private BinaryFormatter formatter;
    private SaveState state;
    public SaveState State {get =>state; set =>state = value;}
    

    public void Start()
    {
        formatter = new BinaryFormatter();
        DontDestroyOnLoad(this.gameObject);

        if(loadOnStart)
            Load();
    }

    public void Save()
    {
        if(state == null)
            state = new SaveState();

        state.AddPoints = DateTime.Now;

        
        var file = new FileStream(savefileName, FileMode.Open, FileAccess.Write);
        formatter.Serialize(file, state);
        file.Close();
    }

    public void Load()
    {
        try
        {
            var file= new FileStream(savefileName, FileMode.Open, FileAccess.Read);
            state = (SaveState)formatter.Deserialize(file);
            file.Close();
        }
        catch
        {
            Debug.Log("No save file fould");
            Save();
        }
        
    }
}
