using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScene : MonoBehaviour
{
  public int counter1 = 0;
   public  int j = 0;
  int counter = 0;
  public int timer = 10;
  IEnumerator waiter()
{

  //yield on a new YieldInstruction that waits for 7 seconds.
       yield return new WaitForSeconds(7);
  // this line of code below will reload the current scene in unity
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
}

    // Update is called once per frame
    void Update()
    {

      /*
      Check if the playership currently exists in the game instance. If it does then increment the
      value of "counter" to 1 (initially 0)
      */
      GameObject go = GameObject.Find("PlayerShip(Clone)");
      if (go != null)
      {
        counter = counter + 1;
      }
      // at this point counter will be > 1 because the player ship has been existing for some time
      if (counter > 1)
      {
      /* 
      check if the game object is dead or not, if it is then display game ending text such as
      final game time.
      */
      if (go == null)
      {
        GameObject endtext = GameObject.Find("End");
        GameObject endtext1 = GameObject.Find("GameTime");
        // transform will take endtext and move it to the corresponding x and y value on the 2D grid
        endtext.transform.position = new Vector2(1000, 500);
        // transform will take endtext1 and move it to the corresponding x and y value on the 2D grid
        endtext1.transform.position = new Vector2(1500, 525);
        // call the waiter function to wait 7 seconds
        StartCoroutine(waiter());
      

      }
    }
}
}
