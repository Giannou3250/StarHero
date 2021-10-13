using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FollowsPlayer2 : MonoBehaviour
{
public int countdownTime = 10;
  private float maxSpeed = 3f;
  int speedCounter = 0;
  Transform player;



  void Start()
{
//  StartCoroutine(counttoSpeed());
}
    // Update is called once per frame
    void Update()
    {


      //----------------------Look at Player---------------------------------//
        if (player == null)
        // Find the players ship
        {
          GameObject go = GameObject.Find("PlayerShip(Clone)");
        //

        if (go != null)
        player = go.transform;
         }
    if (player == null)
    {
      return;
    }

    Vector3 dir = player.position - transform.position;
    dir.Normalize();

    float zAngle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - (90 + 180);

    transform.rotation = Quaternion.Euler(0, 0, zAngle );

    //---------------------------End-------------------------------------------//

      //----------------------Move Towards player---------------------------------//
    Vector3 pos = transform.position;
    Vector3 velocity = new Vector3(0, Time.deltaTime * GetComponent<FollowsPlayer2>().maxSpeed, 0);
    pos += (transform.rotation * velocity) * -1;
    transform.position = pos;
    //---------------------------------End---------------------------------------//
    speedCounter ++;

  }
  public float getMaxSpeed()
  {
    return maxSpeed;
  }
  public void setMaxSpeed(float x)
  {
    maxSpeed = x;
  }

}
