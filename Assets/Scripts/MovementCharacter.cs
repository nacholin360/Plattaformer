using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCharacter : MonoBehaviour
{
    public int Velocidad = 3;


    // Start is called before the first frame update
    void Start()
    {
      transform.localPosition = new Vector2 (0, 0);
    }

    // Update is called once per frame
    void Update()
    {
       PlayerMovement();
    }

    void PlayerMovement()
    {   
        //Movimiento Lateral
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.localPosition += Vector3.left * Velocidad * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.localPosition += Vector3.right * Velocidad * Time.deltaTime;
        }

        //Salto
        if (Input.GetButtonDown("Jump"))
        {
            
        }
    }
}
