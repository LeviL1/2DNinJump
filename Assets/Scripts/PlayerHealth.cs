using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
  public float playerHealth = 100; //value for players health
  private Animator _anim; // the animator for the player
  private AudioSource _clip; //audio for the player
  // Start is called before the first frame update
  void Start()
    {
    _clip = this.GetComponent<AudioSource>(); //get the audio source
    }
    
    // Update is called once per frame
    void Update()
    {
    if (playerHealth == 0)  //if playerhealth == 0 then die
    {
      Die();
    }
    }
    //subtracts dmg value from playerhealth
  public void TakeDamage(float dmg) 
  {
    
    playerHealth -= dmg; //subtract incoming dmg 

  }
    //kills the player
  public void Die() 
  {
    _anim.Play("Die"); //no anim yet
    Destroy(gameObject, 3f); //destroy player obj
  }
    //adds incoming health amount to the player health
  public void Add(float amt) 
  {
    playerHealth += amt;
  }
}
