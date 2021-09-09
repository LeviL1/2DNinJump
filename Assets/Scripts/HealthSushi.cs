using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSushi : MonoBehaviour
{
  private float _healAmt = 25f;
  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.tag == "Player") 
    {
      PlayerHealth health = collision.GetComponent<PlayerHealth>();

      health.Add(_healAmt);
      Destroy(this.gameObject, 1f);
    }
  }
}
