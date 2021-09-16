using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shuriken : MonoBehaviour
{
  
  
    public float bulletSpeed = 20f; //projectile speed
    //public float dmg;
    private Rigidbody2D _rb; //projectile rigidbody
    private PlayerHealth _playerHealth; //playerhealth component
    private float _dmg = 25f; //dmg done
    private AudioSource _aud; //impact sound
    
    // Start is called before the first frame update
    void Start()
    {
      _playerHealth = GameObject.FindObjectOfType<PlayerHealth>(); //get player health
      _rb = this.GetComponent<Rigidbody2D>(); //get rigidbody
      _rb.velocity = transform.up * bulletSpeed; //move rigid body upwards
        _aud = this.GetComponent<AudioSource>(); //get the audio source
    }
    //On trigger enter
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
    //if hitinfo is a play then play the impact sound and take damage
    if (hitInfo.tag == "Player") 
    {
      _aud.Play();
      _playerHealth.TakeDamage(_dmg);
    }
      Destroy(gameObject, 1f); //destroy gameobj
    }


  
}
