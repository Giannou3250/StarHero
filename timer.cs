using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer1 : MonoBehaviour
{
  public Text timerText;
  private float StartTime;
  int timestart = 1; // This value timestart is mainly responsible for seeing if the same has started. 
  // it does so by decrementing itself when the playership is found to indicate the gamed has started.
  
    // Update is called once per frame
    void Update()
    {
    /*
     Gameobject "timeEnd" is a gameobject reference to the playership clone that exists
     as the game is being played.
    */
      GameObject timeEnd = GameObject.Find("PlayerShip(Clone)");
      if (timeEnd != null && timestart != 0)
      {
        StartTime = Time.time;
        timestart --;
      }
      if (timeEnd != null)
      {
        /*
         The "minutes" string variable created will hold the game duration in minutes. updated per frame
         The "seconds" string variable created will hold the game duration in seconds. updated per frame
        */
        float t = Time.time - StartTime;
        string minutes = ((int) t / 60).ToString();
        string seconds = ((int) (t % 60)).ToString();
        timerText.text = minutes + " : " + seconds;
      }


    }
}
