using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MovementCharacter : MonoBehaviour
{
    public Vector2 Velocidad = new Vector2(10, 1000);
    public int JumpForce = 0;
    public int Lives = 3;
    public Text LivesCounter;
   


    // Start is called before the first frame update
    void Start()
    {
      transform.localPosition = new Vector2 (-8, -2);
        SetLivesCounterTo(3);
    }

    // Update is called once per frame
    void Update()
    {
       PlayerMovement();
    }

    void PlayerMovement()
    {
        if (Lives <= 0)
        {

        }
        GetComponent<Rigidbody2D>().rotation = 0;
        GetComponent<Rigidbody2D>().angularVelocity = 0;
        //Debug.Log(GetComponent<Rigidbody2D>().velocity);
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
            //Debug.Log("Jump");
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
            transform.localPosition += Vector3.up * Velocidad.y * Time.deltaTime;


        }
        if (transform.localPosition.y <= -20)
        {
            Death();
        }
        //Debug.Log(Lives);

        
    
        
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log(collision.gameObject.layer);
        if (collision.gameObject.layer == 8)
        {
            Death();

        }
    }

    public void Death()
    {
        Lives -= 1;
        if (Lives == 0)
        {
            SceneManager.LoadScene(2);
        }
        transform.localPosition = new Vector2(-8, -2);
        SetLivesCounterTo(Lives);
    }

    void SetLivesCounterTo(int Count)
    {
        LivesCounter.text = "Lives: " + Count;
    }
}
