using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  public CharacterController2D controller;
  public float runSpeed = 40;
  float horizontalMove = 0f;
  public Animator anim;
  bool jump = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    if (horizontalMove != 0)
    {
      anim.Play("runanim");
    }
    else { anim.Play("Idle Ninja"); }


    horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

    if (Input.GetButtonDown("Jump"))
    {
      jump = true;
    }
    }
  private void FixedUpdate()
  {
    //Move Character
    controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
    jump = false;
  }
}
