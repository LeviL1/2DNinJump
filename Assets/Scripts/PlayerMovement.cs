using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  public CharacterController2D controller; //CC attached to the player
  public float runSpeed = 40; //runspeed for the player
  float horizontalMove = 0f; //the value for horizontal movement
  public GameObject shuriken; //obj the player throws
  public Animator anim; //player animator component
  bool jump = false; //jump = false by default
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if player is moving play runanimation
    if (horizontalMove != 0)
    {
      anim.Play("runanim");
    }
    //if player is not moving play idle anim
    else { anim.Play("Idle Ninja"); }


    horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed; //positive if moving right negative if moving left
        //if space is pressed
    if (Input.GetButtonDown("Jump"))
    {
      jump = true; 
    }
    //if f is pressed throw a shuriken
    if (Input.GetKeyDown(KeyCode.F)) 
    {
      Instantiate(shuriken, transform.position, transform.rotation);
    }
    }
  private void FixedUpdate()
  {
    //Move Character
    controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
    jump = false;
  }
}
