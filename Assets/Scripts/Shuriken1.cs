using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shuriken1 : MonoBehaviour
{
  
  
    public float bulletSpeed = 20f;
    //set private after good value is chosen

    private Rigidbody2D _rb;
    //the rigidbody attached to the shuriken
    //private CharacterController2D _cc;
    //the Character Controller for telling if facing right or left
    private EnemyHealth[] _enemyHealth;
    private CharacterController2D _cc;
    //enemyHealth script needed for damageing Enemies
    private float _dmg = 50f;
    //Damage the shuriken does
    void Start()
    {
    //retrieve references  for _cc _enemyHealth and _rb
      _cc = GameObject.FindObjectOfType<CharacterController2D>();
      _enemyHealth = GameObject.FindObjectsOfType<EnemyHealth>();
      _rb = this.GetComponent<Rigidbody2D>();
    if (_cc.m_FacingRight == true)
    {
      _rb.velocity = transform.right * bulletSpeed;
    }
    else if (_cc.m_FacingRight != true) 
    {
      _rb.velocity = (transform.right * -1) * bulletSpeed;
    }

    }
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
    
    foreach (EnemyHealth health in _enemyHealth) 
    {
      if (hitInfo.CompareTag("Enemy") && health.gameObject == hitInfo.gameObject) 

      {
        health.TakeDamage(_dmg);
      }
    }
   
      Destroy(gameObject, 1f);
    }


  
}
