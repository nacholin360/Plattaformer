using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public static bool IsLevel2Available = false;
    public bool yes = true;
    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(WinCondiccion);    
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log(collision.gameObject.layer);
        if (collision.gameObject.layer == 10)
        {
            IsLevel2Available = true;
            SceneManager.LoadScene(1);
            

        }
    }
}
