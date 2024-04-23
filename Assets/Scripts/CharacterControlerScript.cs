using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControlerScript : MonoBehaviour
{

    public float maxSpeed;

    public float acceleration;

    
    public Rigidbody2D myRb;

    public float jumpForce;

    public bool isGrounded;



    // Start is called before the first frame update
    void Start()
    {
    myRb = GetComponent<Rigidbody2D>();//Searches for RigidBody2D component and assigns value to myRb
    }

    // Update is called once per frame
    void Update()
    {
        
      if (Mathf.Abs(Input.GetAxis("Horizontal")) * acceleration > 0.1f){

            //Gets the Input value and multiplies it by acceleration
            myRb.AddForce(new Vector2(Input.GetAxis("Horizontal") * acceleration,0),ForceMode2D.Force);
        }

      if (isGrounded == true && Input.GetButtonDown("Jump"))
        {
            myRb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        } 

    
    }
    private void OnTriggerStay2D(Collider2D other)

     {
        isGrounded = true;

    }
    private void OnTriggerExit2D(Collider2D other)
    {
        isGrounded = true;
    }    

}
