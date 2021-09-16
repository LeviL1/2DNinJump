using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSushi : MonoBehaviour
{
  private float _healAmt = 25f; //amount to heal player
  private AudioSource _aud; //sushi audiosource
  private Animator _anim; //sushi animator

  private void Start()
  {
    _anim = this.GetComponent<Animator>(); //get the animator
    _aud = this.GetComponent<AudioSource>(); //get the audiosource
  }
  //On trigger enter
  private void OnTriggerEnter2D(Collider2D collision)
  {
        //if collision is the player
    if (collision.tag == "Player") 
    {
      PlayerHealth health = collision.GetComponent<PlayerHealth>(); //get playerhealth component
      _anim.Play("Sushi"); //play sushi animation
      _aud.Play(); //play sushi audio
      health.Add(_healAmt); //add health to player
      Destroy(this.gameObject, 1f); //destroy this obj
    }
  }
}
