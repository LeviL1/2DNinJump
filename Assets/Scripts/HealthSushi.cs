using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSushi : MonoBehaviour
{
  private float _healAmt = 25f;
  private AudioSource _aud;
  private Animator _anim;
  private void Start()
  {
    _anim = this.GetComponent<Animator>();
    _aud = this.GetComponent<AudioSource>();
  }
  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.tag == "Player") 
    {
      PlayerHealth health = collision.GetComponent<PlayerHealth>();
      _anim.Play("Sushi");
      _aud.Play();
      health.Add(_healAmt);
      Destroy(this.gameObject, 1f);
    }
  }
}
