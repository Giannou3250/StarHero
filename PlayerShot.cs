using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot : MonoBehaviour
{
  public GameObject bulletPrefab;
  public float timer = 1f; // bullet time till despawn
  // timer for every quarter second
  public float fireDelay = 0.25f;
  float cooldownTimer = 0;

  
  void Update () {

    // timer for every quarter second

    cooldownTimer = cooldownTimer - Time.deltaTime;

    /*
    The segment of code below will allow the player to fire a weapon
    once the spacebar is pressed, cooldown timer will be set to firedelay to allow
    for buffer between shots
    */
    if(Input.GetButton("Fire1") && cooldownTimer <= 0)
    {
      // timer for every quarter second
      cooldownTimer = fireDelay;

      // set the bullets travel direction correlated to the players current direction
      Vector3 offset = transform.rotation * new Vector3(0, 0.5f, 0);
      //instantiate the bullet
      Instantiate(bulletPrefab, transform.position + offset, transform.rotation);
      ;


    }
  }
}
