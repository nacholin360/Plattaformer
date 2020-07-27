using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectionScript : MonoBehaviour
{

    public bool IsLevel1Available = true;
    public bool IsLevel3Available = false;
    public bool IsLevel4Available = false;
    public bool IsLevel5Available = false;
    public bool IsLevel6Available = false;
    public bool IsLevel7Available = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void Level1()
    {   
        if (IsLevel1Available == true)
        {
            SceneManager.LoadScene(3);
        }
    }

    public void Level2()
    {
        if (Win.IsLevel2Available == true)
        {
            Debug.Log("Level 2 Loaded");
        }
    }


}
