using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingSound : MonoBehaviour
{
  //fireDelay is a float value which will determine the rate of fire for the startship gun
  public float fireDelay = 0.25f;
  float cooldownTimer = 0;
  public AudioSource shot;
    // Start is called before the first frame update
    void Start()
    {
      // get the audiosouce object that is tied to this script on unity (aka the gunshot sound)
      shot = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
    cooldownTimer = cooldownTimer - Time.deltaTime;
    /*
    The segment of code below represents finding the player object in the game instance 
    and essentially playing an audible audio sound for gunfire that correlates to weapon shooting and its cooldown
    meaning that everytime the player shoots their weapon audio will play with it.
    */
    GameObject go = GameObject.Find("PlayerShip(Clone)");
    if (go != null)
    {
    if(Input.GetButton("Fire1") && cooldownTimer <= 0)
    {
      // timer for every quarter second
      cooldownTimer = fireDelay;
      // play the gunshot sound
      shot.Play();


    }
  }
}
}
