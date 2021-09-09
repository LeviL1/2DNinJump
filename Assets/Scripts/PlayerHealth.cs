using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
  [SerializeField] private float playerHealth = 100;
  [SerializeField] private Animator anim;
  // Start is called before the first frame update
  void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    if (playerHealth == 0) 
    {
      Die();
    }
    }
  public void TakeDamage(float dmg) { playerHealth -= dmg; }
  public void Die() 
  {
    anim.Play("Die");
    Destroy(gameObject, 3f);
  }
  public void Add(float amt) 
  {
    playerHealth += amt;
  }
}
