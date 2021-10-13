using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerSpawner : MonoBehaviour
{
  public GameObject PlayerShip;
  public GameObject playerInstance;
    // Play is called before the first frame update
  public void Play()
  {
      //spawn the player in at the center of the screen when the game begins
      playerInstance =  (GameObject)Instantiate(PlayerShip, transform.position, Quaternion.identity);

  }

  void update()
  {
    
}
}
