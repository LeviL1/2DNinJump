using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateHealth : MonoBehaviour
{
  private PlayerHealth playerH;
  private Text healthTxt;
    // Start is called before the first frame update
    void Start()
    {
      healthTxt = this.GetComponent<Text>();
    playerH = FindObjectOfType<PlayerHealth>(); 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
    healthTxt.text = playerH.playerHealth.ToString();
    }
}
