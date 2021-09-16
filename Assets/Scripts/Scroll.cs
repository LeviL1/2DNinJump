using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Scroll : MonoBehaviour
{
  public Animator anim;
  private AudioSource _aud;
    // Start is called before the first frame update
    void Start()
    {
    _aud = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  private void OnTriggerEnter2D(Collider2D other)
  {
    
    if (other.tag == "Player") 
    {

      StartCoroutine(FinishLevel());

    }
  }

  IEnumerator FinishLevel()
  {
    _aud.Play();
    anim.Play("TextShow");
    yield return new WaitForSeconds(3);
    SceneManager.LoadScene(5, LoadSceneMode.Single);
  }

}
