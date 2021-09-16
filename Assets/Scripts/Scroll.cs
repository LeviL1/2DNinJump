using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Scroll : MonoBehaviour
{
  public Animator anim; //anim attach to finished txt box
  private AudioSource _aud; //audiosource attached to the scroll
    // Start is called before the first frame update
    void Start()
    {
    _aud = this.GetComponent<AudioSource>(); //get the audio source
    }

   //Upon entering trigger of tag is player than do FinishedLevel() couroutine 
  private void OnTriggerEnter2D(Collider2D other)
  {
    
    if (other.tag == "Player") 
    {

      StartCoroutine(FinishLevel());

    }
  }

  IEnumerator FinishLevel()
  {
    _aud.Play(); //plays scroll audioclip
    anim.Play("TextShow"); //plays finished animation
        yield return new WaitForSeconds(3); //waits for finished anim to complete
    SceneManager.LoadScene(5, LoadSceneMode.Single); //load the finished scene
  }

}
