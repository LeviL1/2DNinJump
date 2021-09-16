using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//EnemyAttacking deals with enemy attack and detecting player
public class EnemyAttacking : MonoBehaviour
{
  private Transform _target = null; //the current target

  public GameObject bullet; //what the enemy throws
  public Transform firePoint; //where it throws from
  
  private float _attackTime; //time between attacks 
  public float attackRate; //how quickly the attack
  
  

  
  void FixedUpdate()
  {
    if (_target == null)
    {
      return; //if target doesn't exist do nothing
    }
    if (Time.time > _attackTime)
    {
      _attackTime = Time.time + attackRate; //if attacktime is less than time.time then shoot
      Shoot(); //call shoot method
    }
   
  
}
    //When the player is in the trigger set them as the target
  private void OnTriggerStay2D(Collider2D collision)
  {
    _target = collision.transform; 
  }
    //if player exist trigger target == null
  private void OnTriggerExit2D(Collider2D collision)
  {
    _target = null;
  }
    //Instantiates a bullet at the firepoint
  void Shoot()
  {
    Instantiate(bullet, firePoint.position, firePoint.rotation);
  }

}
