using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Spikes : MonoBehaviour
{

  [SerializeField] private PlayerHealth playerHealth; //playerhealth component
  [SerializeField] private float SpikeDamage = 25; //damage done by spikes
    
    //hurt the player if they hit the spikes
  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.tag == "Player") { playerHealth.TakeDamage(SpikeDamage); } //if collison is player do damg
  }
}
