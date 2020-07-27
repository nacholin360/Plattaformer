using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCharacter : MonoBehaviour
{
    public Vector2 Velocidad = new Vector2(10, 1000);
    public int JumpForce = 0; 
   


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
        GetComponent<Rigidbody2D>().rotation = 0;
        GetComponent<Rigidbody2D>().angularVelocity = 0;
        Debug.Log(GetComponent<Rigidbody2D>().velocity);
        //Movimiento Lateral
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.localPosition += Vector3.left * Velocidad.x * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.localPosition += Vector3.right * Velocidad.x * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Space) && GetComponent<Rigidbody2D>().velocity.y == 0)
        {
            Debug.Log("Jump");
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
            transform.localPosition += Vector3.up * Velocidad.y * Time.deltaTime;


        }
        
    
        
        
    }
}
