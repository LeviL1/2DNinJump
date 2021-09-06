using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttacking : MonoBehaviour
{
  public Transform target;
  public GameObject bullet;
  public Transform firePoint;
  public float range;
  private float attackTime;
  public float attackRate;
  
  // Start is called before the first frame update
  void Start()
  {
    InvokeRepeating("updateTarget", 0f, 0.5f);
  }

  // Update is called once per frame
  void Update()
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
  }
  void Shoot()
  {
    Instantiate(bullet, firePoint.position, firePoint.rotation);
  }
  void updateTarget()
  {
    
    float distanceToEnemy = Vector2.Distance(transform.position, target.transform.position);
      

    
    if (distanceToEnemy <= range)
    {
      target = target.transform;
    }
    else
    {
      target = null;
    }
  }
}
