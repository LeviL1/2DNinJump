using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shuriken1 : MonoBehaviour
{
  
  
    public float bulletSpeed = 20f;
    //public float dmg;
    private Rigidbody2D rb;
    private EnemyHealth[] enemyHealth;
    private float dmg = 50f;
    //public GameObject boomanim;
    // Start is called before the first frame update
    void Start()
    {
      enemyHealth = GameObject.FindObjectsOfType<EnemyHealth>();
      rb = this.GetComponent<Rigidbody2D>();
      rb.velocity = transform.right * bulletSpeed;

    }
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
    //GameObject hitEffect;
    //EnemyHealth enemy = hitInfo.GetComponent<EnemyHealth>();
    foreach (EnemyHealth health in enemyHealth) 
    {
      if (hitInfo.CompareTag("Enemy") && health.gameObject == hitInfo.gameObject) 

      {
        health.TakeDamage(dmg);
      }
    }
    //if (hitInfo.tag == "Enemy") { enemyHealth.TakeDamage(dmg); }

      //if (hitInfo.tag == "balloon")
      //{
      //  hitEffect = Instantiate(boomanim, hitInfo.transform.position, hitInfo.transform.rotation);
      //  Destroy(hitEffect, 0.25f);
      //}


      Destroy(gameObject, 1f);
    }


  
}
