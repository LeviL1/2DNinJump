using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Enemyhealth deals with taking damage and death
public class EnemyHealth : MonoBehaviour
{
  public float health = 100;
  private Animator _anim; //_anim will be enemies animator
    // Start is called before the first frame update
    void Start()
    {
    _anim = this.GetComponent<Animator>(); //get the animator component
    }

    // Update is called once per frame
    void Update()
    {
    if (health == 0) { Die(); } //if health == 0 then die
    }
  public void TakeDamage(float dmg) { health -= dmg; } //subtracts incoming dmg from health

//Kills enemy and displays animation
  public void Die() 
  {
    
    _anim.Play("New Animation 0"); //play enemydeath animation
    Destroy(this.gameObject, 1.25f); //destroy obj after animation
  }
}
