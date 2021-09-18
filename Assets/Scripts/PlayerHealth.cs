using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerHealth : MonoBehaviour
{
  public float playerHealth = 100; //value for players health
  private Animator _anim; // the animator for the player
  public Animator DeathText;
  public AudioSource _clip; //audio for the player
  public AudioSource _hurt;
  // Start is called before the first frame update
  void Start()
    {
    _anim = this.GetComponent<Animator>();
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
    _hurt.Play();
    playerHealth -= dmg; //subtract incoming dmg 

  }
    //kills the player
  public void Die() 
  {
    StartCoroutine(DeathTimer());
    DeathText.Play("DeathTxt");
    _anim.Play("Die"); //no anim yet
    Destroy(gameObject, 3f); //destroy player obj
    
  }
    //adds incoming health amount to the player health
  public void Add(float amt) 
  {
    playerHealth += amt;
  }
  IEnumerator DeathTimer() 
  {

    yield return new WaitForSeconds(1);
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
  }
}
