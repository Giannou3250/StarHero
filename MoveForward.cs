using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
  float maxSpeed = 10f; //player movement speed


    void Update()
    {
      // the segement of code below is responsible for moving the players direction forward
      Vector3 pos = transform.position; 
      Vector3 velocity = new Vector3(0, Time.deltaTime * maxSpeed, 0); 
      pos += transform.rotation * velocity;
      transform.position = pos;
    }
}
