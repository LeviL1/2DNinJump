using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
  public float health = 100;
  private Animator _anim;
    // Start is called before the first frame update
    void Start()
    {
    _anim = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
    if (health == 0) { Die(); }
    }
  public void TakeDamage(float dmg) { health -= dmg; }
  public void Die() 
  {
    
    _anim.Play("New Animation 0");
    Destroy(this.gameObject, 1.25f);
  }
}
