using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayGame : MonoBehaviour
{
  // load the game scene
  public void Play ()
  {
    SceneManager.LoadScene("SampleScene*");
  }
}
