using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttacking : MonoBehaviour
{
  private Transform target = null;
  public GameObject bullet;
  public Transform firePoint;
  public float range = 3f;
  private float attackTime;
  public float attackRate;
  
  // Start is called before the first frame update
  void Start()
  {
   // InvokeRepeating(nameof(updateTarget), 0f, 0.5f);
  }

  // Update is called once per frame
  void FixedUpdate()
  {
    if (target == null)
    {
      return;
    }
    if (Time.time > attackTime)
    {
      attackTime = Time.time + attackRate;
      Shoot();
    }
    Debug.Log(target.name);
  
}
  private void OnTriggerEnter2D(Collider2D collision)
  {
    target = collision.transform; 
  }
  private void OnTriggerExit2D(Collider2D collision)
  {
    target = null;
  }
  void Shoot()
  {
    Instantiate(bullet, firePoint.position, firePoint.rotation);
  }

}
