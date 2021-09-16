using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateHealth : MonoBehaviour
{
  private PlayerHealth playerH; //the player health amount
  private Text healthTxt; //textbox for displaying health
    // Start is called before the first frame update
    void Start()
    {
      healthTxt = this.GetComponent<Text>(); //get the text component
    playerH = FindObjectOfType<PlayerHealth>();  //find the player objects health
    }

    // Update is called once per frame
    void FixedUpdate()
    {
    healthTxt.text = playerH.playerHealth.ToString(); //set the textbox to the playerhealth every fixed update
    }
}
