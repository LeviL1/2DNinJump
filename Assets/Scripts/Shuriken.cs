using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shuriken : MonoBehaviour
{
  
  
    public float bulletSpeed = 20f;
    //public float dmg;
    private Rigidbody2D rb;
    private PlayerHealth playerHealth;
    private float dmg = 25f;
  private AudioSource _aud;
    //public GameObject boomanim;
    // Start is called before the first frame update
    void Start()
    {
      playerHealth = GameObject.FindObjectOfType<PlayerHealth>();
      rb = this.GetComponent<Rigidbody2D>();
      rb.velocity = transform.up * bulletSpeed;
    _aud = this.GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
    //GameObject hitEffect;
    //EnemyHealth enemy = hitInfo.GetComponent<EnemyHealth>();
    if (hitInfo.tag == "Player") 
    {
      _aud.Play();
      playerHealth.TakeDamage(dmg);
    }

      //if (hitInfo.tag == "balloon")
      //{
      //  hitEffect = Instantiate(boomanim, hitInfo.transform.position, hitInfo.transform.rotation);
      //  Destroy(hitEffect, 0.25f);
      //}


      Destroy(gameObject, 1f);
    }


  
}
