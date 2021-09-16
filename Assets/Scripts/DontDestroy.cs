using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DontDestroy : MonoBehaviour
{
  private GameObject[] music;
  private void Awake()
  {

    DontDestroyOnLoad(this.gameObject);
  }
  private void Update()
  {
    music = GameObject.FindGameObjectsWithTag("Music");
    
    if (music.Length > 1) { Destroy(music[1]); }
  }
}
