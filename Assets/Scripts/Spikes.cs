using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Spikes : MonoBehaviour
{

  [SerializeField] private PlayerHealth playerHealth;
  [SerializeField] private float SpikeDamage = 25;
    // Update is called once per frame
    void Update()
    {
      
    }
  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.tag == "Player") { playerHealth.TakeDamage(SpikeDamage); }
  }
}
