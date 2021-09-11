using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneSwitch : MonoBehaviour
{
  public static void LoadLevelSelect() 
  {
    SceneManager.LoadScene(0, LoadSceneMode.Single);
  }
  public void LoadLevelOne() 
  {
    SceneManager.LoadScene(2, LoadSceneMode.Single);
  }
  public void LoadLevelTwo() 
  {
    SceneManager.LoadScene(3, LoadSceneMode.Single);
  }
  public void ExitGame() 
  {
    Application.Quit();
  }
  public void LoadMainMenu() 
  {
    SceneManager.LoadScene(1, LoadSceneMode.Single);
  }
}